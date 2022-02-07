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
            this.components = new System.ComponentModel.Container();
            this.btnGetPrices = new System.Windows.Forms.Button();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblCurrencyTag = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceTag = new System.Windows.Forms.Label();
            this.pictureBoxCurrencyPic = new System.Windows.Forms.PictureBox();
            this.lblApiKey = new System.Windows.Forms.Label();
            this.txtBoxApiKey = new System.Windows.Forms.TextBox();
            this.currenciesTickerBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrencyPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesTickerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetPrices
            // 
            this.btnGetPrices.Location = new System.Drawing.Point(265, 6);
            this.btnGetPrices.Name = "btnGetPrices";
            this.btnGetPrices.Size = new System.Drawing.Size(120, 23);
            this.btnGetPrices.TabIndex = 1;
            this.btnGetPrices.Text = "Get Prices";
            this.btnGetPrices.UseVisualStyleBackColor = true;
            this.btnGetPrices.Click += new System.EventHandler(this.btnGetPrices_Click);
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
            this.lblPrice.Location = new System.Drawing.Point(188, 144);
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
            this.lblPriceTag.Location = new System.Drawing.Point(241, 144);
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
            this.txtBoxApiKey.Size = new System.Drawing.Size(194, 23);
            this.txtBoxApiKey.TabIndex = 12;
            this.txtBoxApiKey.Text = "Your Api Key";
            // 
            // currenciesTickerBindingSource
            // 
            this.currenciesTickerBindingSource.DataSource = typeof(CryptoPricesReader.Data.Models.Responses.CurrenciesTicker);
            // 
            // listBoxCurrencies
            // 
            this.listBoxCurrencies.FormattingEnabled = true;
            this.listBoxCurrencies.ItemHeight = 15;
            this.listBoxCurrencies.Location = new System.Drawing.Point(12, 35);
            this.listBoxCurrencies.Name = "listBoxCurrencies";
            this.listBoxCurrencies.Size = new System.Drawing.Size(123, 409);
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
            this.lblMaxSupply.Location = new System.Drawing.Point(141, 165);
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
            this.lblMaxSupplyTag.Location = new System.Drawing.Point(241, 165);
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
            this.lblHigh.Location = new System.Drawing.Point(188, 186);
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
            this.lblHighTag.Location = new System.Drawing.Point(241, 186);
            this.lblHighTag.Name = "lblHighTag";
            this.lblHighTag.Size = new System.Drawing.Size(94, 21);
            this.lblHighTag.TabIndex = 23;
            this.lblHighTag.Text = "52.2115645";
            this.lblHighTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighTag.Visible = false;
            // 
            // CPRViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
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
            this.Controls.Add(this.btnGetPrices);
            this.Name = "CPRViewer";
            this.Text = "CPRViewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrencyPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesTickerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnGetPrices;
        private Label lblCurrency;
        private Label lblCurrencyTag;
        private Label lblPrice;
        private Label lblPriceTag;
        private Label lblApiKey;
        private TextBox txtBoxApiKey;
        private PictureBox pictureBoxCurrencyPic;
        private BindingSource currenciesTickerBindingSource;
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
    }
}