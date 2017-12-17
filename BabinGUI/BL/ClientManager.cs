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
        int orderNumber;

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

        public void UpdateMarketRule(object sender, MarketRuleArgs eventArgs) {
            frmMain.MarketRules.Add(eventArgs.MarketRule);
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
                ibClient.MarketRuleUpdated += UpdateMarketRule;
                ibClient.ContractDetailsUpdated += UpdateContractDetails;

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

                orderNumber = ibClient.NextOrderId;

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

        private void UpdateContractDetails(object sender, ContractDetailArgs eventArgs)
        {
            frmMain.UpdateContractDetail(eventArgs.ContractDetail);
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

        internal void RequestContractDetails(int id, string ticker) {
            Contract contract = new Contract();
            contract.Symbol = ticker;
            contract.SecType = "STK";
            contract.Currency = "USD";
            contract.Exchange = "SMART";

            ibClient.ClientSocket.reqContractDetails(id, contract);
        }

        internal void RequestMarketRule(int ruleId)
        {
            ibClient.ClientSocket.reqMarketRule(ruleId);
        }

        internal void PlaceLimitBuyOrder(int id, string ticker, int quantity, decimal limitPrice)
        {
            Contract contract = new Contract();
            contract.Symbol = ticker;
            contract.SecType = "STK";
            contract.Currency = "USD";
            contract.Exchange = "SMART";

            Order order = new Order();
            order.OrderId = id;
            order.Action = "BUY";
            order.OrderType = "LMT";
            order.TotalQuantity = quantity;
            order.LmtPrice = (double)limitPrice;

            ibClient.ClientSocket.placeOrder(orderNumber++, contract, order);
        }

        internal void PlaceStopOrder(int id, string ticker, int quantity, decimal stopPrice)
        {
            Contract contract = new Contract();
            contract.Symbol = ticker;
            contract.SecType = "STK";
            contract.Currency = "USD";
            contract.Exchange = "SMART";

            Order order = new Order();
            order.OrderId = id;
            order.Action = "SELL";
            order.OrderType = "STP";
            order.AuxPrice = (double)stopPrice;
            order.TotalQuantity = quantity;

            ibClient.ClientSocket.placeOrder(orderNumber++, contract, order);
        }
    }
}
