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
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.dgvBuyOrders = new System.Windows.Forms.DataGridView();
            this.lstNotifications = new System.Windows.Forms.ListBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lblForAvailableFunds = new System.Windows.Forms.Label();
            this.lblForAccountValue = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtNetLiquidation = new System.Windows.Forms.TextBox();
            this.txtAvailableFunds = new System.Windows.Forms.TextBox();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdoUseRiskPercent = new System.Windows.Forms.RadioButton();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.numDollarValue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numRiskPercent = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numStop = new System.Windows.Forms.NumericUpDown();
            this.numStopBuyLimit = new System.Windows.Forms.NumericUpDown();
            this.txtTicker = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyOrders)).BeginInit();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDollarValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRiskPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStopBuyLimit)).BeginInit();
            this.SuspendLayout();
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
            // dgvBuyOrders
            // 
            this.dgvBuyOrders.AllowUserToAddRows = false;
            this.dgvBuyOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuyOrders.Location = new System.Drawing.Point(12, 198);
            this.dgvBuyOrders.Name = "dgvBuyOrders";
            this.dgvBuyOrders.ReadOnly = true;
            this.dgvBuyOrders.RowHeadersVisible = false;
            this.dgvBuyOrders.Size = new System.Drawing.Size(1092, 346);
            this.dgvBuyOrders.TabIndex = 0;
            this.dgvBuyOrders.TabStop = false;
            // 
            // lstNotifications
            // 
            this.lstNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstNotifications.FormattingEnabled = true;
            this.lstNotifications.Items.AddRange(new object[] {
            "Notifications"});
            this.lstNotifications.Location = new System.Drawing.Point(12, 550);
            this.lstNotifications.Name = "lstNotifications";
            this.lstNotifications.Size = new System.Drawing.Size(1092, 82);
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
            this.lblForAvailableFunds.Location = new System.Drawing.Point(549, 72);
            this.lblForAvailableFunds.Name = "lblForAvailableFunds";
            this.lblForAvailableFunds.Size = new System.Drawing.Size(85, 13);
            this.lblForAvailableFunds.TabIndex = 21;
            this.lblForAvailableFunds.Text = "Available Funds:";
            // 
            // lblForAccountValue
            // 
            this.lblForAccountValue.AutoSize = true;
            this.lblForAccountValue.Location = new System.Drawing.Point(549, 46);
            this.lblForAccountValue.Name = "lblForAccountValue";
            this.lblForAccountValue.Size = new System.Drawing.Size(111, 13);
            this.lblForAccountValue.TabIndex = 23;
            this.lblForAccountValue.Text = "Net Liquidation Value:";
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
            this.txtNetLiquidation.Location = new System.Drawing.Point(666, 43);
            this.txtNetLiquidation.Name = "txtNetLiquidation";
            this.txtNetLiquidation.Size = new System.Drawing.Size(125, 20);
            this.txtNetLiquidation.TabIndex = 34;
            this.txtNetLiquidation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNetLiquidation.TextChanged += new System.EventHandler(this.txtNetLiquidation_TextChanged);
            // 
            // txtAvailableFunds
            // 
            this.txtAvailableFunds.Enabled = false;
            this.txtAvailableFunds.Location = new System.Drawing.Point(666, 69);
            this.txtAvailableFunds.Name = "txtAvailableFunds";
            this.txtAvailableFunds.Size = new System.Drawing.Size(125, 20);
            this.txtAvailableFunds.TabIndex = 35;
            this.txtAvailableFunds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAvailableFunds.TextChanged += new System.EventHandler(this.txtAvailableFunds_TextChanged);
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.radioButton2);
            this.grpOrder.Controls.Add(this.rdoUseRiskPercent);
            this.grpOrder.Controls.Add(this.btnPlaceOrder);
            this.grpOrder.Controls.Add(this.numDollarValue);
            this.grpOrder.Controls.Add(this.label6);
            this.grpOrder.Controls.Add(this.numRiskPercent);
            this.grpOrder.Controls.Add(this.label5);
            this.grpOrder.Controls.Add(this.numStop);
            this.grpOrder.Controls.Add(this.numStopBuyLimit);
            this.grpOrder.Controls.Add(this.txtTicker);
            this.grpOrder.Controls.Add(this.label3);
            this.grpOrder.Controls.Add(this.label2);
            this.grpOrder.Controls.Add(this.label1);
            this.grpOrder.Location = new System.Drawing.Point(12, 39);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(496, 153);
            this.grpOrder.TabIndex = 36;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Place Order";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(463, 76);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 42;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdoUseRiskPercent
            // 
            this.rdoUseRiskPercent.AutoSize = true;
            this.rdoUseRiskPercent.Checked = true;
            this.rdoUseRiskPercent.Location = new System.Drawing.Point(463, 52);
            this.rdoUseRiskPercent.Name = "rdoUseRiskPercent";
            this.rdoUseRiskPercent.Size = new System.Drawing.Size(14, 13);
            this.rdoUseRiskPercent.TabIndex = 40;
            this.rdoUseRiskPercent.TabStop = true;
            this.rdoUseRiskPercent.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Enabled = false;
            this.btnPlaceOrder.Location = new System.Drawing.Point(415, 121);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceOrder.TabIndex = 43;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // numDollarValue
            // 
            this.numDollarValue.DecimalPlaces = 2;
            this.numDollarValue.Location = new System.Drawing.Point(334, 72);
            this.numDollarValue.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numDollarValue.Name = "numDollarValue";
            this.numDollarValue.Size = new System.Drawing.Size(120, 20);
            this.numDollarValue.TabIndex = 41;
            this.numDollarValue.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "$ Value:";
            // 
            // numRiskPercent
            // 
            this.numRiskPercent.DecimalPlaces = 2;
            this.numRiskPercent.Location = new System.Drawing.Point(334, 48);
            this.numRiskPercent.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRiskPercent.Name = "numRiskPercent";
            this.numRiskPercent.Size = new System.Drawing.Size(120, 20);
            this.numRiskPercent.TabIndex = 39;
            this.numRiskPercent.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Risk Percent:";
            // 
            // numStop
            // 
            this.numStop.DecimalPlaces = 2;
            this.numStop.Location = new System.Drawing.Point(102, 48);
            this.numStop.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numStop.Name = "numStop";
            this.numStop.Size = new System.Drawing.Size(120, 20);
            this.numStop.TabIndex = 35;
            this.numStop.ThousandsSeparator = true;
            // 
            // numStopBuyLimit
            // 
            this.numStopBuyLimit.DecimalPlaces = 2;
            this.numStopBuyLimit.Location = new System.Drawing.Point(102, 71);
            this.numStopBuyLimit.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numStopBuyLimit.Name = "numStopBuyLimit";
            this.numStopBuyLimit.Size = new System.Drawing.Size(120, 20);
            this.numStopBuyLimit.TabIndex = 37;
            this.numStopBuyLimit.ThousandsSeparator = true;
            // 
            // txtTicker
            // 
            this.txtTicker.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTicker.Location = new System.Drawing.Point(102, 20);
            this.txtTicker.Name = "txtTicker";
            this.txtTicker.Size = new System.Drawing.Size(120, 20);
            this.txtTicker.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Stop:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Stop Buy Limit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ticker:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 644);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.txtAvailableFunds);
            this.Controls.Add(this.txtNetLiquidation);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblForAccountValue);
            this.Controls.Add(this.lblForAvailableFunds);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.lstNotifications);
            this.Controls.Add(this.dgvBuyOrders);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyOrders)).EndInit();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDollarValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRiskPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStopBuyLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.DataGridView dgvBuyOrders;
        private System.Windows.Forms.ListBox lstNotifications;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label lblForAvailableFunds;
        private System.Windows.Forms.Label lblForAccountValue;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtNetLiquidation;
        private System.Windows.Forms.TextBox txtAvailableFunds;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdoUseRiskPercent;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.NumericUpDown numDollarValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numRiskPercent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numStop;
        private System.Windows.Forms.NumericUpDown numStopBuyLimit;
        private System.Windows.Forms.TextBox txtTicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

