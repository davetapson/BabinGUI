namespace GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtTicker = new System.Windows.Forms.TextBox();
            this.numStopBuyLimit = new System.Windows.Forms.NumericUpDown();
            this.numStop = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numRiskPercent = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numDollarValue = new System.Windows.Forms.NumericUpDown();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.dgvBuyOrders = new System.Windows.Forms.DataGridView();
            this.rdoUseRiskPercent = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lstNotifications = new System.Windows.Forms.ListBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lblForAvailableFunds = new System.Windows.Forms.Label();
            this.lblForAccountValue = new System.Windows.Forms.Label();
            this.lblForPositionsValue = new System.Windows.Forms.Label();
            this.lblPositionsValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboOffSet = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtNetLiquidation = new System.Windows.Forms.TextBox();
            this.txtAvailableFunds = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numStopBuyLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRiskPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDollarValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticker:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stop Buy Limit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stop:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Account:";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Enabled = false;
            this.txtAccountNumber.Location = new System.Drawing.Point(68, 12);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNumber.TabIndex = 4;
            this.txtAccountNumber.Text = "DU271448";
            // 
            // txtTicker
            // 
            this.txtTicker.Location = new System.Drawing.Point(168, 44);
            this.txtTicker.Name = "txtTicker";
            this.txtTicker.Size = new System.Drawing.Size(120, 20);
            this.txtTicker.TabIndex = 0;
            // 
            // numStopBuyLimit
            // 
            this.numStopBuyLimit.DecimalPlaces = 2;
            this.numStopBuyLimit.Location = new System.Drawing.Point(168, 91);
            this.numStopBuyLimit.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numStopBuyLimit.Name = "numStopBuyLimit";
            this.numStopBuyLimit.Size = new System.Drawing.Size(120, 20);
            this.numStopBuyLimit.TabIndex = 2;
            this.numStopBuyLimit.ThousandsSeparator = true;
            // 
            // numStop
            // 
            this.numStop.DecimalPlaces = 2;
            this.numStop.Location = new System.Drawing.Point(168, 68);
            this.numStop.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numStop.Name = "numStop";
            this.numStop.Size = new System.Drawing.Size(120, 20);
            this.numStop.TabIndex = 1;
            this.numStop.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Risk Percent:";
            // 
            // numRiskPercent
            // 
            this.numRiskPercent.DecimalPlaces = 2;
            this.numRiskPercent.Location = new System.Drawing.Point(168, 136);
            this.numRiskPercent.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRiskPercent.Name = "numRiskPercent";
            this.numRiskPercent.Size = new System.Drawing.Size(120, 20);
            this.numRiskPercent.TabIndex = 3;
            this.numRiskPercent.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "$ Value:";
            // 
            // numDollarValue
            // 
            this.numDollarValue.DecimalPlaces = 2;
            this.numDollarValue.Location = new System.Drawing.Point(168, 160);
            this.numDollarValue.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numDollarValue.Name = "numDollarValue";
            this.numDollarValue.Size = new System.Drawing.Size(120, 20);
            this.numDollarValue.TabIndex = 5;
            this.numDollarValue.ThousandsSeparator = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Enabled = false;
            this.btnPlaceOrder.Location = new System.Drawing.Point(213, 194);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceOrder.TabIndex = 7;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // dgvBuyOrders
            // 
            this.dgvBuyOrders.AllowUserToAddRows = false;
            this.dgvBuyOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuyOrders.Location = new System.Drawing.Point(12, 225);
            this.dgvBuyOrders.Name = "dgvBuyOrders";
            this.dgvBuyOrders.ReadOnly = true;
            this.dgvBuyOrders.RowHeadersVisible = false;
            this.dgvBuyOrders.Size = new System.Drawing.Size(952, 319);
            this.dgvBuyOrders.TabIndex = 0;
            this.dgvBuyOrders.TabStop = false;
            // 
            // rdoUseRiskPercent
            // 
            this.rdoUseRiskPercent.AutoSize = true;
            this.rdoUseRiskPercent.Checked = true;
            this.rdoUseRiskPercent.Location = new System.Drawing.Point(297, 140);
            this.rdoUseRiskPercent.Name = "rdoUseRiskPercent";
            this.rdoUseRiskPercent.Size = new System.Drawing.Size(14, 13);
            this.rdoUseRiskPercent.TabIndex = 4;
            this.rdoUseRiskPercent.TabStop = true;
            this.rdoUseRiskPercent.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(297, 164);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lstNotifications
            // 
            this.lstNotifications.FormattingEnabled = true;
            this.lstNotifications.Items.AddRange(new object[] {
            "Notifications"});
            this.lstNotifications.Location = new System.Drawing.Point(12, 550);
            this.lstNotifications.Name = "lstNotifications";
            this.lstNotifications.Size = new System.Drawing.Size(683, 82);
            this.lstNotifications.TabIndex = 19;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(255, 15);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(79, 13);
            this.lblConnectionStatus.TabIndex = 20;
            this.lblConnectionStatus.Text = "Not Connected";
            // 
            // lblForAvailableFunds
            // 
            this.lblForAvailableFunds.AutoSize = true;
            this.lblForAvailableFunds.Location = new System.Drawing.Point(664, 46);
            this.lblForAvailableFunds.Name = "lblForAvailableFunds";
            this.lblForAvailableFunds.Size = new System.Drawing.Size(85, 13);
            this.lblForAvailableFunds.TabIndex = 21;
            this.lblForAvailableFunds.Text = "Available Funds:";
            // 
            // lblForAccountValue
            // 
            this.lblForAccountValue.AutoSize = true;
            this.lblForAccountValue.Location = new System.Drawing.Point(664, 20);
            this.lblForAccountValue.Name = "lblForAccountValue";
            this.lblForAccountValue.Size = new System.Drawing.Size(111, 13);
            this.lblForAccountValue.TabIndex = 23;
            this.lblForAccountValue.Text = "Net Liquidation Value:";
            // 
            // lblForPositionsValue
            // 
            this.lblForPositionsValue.AutoSize = true;
            this.lblForPositionsValue.Location = new System.Drawing.Point(726, 120);
            this.lblForPositionsValue.Name = "lblForPositionsValue";
            this.lblForPositionsValue.Size = new System.Drawing.Size(64, 13);
            this.lblForPositionsValue.TabIndex = 29;
            this.lblForPositionsValue.Text = "Cash Value:";
            // 
            // lblPositionsValue
            // 
            this.lblPositionsValue.AutoSize = true;
            this.lblPositionsValue.Location = new System.Drawing.Point(796, 120);
            this.lblPositionsValue.Name = "lblPositionsValue";
            this.lblPositionsValue.Size = new System.Drawing.Size(79, 13);
            this.lblPositionsValue.TabIndex = 30;
            this.lblPositionsValue.Text = "Positions Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Price Offset:";
            // 
            // cboOffSet
            // 
            this.cboOffSet.FormattingEnabled = true;
            this.cboOffSet.Location = new System.Drawing.Point(504, 175);
            this.cboOffSet.Name = "cboOffSet";
            this.cboOffSet.Size = new System.Drawing.Size(40, 21);
            this.cboOffSet.TabIndex = 32;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(174, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 33;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtNetLiquidation
            // 
            this.txtNetLiquidation.Enabled = false;
            this.txtNetLiquidation.Location = new System.Drawing.Point(781, 17);
            this.txtNetLiquidation.Name = "txtNetLiquidation";
            this.txtNetLiquidation.Size = new System.Drawing.Size(125, 20);
            this.txtNetLiquidation.TabIndex = 34;
            this.txtNetLiquidation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNetLiquidation.TextChanged += new System.EventHandler(this.txtNetLiquidation_TextChanged);
            // 
            // txtAvailableFunds
            // 
            this.txtAvailableFunds.Enabled = false;
            this.txtAvailableFunds.Location = new System.Drawing.Point(781, 43);
            this.txtAvailableFunds.Name = "txtAvailableFunds";
            this.txtAvailableFunds.Size = new System.Drawing.Size(125, 20);
            this.txtAvailableFunds.TabIndex = 35;
            this.txtAvailableFunds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAvailableFunds.TextChanged += new System.EventHandler(this.txtAvailableFunds_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 644);
            this.Controls.Add(this.txtAvailableFunds);
            this.Controls.Add(this.txtNetLiquidation);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cboOffSet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPositionsValue);
            this.Controls.Add(this.lblForPositionsValue);
            this.Controls.Add(this.lblForAccountValue);
            this.Controls.Add(this.lblForAvailableFunds);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.lstNotifications);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rdoUseRiskPercent);
            this.Controls.Add(this.dgvBuyOrders);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.numDollarValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numRiskPercent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numStop);
            this.Controls.Add(this.numStopBuyLimit);
            this.Controls.Add(this.txtTicker);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numStopBuyLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRiskPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDollarValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtTicker;
        private System.Windows.Forms.NumericUpDown numStopBuyLimit;
        private System.Windows.Forms.NumericUpDown numStop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numRiskPercent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numDollarValue;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.DataGridView dgvBuyOrders;
        private System.Windows.Forms.RadioButton rdoUseRiskPercent;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ListBox lstNotifications;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label lblForAvailableFunds;
        private System.Windows.Forms.Label lblForAccountValue;
        private System.Windows.Forms.Label lblForPositionsValue;
        private System.Windows.Forms.Label lblPositionsValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboOffSet;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtNetLiquidation;
        private System.Windows.Forms.TextBox txtAvailableFunds;
    }
}

