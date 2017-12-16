using BabinGUI.BL.eventArgs;
using IBApi;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;

namespace IBClient
{
    public class ClientManager
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        EWrapperImpl ibClient;
        private IBGatewayClientConnectionData iBGatewayClientConnectionData;
        private GUI.frmMain frmMain;
        string strTimeOutMessage = "Connecton Timeout";

        public void UpdateAccountValue(object sender, AccountValueArgs eventArgs) {
            switch (eventArgs.AccountValue.Key())
            {
                case "AvailableFunds":
                    frmMain.UpdateAvailableFunds(eventArgs.AccountValue.Value());
                    break;
                case "NetLiquidation":
                    frmMain.UpdateNetLiquidation(eventArgs.AccountValue.Value());
                    break;
                case "TotalCashValue":
                    frmMain.SetTotalCashValue(eventArgs.AccountValue.Value());
                    break;
                default:
                    break;
            }
        }

        public void UpdateTickPrice(object sender, TickPriceArgs eventArgs)
        {
            frmMain.UpdateTickPrice(eventArgs);
        }

        public void UpdateError(object sender, ErrorArgs eventArgs)
        {
            frmMain.UpdateNotifications(eventArgs);
        }
            public ClientManager(IBGatewayClientConnectionData iBGatewayClientConnectionData, GUI.frmMain frmMain)
        {
            this.iBGatewayClientConnectionData = iBGatewayClientConnectionData;
            this.frmMain = frmMain;
        }

        public void Connect()
        {
            try
            {
                ibClient = new EWrapperImpl();

                // subscribe to events triggered by wrapper, to update form
                ibClient.AccountValueUpdated += UpdateAccountValue;
                ibClient.TickPriceUpdated += UpdateTickPrice;
                ibClient.ErrorUpdated += UpdateError;

                ibClient.ClientSocket.eConnect(iBGatewayClientConnectionData.Server,
                                                    iBGatewayClientConnectionData.Port,
                                                    iBGatewayClientConnectionData.ClientId);

                var reader = new EReader(ibClient.ClientSocket, ibClient.Signal);
                reader.Start();
                new Thread(() =>
                {
                    while (ibClient.ClientSocket.IsConnected())
                    {
                        ibClient.Signal.waitForSignal();
                        reader.processMsgs();
                    }
                })
                { IsBackground = true }.Start();

                // Pause here until the connection is complete
                DateTime connectionTime = DateTime.Now;
                while (ibClient.NextOrderId <= 0)
                {
                    if (DateTime.Now > connectionTime.AddSeconds(1)) { throw new Exception(strTimeOutMessage); }
                }

                frmMain.SetConnectionStatus(true);

                SubscribeAccount(ibClient, frmMain.AccountNumber());
            }
            catch (Exception e)
            {
                if(e.Message == strTimeOutMessage)
                {
                    frmMain.AddNotification("Connection timeout.  Please check that IB Gateway or TWS is running.");
                    return;
                }
                throw;
            }
        }

        internal void Disconnect()
        {
            ibClient.ClientSocket.Close();
        }

        private void SubscribeAccount(EWrapperImpl ibClient, string accountNumber)
        {
            ibClient.ClientSocket.reqAccountUpdates(true, accountNumber);
        }

        internal void RequestMarketData(Contract contract, BuyOrder buyOrder)
        {
            logger.Info("Requesting Market Data: " + contract.ToString() + buyOrder.ToString());
            ibClient.ClientSocket.reqMktData(buyOrder.Id, contract, "", false, false, null);
        }

        internal void CancelMarketData(int buyOrderId)
        {
            ibClient.ClientSocket.cancelMktData(buyOrderId);
            
        }
    }
}
