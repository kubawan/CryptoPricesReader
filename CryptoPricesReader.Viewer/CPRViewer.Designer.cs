namespace CryptoPricesReader.Viewer
{
    partial class CPRViewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.btnGetCurrencies = new System.Windows.Forms.Button();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblCurrencyTag = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceTag = new System.Windows.Forms.Label();
            this.pictureBoxCurrencyPic = new System.Windows.Forms.PictureBox();
            this.lblApiKey = new System.Windows.Forms.Label();
            this.txtBoxApiKey = new System.Windows.Forms.TextBox();
            this.listBoxCurrencies = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusTag = new System.Windows.Forms.Label();
            this.lblPriceDate = new System.Windows.Forms.Label();
            this.lblMaxSupply = new System.Windows.Forms.Label();
            this.lblMaxSupplyTag = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblRankTag = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblHighTag = new System.Windows.Forms.Label();
            this.lblGetApiKeyLink = new System.Windows.Forms.LinkLabel();
            this.lblGetApiKey = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblFullNameTag = new System.Windows.Forms.Label();
            this.groupBoxTickerAttributes = new System.Windows.Forms.GroupBox();
            this.lblMarketCapChangePctTag = new System.Windows.Forms.Label();
            this.lblMarketCapChangePct = new System.Windows.Forms.Label();
            this.lblTimeIntervalTag = new System.Windows.Forms.Label();
            this.lblTimeInterval = new System.Windows.Forms.Label();
            this.lblPriceChangePctTag = new System.Windows.Forms.Label();
            this.lblPriceChangePct = new System.Windows.Forms.Label();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrencyPic)).BeginInit();
            this.groupBoxTickerAttributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetCurrencies
            // 
            this.btnGetCurrencies.Location = new System.Drawing.Point(12, 35);
            this.btnGetCurrencies.Name = "btnGetCurrencies";
            this.btnGetCurrencies.Size = new System.Drawing.Size(123, 33);
            this.btnGetCurrencies.TabIndex = 1;
            this.btnGetCurrencies.Text = "Get Currencies";
            this.btnGetCurrencies.UseVisualStyleBackColor = true;
            this.btnGetCurrencies.Click += new System.EventHandler(this.btnGetPrices_Click);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrency.Location = new System.Drawing.Point(211, 55);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(149, 40);
            this.lblCurrency.TabIndex = 2;
            this.lblCurrency.Text = "Currency:";
            this.lblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrency.Visible = false;
            // 
            // lblCurrencyTag
            // 
            this.lblCurrencyTag.AutoSize = true;
            this.lblCurrencyTag.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrencyTag.Location = new System.Drawing.Point(366, 55);
            this.lblCurrencyTag.Name = "lblCurrencyTag";
            this.lblCurrencyTag.Size = new System.Drawing.Size(69, 40);
            this.lblCurrencyTag.TabIndex = 3;
            this.lblCurrencyTag.Text = "BTC";
            this.lblCurrencyTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrencyTag.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(188, 165);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 21);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrice.Visible = false;
            // 
            // lblPriceTag
            // 
            this.lblPriceTag.AutoSize = true;
            this.lblPriceTag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPriceTag.Location = new System.Drawing.Point(241, 165);
            this.lblPriceTag.Name = "lblPriceTag";
            this.lblPriceTag.Size = new System.Drawing.Size(58, 21);
            this.lblPriceTag.TabIndex = 5;
            this.lblPriceTag.Text = "0.0123";
            this.lblPriceTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPriceTag.Visible = false;
            // 
            // pictureBoxCurrencyPic
            // 
            this.pictureBoxCurrencyPic.Location = new System.Drawing.Point(141, 38);
            this.pictureBoxCurrencyPic.Name = "pictureBoxCurrencyPic";
            this.pictureBoxCurrencyPic.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxCurrencyPic.TabIndex = 10;
            this.pictureBoxCurrencyPic.TabStop = false;
            // 
            // lblApiKey
            // 
            this.lblApiKey.AutoSize = true;
            this.lblApiKey.Location = new System.Drawing.Point(12, 9);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(47, 15);
            this.lblApiKey.TabIndex = 11;
            this.lblApiKey.Text = "ApiKey:";
            // 
            // txtBoxApiKey
            // 
            this.txtBoxApiKey.Location = new System.Drawing.Point(65, 6);
            this.txtBoxApiKey.Name = "txtBoxApiKey";
            this.txtBoxApiKey.Size = new System.Drawing.Size(170, 23);
            this.txtBoxApiKey.TabIndex = 12;
            this.txtBoxApiKey.Text = "Your Api Key";
            this.txtBoxApiKey.TextChanged += new System.EventHandler(this.txtBoxApiKey_TextChanged);
            // 
            // listBoxCurrencies
            // 
            this.listBoxCurrencies.FormattingEnabled = true;
            this.listBoxCurrencies.ItemHeight = 15;
            this.listBoxCurrencies.Location = new System.Drawing.Point(12, 74);
            this.listBoxCurrencies.Name = "listBoxCurrencies";
            this.listBoxCurrencies.Size = new System.Drawing.Size(123, 364);
            this.listBoxCurrencies.TabIndex = 13;
            this.listBoxCurrencies.SelectedIndexChanged += new System.EventHandler(this.listBoxCurrencies_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(286, 95);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 25);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Visible = false;
            // 
            // lblStatusTag
            // 
            this.lblStatusTag.AutoSize = true;
            this.lblStatusTag.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatusTag.Location = new System.Drawing.Point(371, 95);
            this.lblStatusTag.Name = "lblStatusTag";
            this.lblStatusTag.Size = new System.Drawing.Size(63, 25);
            this.lblStatusTag.TabIndex = 15;
            this.lblStatusTag.Text = "active";
            this.lblStatusTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatusTag.Visible = false;
            // 
            // lblPriceDate
            // 
            this.lblPriceDate.AutoSize = true;
            this.lblPriceDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPriceDate.Location = new System.Drawing.Point(211, 38);
            this.lblPriceDate.Name = "lblPriceDate";
            this.lblPriceDate.Size = new System.Drawing.Size(63, 17);
            this.lblPriceDate.TabIndex = 16;
            this.lblPriceDate.Text = "PriceDate";
            this.lblPriceDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPriceDate.Visible = false;
            // 
            // lblMaxSupply
            // 
            this.lblMaxSupply.AutoSize = true;
            this.lblMaxSupply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaxSupply.Location = new System.Drawing.Point(141, 186);
            this.lblMaxSupply.Name = "lblMaxSupply";
            this.lblMaxSupply.Size = new System.Drawing.Size(94, 21);
            this.lblMaxSupply.TabIndex = 17;
            this.lblMaxSupply.Text = "Max Supply:";
            this.lblMaxSupply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMaxSupply.Visible = false;
            // 
            // lblMaxSupplyTag
            // 
            this.lblMaxSupplyTag.AutoSize = true;
            this.lblMaxSupplyTag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaxSupplyTag.Location = new System.Drawing.Point(240, 186);
            this.lblMaxSupplyTag.Name = "lblMaxSupplyTag";
            this.lblMaxSupplyTag.Size = new System.Drawing.Size(100, 21);
            this.lblMaxSupplyTag.TabIndex = 18;
            this.lblMaxSupplyTag.Text = "8181546541";
            this.lblMaxSupplyTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMaxSupplyTag.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(466, 405);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 33);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRank.Location = new System.Drawing.Point(141, 105);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(39, 17);
            this.lblRank.TabIndex = 20;
            this.lblRank.Text = "Rank:";
            this.lblRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRank.Visible = false;
            // 
            // lblRankTag
            // 
            this.lblRankTag.AutoSize = true;
            this.lblRankTag.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRankTag.Location = new System.Drawing.Point(176, 105);
            this.lblRankTag.Name = "lblRankTag";
            this.lblRankTag.Size = new System.Drawing.Size(29, 17);
            this.lblRankTag.TabIndex = 21;
            this.lblRankTag.Text = "123";
            this.lblRankTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRankTag.Visible = false;
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHigh.Location = new System.Drawing.Point(188, 207);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(46, 21);
            this.lblHigh.TabIndex = 22;
            this.lblHigh.Text = "High:";
            this.lblHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHigh.Visible = false;
            // 
            // lblHighTag
            // 
            this.lblHighTag.AutoSize = true;
            this.lblHighTag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHighTag.Location = new System.Drawing.Point(240, 207);
            this.lblHighTag.Name = "lblHighTag";
            this.lblHighTag.Size = new System.Drawing.Size(94, 21);
            this.lblHighTag.TabIndex = 23;
            this.lblHighTag.Text = "52.2115645";
            this.lblHighTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighTag.Visible = false;
            // 
            // lblGetApiKeyLink
            // 
            this.lblGetApiKeyLink.AutoSize = true;
            this.lblGetApiKeyLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblGetApiKeyLink.Location = new System.Drawing.Point(299, 9);
            this.lblGetApiKeyLink.Name = "lblGetApiKeyLink";
            this.lblGetApiKeyLink.Size = new System.Drawing.Size(260, 15);
            this.lblGetApiKeyLink.TabIndex = 24;
            this.lblGetApiKeyLink.TabStop = true;
            this.lblGetApiKeyLink.Text = "https://p.nomics.com/cryptocurrency-bitcoin-api";
            // 
            // lblGetApiKey
            // 
            this.lblGetApiKey.AutoSize = true;
            this.lblGetApiKey.Location = new System.Drawing.Point(236, 9);
            this.lblGetApiKey.Name = "lblGetApiKey";
            this.lblGetApiKey.Size = new System.Drawing.Size(63, 15);
            this.lblGetApiKey.TabIndex = 25;
            this.lblGetApiKey.Text = "Get Key at:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFullName.Location = new System.Drawing.Point(154, 144);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(81, 21);
            this.lblFullName.TabIndex = 26;
            this.lblFullName.Text = "Full name:";
            this.lblFullName.Visible = false;
            // 
            // lblFullNameTag
            // 
            this.lblFullNameTag.AutoSize = true;
            this.lblFullNameTag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFullNameTag.Location = new System.Drawing.Point(241, 144);
            this.lblFullNameTag.Name = "lblFullNameTag";
            this.lblFullNameTag.Size = new System.Drawing.Size(57, 21);
            this.lblFullNameTag.TabIndex = 27;
            this.lblFullNameTag.Text = "Bitcoin";
            this.lblFullNameTag.Visible = false;
            // 
            // groupBoxTickerAttributes
            // 
            this.groupBoxTickerAttributes.Controls.Add(this.lblMarketCapChangePctTag);
            this.groupBoxTickerAttributes.Controls.Add(this.lblMarketCapChangePct);
            this.groupBoxTickerAttributes.Controls.Add(this.lblTimeIntervalTag);
            this.groupBoxTickerAttributes.Controls.Add(this.lblTimeInterval);
            this.groupBoxTickerAttributes.Controls.Add(this.lblPriceChangePctTag);
            this.groupBoxTickerAttributes.Controls.Add(this.lblPriceChangePct);
            this.groupBoxTickerAttributes.Location = new System.Drawing.Point(141, 231);
            this.groupBoxTickerAttributes.Name = "groupBoxTickerAttributes";
            this.groupBoxTickerAttributes.Size = new System.Drawing.Size(319, 207);
            this.groupBoxTickerAttributes.TabIndex = 29;
            this.groupBoxTickerAttributes.TabStop = false;
            this.groupBoxTickerAttributes.Text = "Interval-specific ticker attributes:";
            this.groupBoxTickerAttributes.Visible = false;
            // 
            // lblMarketCapChangePctTag
            // 
            this.lblMarketCapChangePctTag.AutoSize = true;
            this.lblMarketCapChangePctTag.Location = new System.Drawing.Point(139, 59);
            this.lblMarketCapChangePctTag.Name = "lblMarketCapChangePctTag";
            this.lblMarketCapChangePctTag.Size = new System.Drawing.Size(35, 15);
            this.lblMarketCapChangePctTag.TabIndex = 5;
            this.lblMarketCapChangePctTag.Text = "100%";
            // 
            // lblMarketCapChangePct
            // 
            this.lblMarketCapChangePct.AutoSize = true;
            this.lblMarketCapChangePct.Location = new System.Drawing.Point(9, 59);
            this.lblMarketCapChangePct.Name = "lblMarketCapChangePct";
            this.lblMarketCapChangePct.Size = new System.Drawing.Size(124, 15);
            this.lblMarketCapChangePct.TabIndex = 4;
            this.lblMarketCapChangePct.Text = "% market cap change:";
            // 
            // lblTimeIntervalTag
            // 
            this.lblTimeIntervalTag.AutoSize = true;
            this.lblTimeIntervalTag.Location = new System.Drawing.Point(139, 29);
            this.lblTimeIntervalTag.Name = "lblTimeIntervalTag";
            this.lblTimeIntervalTag.Size = new System.Drawing.Size(22, 15);
            this.lblTimeIntervalTag.TabIndex = 3;
            this.lblTimeIntervalTag.Text = "1H";
            // 
            // lblTimeInterval
            // 
            this.lblTimeInterval.AutoSize = true;
            this.lblTimeInterval.Location = new System.Drawing.Point(55, 29);
            this.lblTimeInterval.Name = "lblTimeInterval";
            this.lblTimeInterval.Size = new System.Drawing.Size(78, 15);
            this.lblTimeInterval.TabIndex = 2;
            this.lblTimeInterval.Text = "Time Interval:";
            // 
            // lblPriceChangePctTag
            // 
            this.lblPriceChangePctTag.AutoSize = true;
            this.lblPriceChangePctTag.Location = new System.Drawing.Point(139, 44);
            this.lblPriceChangePctTag.Name = "lblPriceChangePctTag";
            this.lblPriceChangePctTag.Size = new System.Drawing.Size(35, 15);
            this.lblPriceChangePctTag.TabIndex = 1;
            this.lblPriceChangePctTag.Text = "100%";
            // 
            // lblPriceChangePct
            // 
            this.lblPriceChangePct.AutoSize = true;
            this.lblPriceChangePct.Location = new System.Drawing.Point(35, 44);
            this.lblPriceChangePct.Name = "lblPriceChangePct";
            this.lblPriceChangePct.Size = new System.Drawing.Size(98, 15);
            this.lblPriceChangePct.TabIndex = 0;
            this.lblPriceChangePct.Text = "% price changed:";
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Enabled = false;
            this.btnSaveToFile.Location = new System.Drawing.Point(466, 366);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(93, 33);
            this.btnSaveToFile.TabIndex = 30;
            this.btnSaveToFile.Text = "Save To File";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(466, 231);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 33);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // CPRViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.groupBoxTickerAttributes);
            this.Controls.Add(this.lblFullNameTag);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblGetApiKey);
            this.Controls.Add(this.lblGetApiKeyLink);
            this.Controls.Add(this.lblHighTag);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.lblRankTag);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMaxSupplyTag);
            this.Controls.Add(this.lblMaxSupply);
            this.Controls.Add(this.lblPriceDate);
            this.Controls.Add(this.lblStatusTag);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.listBoxCurrencies);
            this.Controls.Add(this.txtBoxApiKey);
            this.Controls.Add(this.lblApiKey);
            this.Controls.Add(this.pictureBoxCurrencyPic);
            this.Controls.Add(this.lblPriceTag);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCurrencyTag);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.btnGetCurrencies);
            this.Name = "CPRViewer";
            this.Text = "CPRViewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrencyPic)).EndInit();
            this.groupBoxTickerAttributes.ResumeLayout(false);
            this.groupBoxTickerAttributes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnGetCurrencies;
        private Label lblCurrency;
        private Label lblCurrencyTag;
        private Label lblPrice;
        private Label lblPriceTag;
        private Label lblApiKey;
        private TextBox txtBoxApiKey;
        private PictureBox pictureBoxCurrencyPic;
        private ListBox listBoxCurrencies;
        private Label lblStatus;
        private Label lblStatusTag;
        private Label lblPriceDate;
        private Label lblMaxSupply;
        private Label lblMaxSupplyTag;
        private Button btnExit;
        private Label lblRank;
        private Label lblRankTag;
        private Label lblHigh;
        private Label lblHighTag;
        private LinkLabel lblGetApiKeyLink;
        private Label lblGetApiKey;
        private Label lblFullName;
        private Label lblFullNameTag;
        private GroupBox groupBoxTickerAttributes;
        private Label lblTimeInterval;
        private Label lblPriceChangePctTag;
        private Label lblPriceChangePct;
        private Label lblMarketCapChangePctTag;
        private Label lblMarketCapChangePct;
        private Label lblTimeIntervalTag;
        private Button btnSaveToFile;
        private Button btnRefresh;
    }
}