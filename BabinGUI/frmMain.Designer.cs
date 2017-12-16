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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StopBuyLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RiskPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DollarValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lstNotifications = new System.Windows.Forms.ListBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lblForAvailableFunds = new System.Windows.Forms.Label();
            this.lblAvailableFunds = new System.Windows.Forms.Label();
            this.lblForAccountValue = new System.Windows.Forms.Label();
            this.lblAccountValue = new System.Windows.Forms.Label();
            this.lblForPositionSize = new System.Windows.Forms.Label();
            this.lblPositionSize = new System.Windows.Forms.Label();
            this.lblForNumberOfShares = new System.Windows.Forms.Label();
            this.lblNumberOfShares = new System.Windows.Forms.Label();
            this.lblForPositionsValue = new System.Windows.Forms.Label();
            this.lblPositionsValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboOffSets = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(168, 91);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 2;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(168, 68);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 1;
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(168, 136);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
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
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(168, 160);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown4.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Account,
            this.Ticker,
            this.Stop,
            this.StopBuyLimit,
            this.RiskPercent,
            this.DollarValue,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(683, 319);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // Account
            // 
            this.Account.HeaderText = "Account";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            // 
            // Ticker
            // 
            this.Ticker.HeaderText = "Ticker";
            this.Ticker.Name = "Ticker";
            this.Ticker.ReadOnly = true;
            // 
            // Stop
            // 
            this.Stop.HeaderText = "Stop";
            this.Stop.Name = "Stop";
            this.Stop.ReadOnly = true;
            // 
            // StopBuyLimit
            // 
            this.StopBuyLimit.HeaderText = "Stop Buy Limit";
            this.StopBuyLimit.Name = "StopBuyLimit";
            this.StopBuyLimit.ReadOnly = true;
            // 
            // RiskPercent
            // 
            this.RiskPercent.HeaderText = "Risk ";
            this.RiskPercent.Name = "RiskPercent";
            this.RiskPercent.ReadOnly = true;
            // 
            // DollarValue
            // 
            this.DollarValue.HeaderText = "$ Value";
            this.DollarValue.Name = "DollarValue";
            this.DollarValue.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 50;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(297, 140);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
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
            this.lblForAvailableFunds.Location = new System.Drawing.Point(397, 47);
            this.lblForAvailableFunds.Name = "lblForAvailableFunds";
            this.lblForAvailableFunds.Size = new System.Drawing.Size(85, 13);
            this.lblForAvailableFunds.TabIndex = 21;
            this.lblForAvailableFunds.Text = "Available Funds:";
            // 
            // lblAvailableFunds
            // 
            this.lblAvailableFunds.AutoSize = true;
            this.lblAvailableFunds.Location = new System.Drawing.Point(501, 47);
            this.lblAvailableFunds.Name = "lblAvailableFunds";
            this.lblAvailableFunds.Size = new System.Drawing.Size(82, 13);
            this.lblAvailableFunds.TabIndex = 22;
            this.lblAvailableFunds.Text = "Available Funds";
            // 
            // lblForAccountValue
            // 
            this.lblForAccountValue.AutoSize = true;
            this.lblForAccountValue.Location = new System.Drawing.Point(397, 91);
            this.lblForAccountValue.Name = "lblForAccountValue";
            this.lblForAccountValue.Size = new System.Drawing.Size(111, 13);
            this.lblForAccountValue.TabIndex = 23;
            this.lblForAccountValue.Text = "Net Liquidation Value:";
            // 
            // lblAccountValue
            // 
            this.lblAccountValue.AutoSize = true;
            this.lblAccountValue.Location = new System.Drawing.Point(501, 91);
            this.lblAccountValue.Name = "lblAccountValue";
            this.lblAccountValue.Size = new System.Drawing.Size(77, 13);
            this.lblAccountValue.TabIndex = 24;
            this.lblAccountValue.Text = "Account Value";
            // 
            // lblForPositionSize
            // 
            this.lblForPositionSize.AutoSize = true;
            this.lblForPositionSize.Location = new System.Drawing.Point(397, 120);
            this.lblForPositionSize.Name = "lblForPositionSize";
            this.lblForPositionSize.Size = new System.Drawing.Size(70, 13);
            this.lblForPositionSize.TabIndex = 25;
            this.lblForPositionSize.Text = "Position Size:";
            // 
            // lblPositionSize
            // 
            this.lblPositionSize.AutoSize = true;
            this.lblPositionSize.Location = new System.Drawing.Point(501, 120);
            this.lblPositionSize.Name = "lblPositionSize";
            this.lblPositionSize.Size = new System.Drawing.Size(67, 13);
            this.lblPositionSize.TabIndex = 26;
            this.lblPositionSize.Text = "Position Size";
            // 
            // lblForNumberOfShares
            // 
            this.lblForNumberOfShares.AutoSize = true;
            this.lblForNumberOfShares.Location = new System.Drawing.Point(397, 140);
            this.lblForNumberOfShares.Name = "lblForNumberOfShares";
            this.lblForNumberOfShares.Size = new System.Drawing.Size(95, 13);
            this.lblForNumberOfShares.TabIndex = 27;
            this.lblForNumberOfShares.Text = "Number of Shares:";
            // 
            // lblNumberOfShares
            // 
            this.lblNumberOfShares.AutoSize = true;
            this.lblNumberOfShares.Location = new System.Drawing.Point(501, 140);
            this.lblNumberOfShares.Name = "lblNumberOfShares";
            this.lblNumberOfShares.Size = new System.Drawing.Size(92, 13);
            this.lblNumberOfShares.TabIndex = 28;
            this.lblNumberOfShares.Text = "Number of Shares";
            // 
            // lblForPositionsValue
            // 
            this.lblForPositionsValue.AutoSize = true;
            this.lblForPositionsValue.Location = new System.Drawing.Point(397, 68);
            this.lblForPositionsValue.Name = "lblForPositionsValue";
            this.lblForPositionsValue.Size = new System.Drawing.Size(64, 13);
            this.lblForPositionsValue.TabIndex = 29;
            this.lblForPositionsValue.Text = "Cash Value:";
            // 
            // lblPositionsValue
            // 
            this.lblPositionsValue.AutoSize = true;
            this.lblPositionsValue.Location = new System.Drawing.Point(501, 68);
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
            // cboOffSets
            // 
            this.cboOffSets.FormattingEnabled = true;
            this.cboOffSets.Location = new System.Drawing.Point(504, 175);
            this.cboOffSets.Name = "cboOffSets";
            this.cboOffSets.Size = new System.Drawing.Size(40, 21);
            this.cboOffSets.TabIndex = 32;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 644);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cboOffSets);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPositionsValue);
            this.Controls.Add(this.lblForPositionsValue);
            this.Controls.Add(this.lblNumberOfShares);
            this.Controls.Add(this.lblForNumberOfShares);
            this.Controls.Add(this.lblPositionSize);
            this.Controls.Add(this.lblForPositionSize);
            this.Controls.Add(this.lblAccountValue);
            this.Controls.Add(this.lblForAccountValue);
            this.Controls.Add(this.lblAvailableFunds);
            this.Controls.Add(this.lblForAvailableFunds);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.lstNotifications);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.textBox2);
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
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stop;
        private System.Windows.Forms.DataGridViewTextBoxColumn StopBuyLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn RiskPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn DollarValue;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.ListBox lstNotifications;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label lblForAvailableFunds;
        private System.Windows.Forms.Label lblAvailableFunds;
        private System.Windows.Forms.Label lblForAccountValue;
        private System.Windows.Forms.Label lblAccountValue;
        private System.Windows.Forms.Label lblForPositionSize;
        private System.Windows.Forms.Label lblPositionSize;
        private System.Windows.Forms.Label lblForNumberOfShares;
        private System.Windows.Forms.Label lblNumberOfShares;
        private System.Windows.Forms.Label lblForPositionsValue;
        private System.Windows.Forms.Label lblPositionsValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboOffSets;
        private System.Windows.Forms.Button btnConnect;
    }
}

