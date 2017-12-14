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

namespace IBClient
{
    public class ClientManager
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        EWrapperImpl ibClient;
        private IBGatewayClientConnectionData iBGatewayClientConnectionData;
        private GUI.frmMain frmMain;

        public void UpdateAccountValue(object sender, AccountValueArgs eventArgs) {
            switch (eventArgs.AccountValue.Key())
            {
                case "AvailableFunds":
                    frmMain.SetAvailableFunds(eventArgs.AccountValue.Value());
                    break;
                case "NetLiquidation":
                    frmMain.SetAccountValue(eventArgs.AccountValue.Value());
                    break;
                default:
                    break;
            }
        }

        public void UpdateError(object sender, ErrorArgs eventArgs)
        {
            frmMain.SetNotifications(eventArgs.Error.ToString());
        }
            public ClientManager(IBGatewayClientConnectionData iBGatewayClientConnectionData, GUI.frmMain frmMain)
        {
            this.iBGatewayClientConnectionData = iBGatewayClientConnectionData;
            this.frmMain = frmMain;
        }

        public void Connect()
        {
            ibClient = new EWrapperImpl();
            
            // subscribe to events triggered by wrapper, to update form
            ibClient.AccountValueUpdated += UpdateAccountValue;
            ibClient.ErrorUpdated += UpdateError;

            ibClient.ClientSocket.eConnect( iBGatewayClientConnectionData.Server,
                                                iBGatewayClientConnectionData.Port,
                                                iBGatewayClientConnectionData.ClientId);

            var reader = new EReader(ibClient.ClientSocket, ibClient.Signal);
            reader.Start();
            new Thread(() => {
                while (ibClient.ClientSocket.IsConnected())
                {
                    ibClient.Signal.waitForSignal();
                    reader.processMsgs();
                }
            })
            { IsBackground = true }.Start();

            // Pause here until the connection is complete 
            while (ibClient.NextOrderId <= 0) { }

            frmMain.SetConnectionStatus("Connected");

            SubscribeAccount(ibClient, frmMain.AccountNumber());
        }

        private void SubscribeAccount(EWrapperImpl ibClient, string accountNumber)
        {
            ibClient.ClientSocket.reqAccountUpdates(true, accountNumber);
        }

    }
}
