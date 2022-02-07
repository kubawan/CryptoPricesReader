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
            this.comboBoxCurrencies = new System.Windows.Forms.ComboBox();
            this.btnGetPrices = new System.Windows.Forms.Button();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblCurrencyTag = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceTag = new System.Windows.Forms.Label();
            this.lblApiKey = new System.Windows.Forms.Label();
            this.txtBoxApiKey = new System.Windows.Forms.TextBox();
            this.txtBoxRawData = new System.Windows.Forms.TextBox();
            this.lblRawData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCurrencies
            // 
            this.comboBoxCurrencies.FormattingEnabled = true;
            this.comboBoxCurrencies.Location = new System.Drawing.Point(12, 35);
            this.comboBoxCurrencies.Name = "comboBoxCurrencies";
            this.comboBoxCurrencies.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCurrencies.TabIndex = 0;
            // 
            // btnGetPrices
            // 
            this.btnGetPrices.Location = new System.Drawing.Point(139, 35);
            this.btnGetPrices.Name = "btnGetPrices";
            this.btnGetPrices.Size = new System.Drawing.Size(92, 23);
            this.btnGetPrices.TabIndex = 1;
            this.btnGetPrices.Text = "Get Prices";
            this.btnGetPrices.UseVisualStyleBackColor = true;
            this.btnGetPrices.Click += new System.EventHandler(this.btnGetPrices_Click);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(12, 76);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(58, 15);
            this.lblCurrency.TabIndex = 2;
            this.lblCurrency.Text = "Currency:";
            // 
            // lblCurrencyTag
            // 
            this.lblCurrencyTag.AutoSize = true;
            this.lblCurrencyTag.Location = new System.Drawing.Point(76, 76);
            this.lblCurrencyTag.Name = "lblCurrencyTag";
            this.lblCurrencyTag.Size = new System.Drawing.Size(26, 15);
            this.lblCurrencyTag.TabIndex = 3;
            this.lblCurrencyTag.Text = "BTC";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(34, 91);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 15);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // lblPriceTag
            // 
            this.lblPriceTag.AutoSize = true;
            this.lblPriceTag.Location = new System.Drawing.Point(76, 91);
            this.lblPriceTag.Name = "lblPriceTag";
            this.lblPriceTag.Size = new System.Drawing.Size(40, 15);
            this.lblPriceTag.TabIndex = 5;
            this.lblPriceTag.Text = "0.0123";
            // 
            // lblApiKey
            // 
            this.lblApiKey.AutoSize = true;
            this.lblApiKey.Location = new System.Drawing.Point(12, 9);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(47, 15);
            this.lblApiKey.TabIndex = 6;
            this.lblApiKey.Text = "ApiKey:";
            // 
            // txtBoxApiKey
            // 
            this.txtBoxApiKey.Location = new System.Drawing.Point(65, 6);
            this.txtBoxApiKey.Name = "txtBoxApiKey";
            this.txtBoxApiKey.Size = new System.Drawing.Size(254, 23);
            this.txtBoxApiKey.TabIndex = 7;
            this.txtBoxApiKey.Text = "Your Api Key";
            // 
            // txtBoxRawData
            // 
            this.txtBoxRawData.Location = new System.Drawing.Point(397, 35);
            this.txtBoxRawData.Multiline = true;
            this.txtBoxRawData.Name = "txtBoxRawData";
            this.txtBoxRawData.Size = new System.Drawing.Size(391, 403);
            this.txtBoxRawData.TabIndex = 8;
            // 
            // lblRawData
            // 
            this.lblRawData.AutoSize = true;
            this.lblRawData.Location = new System.Drawing.Point(397, 9);
            this.lblRawData.Name = "lblRawData";
            this.lblRawData.Size = new System.Drawing.Size(53, 15);
            this.lblRawData.TabIndex = 9;
            this.lblRawData.Text = "RawData";
            // 
            // CPRViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRawData);
            this.Controls.Add(this.txtBoxRawData);
            this.Controls.Add(this.txtBoxApiKey);
            this.Controls.Add(this.lblApiKey);
            this.Controls.Add(this.lblPriceTag);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCurrencyTag);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.btnGetPrices);
            this.Controls.Add(this.comboBoxCurrencies);
            this.Name = "CPRViewer";
            this.Text = "CPRViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxCurrencies;
        private Button btnGetPrices;
        private Label lblCurrency;
        private Label lblCurrencyTag;
        private Label lblPrice;
        private Label lblPriceTag;
        private Label lblApiKey;
        private TextBox txtBoxApiKey;
        private TextBox txtBoxRawData;
        private Label lblRawData;
    }
}