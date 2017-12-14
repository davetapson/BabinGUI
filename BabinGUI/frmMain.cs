using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBClient;

namespace GUI
{
    public delegate void MyDelegate(string availableFunds);

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ConnectToIBClient();
        }

        private void ConnectToIBClient()
        {
            IBGatewayClientConnectionData iBGatewayClientConnectionData = new IBGatewayClientConnectionData("", 4002, 1001);
            ClientManager clientManager = new ClientManager(iBGatewayClientConnectionData, this);
            clientManager.Connect();
        }

        internal void SetAccountValue(string accountValue)
        {
            lblAccountValue.Invoke(new Action(() => lblAccountValue.Text = string.Format("{0:C}", accountValue)));
        }

        public void SetConnectionStatus(string connectionStatus)
        {
            lblConnectionStatus.Text = connectionStatus;
        }

        public string AccountNumber()
        {
            return txtAccountNumber.Text;
        }

        public void SetAvailableFunds(string availableFunds)
        {
            lblAvailableFunds.Invoke(new Action(() => lblAvailableFunds.Text = string.Format("{0:C}", availableFunds)));
        }

        public void SetNotifications(string notifications)
        {
            lstNotifications.Invoke(new Action(() => lstNotifications.Items.Add(notifications)));
            lstNotifications.Visible = true;
        }
    }
}
/*
Hi,

I found your contact info on the interactive brokers site.I am interested in creating a very simple automated order for myself and wanted to see if you could be of assistance:

I want to be able to set a stop limit buy order for a specific stock and automatically have that order place a stop order .01/.05 cents (depending on the stocks minimum trade increment) at the days low on the day of execution.
Additionally I would like the order to automatically calculate the correct number of shares to buy depending on the amount of capital under management I would like to place at risk.

It would have the following fields:
I would manually input the:
Ticker
Stop and Stop Limit Buy

The algorithm would automatically(once the buy stop is triggered)
Determine order size based on the account size and the percent of the account to be risked or just a nominal dollar value based on the entry and the stop price
Create a stop order at the day low minus .01/.05 (depending on the stock) for stop loss

Hopefully that makes sense.If you are interested please let me know and what the cost for developing this would be.  

Thank you,
*/

