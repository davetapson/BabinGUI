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
using IBApi;
using BabinGUI.BL.eventArgs;
using System.Globalization;
using BabinGUI.BL.utils;
using BabinGUI.BL.messages;

namespace GUI
{
    public delegate void MyDelegate(string availableFunds);

    public partial class frmMain : Form
    {
        ClientManager clientManager;
        BindingList<BuyOrder> buyOrders = new BindingList<BuyOrder>();

        decimal _netLiquidation = -1;
        decimal _availableFunds = -1;

        public List<MarketRule> MarketRules { get; internal set; }
        private List<ContractDetail> contractDetails;
        

        public frmMain()
        {
            InitializeComponent();
            InitializeControls(); ;
        }

        private void InitializeControls()
        {
            InitializeOffsetsComboBox();
            InitializeGrid();
            InitializeNumberUpDowns();
            contractDetails = new List<ContractDetail>();
        }

        private void InitializeNumberUpDowns()
        {
            numRiskPercent.Value = BabinGUI.Properties.Settings.Default.RiskPercent;
        }

        private void InitializeGrid()
        {
            BuyOrder buyOrder = new BuyOrder(1, "AA", 10.00m, 10.01m, 2.0m, 0, true, 0.1m);
            buyOrders.Add(buyOrder);
            buyOrder = new BuyOrder(2, "BB", 11.00m, 11.01m, 0, 2.5m, false, 0.5m);
            buyOrders.Add(buyOrder);
            dgvBuyOrders.DataSource = buyOrders;
            

            //Id
            dgvBuyOrders.Columns[0].Width = BabinGUI.Properties.Settings.Default.Col0Width;
            dgvBuyOrders.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ticker
            dgvBuyOrders.Columns[1].Width = BabinGUI.Properties.Settings.Default.Col1Width;
            
            // Stop
            dgvBuyOrders.Columns[2].Width = BabinGUI.Properties.Settings.Default.Col2Width;
            dgvBuyOrders.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // StopBuyLimit
            dgvBuyOrders.Columns[3].Width = BabinGUI.Properties.Settings.Default.Col3Width;
            dgvBuyOrders.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //Risk Percent
            dgvBuyOrders.Columns[4].Width = BabinGUI.Properties.Settings.Default.Col4Width;
            dgvBuyOrders.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //Dollar Value
            dgvBuyOrders.Columns[5].Width = BabinGUI.Properties.Settings.Default.Col5Width;
            dgvBuyOrders.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Use Risk Percent
            dgvBuyOrders.Columns[6].Width = BabinGUI.Properties.Settings.Default.Col6Width; ;
            dgvBuyOrders.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Price OffSet
            dgvBuyOrders.Columns[7].Width = BabinGUI.Properties.Settings.Default.Col7Width; ;
            dgvBuyOrders.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Current Position Size
            dgvBuyOrders.Columns[8].Width = BabinGUI.Properties.Settings.Default.Col8Width; ;
            dgvBuyOrders.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Current Price
            dgvBuyOrders.Columns[9].Width = BabinGUI.Properties.Settings.Default.Col9Width; ;
            dgvBuyOrders.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Low
            dgvBuyOrders.Columns[10].Width = BabinGUI.Properties.Settings.Default.Col10Width; ;
            dgvBuyOrders.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Order Status
            dgvBuyOrders.Columns[11].Width = BabinGUI.Properties.Settings.Default.Col11Width; ;
            dgvBuyOrders.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Delete
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Width = BabinGUI.Properties.Settings.Default.Col8Width;
            deleteButtonColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach(DataGridViewColumn column in dgvBuyOrders.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            int columnIndex = dgvBuyOrders.ColumnCount;
            if (dgvBuyOrders.Columns["Delete"] == null)
            {
                dgvBuyOrders.Columns.Insert(columnIndex, deleteButtonColumn);
            }
            dgvBuyOrders.CellClick += dgvBuyOrders_CellClick;
        }

        internal void UpdateTickPrice(TickPriceArgs eventArgs)
        {
            BuyOrder buyOrder;

            switch (eventArgs.TickPrice.Field)  
            {
               case (TickType.ASK):
                    buyOrder = buyOrders.FirstOrDefault(i => i.Id == eventArgs.TickPrice.TickerId);
                    buyOrder.CurrentPrice = (decimal)eventArgs.TickPrice.Price;
                    dgvBuyOrders.Invoke(new Action(() => dgvBuyOrders.Refresh()));
                    CheckForBuy(buyOrders);
                    break;
                case (TickType.LOW):
                    buyOrder = buyOrders.FirstOrDefault(i => i.Id == eventArgs.TickPrice.TickerId);
                    buyOrder.Low = (decimal)eventArgs.TickPrice.Price;
                    dgvBuyOrders.Invoke(new Action(() => dgvBuyOrders.Refresh()));
                    break;
            }

        }

        internal void UpdateContractDetail(ContractDetail contractDetail)
        {
            contractDetails.Add(contractDetail);
            if (contractDetail.ContractDetails.MarketRuleIds != null)
            {
                foreach(int marketRuleId in contractDetail.ContractDetails.MarketRuleIds)
                {
                    clientManager.RequestMarketRule(marketRuleId);
                }                
            }
        }

        private void CheckForBuy(BindingList<BuyOrder> buyOrders)
        {
            foreach(BuyOrder buyOrder in buyOrders)
            {
                if (buyOrder.StopBuyLimit < buyOrder.CurrentPrice)
                {
                   clientManager.PlaceLimitBuyOrder(buyOrder.Id, buyOrder.Ticker, buyOrder.CurrentPositionSize, buyOrder.CurrentPrice);
                }
            }
        }

        private void dgvBuyOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvBuyOrders.Columns["Delete"].Index)
            {
                buyOrders.RemoveAt(e.RowIndex);
            }
        }

        private void InitializeOffsetsComboBox()
        {
            string offSetString = BabinGUI.Properties.Settings.Default.PriceOffset;
            string[] offSets = offSetString.Split('^');
            foreach (string offSet in offSets)
            {
                cboOffSet.Items.Add(Convert.ToDecimal(offSet));
            }
            if (cboOffSet.Items.Count > 0) cboOffSet.SelectedIndex = 0;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveFormState()
        {
            BabinGUI.Properties.Settings.Default.Col0Width = dgvBuyOrders.Columns[1].Width;
            BabinGUI.Properties.Settings.Default.Col1Width = dgvBuyOrders.Columns[2].Width;
            BabinGUI.Properties.Settings.Default.Col2Width = dgvBuyOrders.Columns[3].Width;
            BabinGUI.Properties.Settings.Default.Col3Width = dgvBuyOrders.Columns[4].Width;
            BabinGUI.Properties.Settings.Default.Col4Width = dgvBuyOrders.Columns[5].Width;
            BabinGUI.Properties.Settings.Default.Col5Width = dgvBuyOrders.Columns[6].Width;
            BabinGUI.Properties.Settings.Default.Col6Width = dgvBuyOrders.Columns[7].Width;
            BabinGUI.Properties.Settings.Default.Col7Width = dgvBuyOrders.Columns[8].Width;
            BabinGUI.Properties.Settings.Default.Col8Width = dgvBuyOrders.Columns[9].Width;
            BabinGUI.Properties.Settings.Default.Col9Width = dgvBuyOrders.Columns[10].Width;
            BabinGUI.Properties.Settings.Default.Col10Width = dgvBuyOrders.Columns[11].Width;
            BabinGUI.Properties.Settings.Default.Col11Width = dgvBuyOrders.Columns[0].Width;
            
            BabinGUI.Properties.Settings.Default.Save();
        }

        private void ConnectToIBClient()
        {
            IBGatewayClientConnectionData iBGatewayClientConnectionData = new IBGatewayClientConnectionData("", 4002, 1001);
            clientManager = new ClientManager(iBGatewayClientConnectionData, this);
            clientManager.Connect();
        }

        internal void UpdateNetLiquidation(string netLiquidation)
        {
            bool result = decimal.TryParse(netLiquidation, NumberStyles.Any, CultureInfo.InvariantCulture, out _netLiquidation);

            string value = Utils.FormatStringToCurrency(netLiquidation);
            txtNetLiquidation.Invoke(new Action(() => txtNetLiquidation.Text = value));
        }    

        internal void SetTotalCashValue(string accountValue)
        {
            //lblPositionsValue.Invoke(new Action(() => lblPositionsValue.Text = string.Format("{0:C}", accountValue)));
        }

        public void SetConnectionStatus(bool connected)
        {
            if (connected)
            {
                lblConnectionStatus.Text = "Connected";
                btnConnect.Text = "Disconnect";
                btnPlaceOrder.Enabled = true; 
            }
            else
            {
                lblConnectionStatus.Invoke(new Action(() => lblConnectionStatus.Text = "Not Connected"));
                btnConnect.Invoke(new Action(() => btnConnect.Text = "Connect"));
                btnPlaceOrder.Invoke(new Action(() => btnPlaceOrder.Enabled = false));
            }
        }

        public string AccountNumber()
        {
            return txtAccountNumber.Text;
        }

        public void UpdateAvailableFunds(string availableFunds)
        {
            bool result = decimal.TryParse(availableFunds, NumberStyles.Any, CultureInfo.InvariantCulture, out _availableFunds);

            string value = Utils.FormatStringToCurrency(availableFunds);
            txtAvailableFunds.Invoke(new Action(() => txtAvailableFunds.Text = value));
        }

        public void UpdateNotifications(ErrorArgs eventArgs)
        {
            if (eventArgs.Error.Message == "Connection closed.")
            {
                eventArgs.Error.Message = eventArgs.Error.Message + " " + DateTime.Now;
                SetConnectionStatus(false);
            }
            lstNotifications.Invoke(new Action(() => lstNotifications.Items.Insert(0, eventArgs.Error.Message)));
            lstNotifications.Invoke(new Action(() => updateNotifications()));
        }

        private void updateNotifications()
        {
            lstNotifications.Items[0] = lstNotifications.Items[0];
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(btnConnect.Text == "Connect")
            {
                ConnectToIBClient();
            } 
            else
            {
                clientManager.Disconnect();
                btnConnect.Text = "Connect";
                lblConnectionStatus.Text = "Disconnected"; // todo - parameterise
                btnPlaceOrder.Enabled = false;
            }
            
        }

        internal void AddNotification(string notification)
        {
            lstNotifications.Items.Insert(0, notification);
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // create buy order - this will add to grid
                BuyOrder buyOrder = new BuyOrder(GetNextId(), txtTicker.Text, numStop.Value, numStopBuyLimit.Value, numRiskPercent.Value, numDollarValue.Value, rdoUseRiskPercent.Checked, Convert.ToDecimal(cboOffSet.Text));
                buyOrders.Add(buyOrder);
                SubscribeTicker(buyOrder);

                // req contract details for Order
                clientManager.RequestContractDetails(buyOrder.Id, buyOrder.Ticker);
            }
            catch (ArgumentNullException ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SubscribeTicker(BuyOrder buyOrder)
        {
            Contract contract = new Contract();
            contract.Symbol = txtTicker.Text;
            contract.SecType = "STK";
            contract.Exchange = "SMART";
            if (txtTicker.Text == "MSFT") contract.PrimaryExch = "NASDAQ"; // todo paramaterise
            contract.Currency = "USD";

            clientManager.RequestMarketData(contract, buyOrder);
        }

        private int GetNextId()
        {
            return buyOrders.OrderByDescending(x => x.Id).FirstOrDefault() == null ? 1 : buyOrders.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFormState();
        }

        private void txtNetLiquidation_TextChanged(object sender, EventArgs e)
        {
            CalculatePositionSize();
        }

        private void CalculatePositionSize()
        {
            if (string.IsNullOrWhiteSpace(txtNetLiquidation.Text) || string.IsNullOrWhiteSpace(txtAvailableFunds.Text)) return;
            if (_netLiquidation == -1 || _availableFunds == -1) return;

            foreach(BuyOrder buyOrder in buyOrders)
            {
                if(buyOrder.CurrentPrice <= 0) { continue; }

                if (buyOrder.UseRiskPercent)
                {
                    decimal positionValue = _netLiquidation * (decimal)buyOrder.RiskPercent / 100;
                    decimal funds = _availableFunds < positionValue ? _availableFunds : positionValue;
                    int positionSize = (int)Math.Floor(funds / buyOrder.CurrentPrice);

                    buyOrder.CurrentPositionSize = positionSize;
                } else
                {
                    decimal funds = _availableFunds < buyOrder.DollarValue ? _availableFunds : (decimal)buyOrder.DollarValue;
                    int positionSize = (int)Math.Floor(funds / buyOrder.CurrentPrice);

                    buyOrder.CurrentPositionSize = positionSize;
                }
            }

            dgvBuyOrders.Refresh();
        }

        private void txtAvailableFunds_TextChanged(object sender, EventArgs e)
        {
            CalculatePositionSize();
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

