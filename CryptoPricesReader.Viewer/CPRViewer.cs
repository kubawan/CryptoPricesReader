using CryptoPricesReader.Data.Enums;
using CryptoPricesReader.Data.Models.Responses;
using CryptoPricesReader.NomicsAPI;
using CryptoPricesReader.Utilities.Helpers;

namespace CryptoPricesReader.Viewer.WinFroms
{
    public partial class CPRViewer : Form
    {
        ApiConnect Api = new ApiConnect();

        public CPRViewer ()
        {
            InitializeComponent();

            comboBoxRefreshInterval.DataSource = Enum.GetValues(typeof(RefreshIntervals));
        }

        private bool CheckApiKey(string apiKey)
        {
            if (txtBoxApiKey.Text == "Your Api Key" || txtBoxApiKey.Text == "")
            {
                MessageBox.Show("Wrong API KEY!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private async void btnGetPrices_Click (object sender, EventArgs e)
        {
            var currenciesTicker = await GetCurrenciesTickers(new string[] { "filter=any", "status=active" });

            listBoxCurrencies.Items.Clear();
            listBoxCurrencies.Items.AddRange(currenciesTicker.ToArray());
            listBoxCurrencies.DisplayMember = "Name";
        }

        private async Task<List<CurrenciesTicker>> GetCurrenciesTickers(string[] queryParmas)
        {
            if (CheckApiKey(txtBoxApiKey.Text))
            {
                var rawData = await Api.SendRequest(QueryType.CurrenciesTicker, queryParmas);
                return NomicsApiHelpers.ParseJson<List<CurrenciesTicker>>(rawData);
            }
            else
            {
                return null;
            }
        }

        private void ChangeLabelsVisibility()
        {
            lblCurrency.Visible = true;
            lblCurrencyTag.Visible = true;
            lblMaxSupply.Visible = true;
            lblMaxSupplyTag.Visible = true;
            lblPrice.Visible = true;
            lblPriceDate.Visible = true;
            lblPriceTag.Visible = true;
            lblStatus.Visible = true;
            lblStatusTag.Visible = true;
            lblRank.Visible = true;
            lblRankTag.Visible = true;
            lblHigh.Visible = true;
            lblHighTag.Visible = true;
            lblFullName.Visible = true;
            lblFullNameTag.Visible = true;
            groupBoxTickerAttributes.Visible = true;
            btnRefresh.Visible = true;
            comboBoxRefreshInterval.Visible = true;
            btnAutoRefresh.Visible = true;
        }

        private async void listBoxCurrencies_SelectedIndexChanged (object sender, EventArgs e)
        {
            ChangeLabelsVisibility();

            var selectedItem = listBoxCurrencies.SelectedItem as CurrenciesTicker;
            var currencyTicker = await GetCurrenciesTickers(new string[] { $"ids={selectedItem.Id}", "interval=1h" });

            if (selectedItem != null)
            {
                SetData(currencyTicker.FirstOrDefault());
            }
        }

        private async void SetData(CurrenciesTicker currencyTicker)
        {
            lblCurrencyTag.Text = currencyTicker.Currency;
            lblPriceTag.Text = currencyTicker.Price;
            lblStatusTag.Text = currencyTicker.Status;
            lblRankTag.Text = currencyTicker.Rank;
            lblHighTag.Text = currencyTicker.High;
            lblPriceDate.Text = currencyTicker.PriceDate.ToString();
            lblFullNameTag.Text = currencyTicker.Name;
            lblPriceChangePctTag.Text = currencyTicker.H1.PriceChangePct;
            lblMarketCapChangePctTag.Text = currencyTicker.H1.MarketCapChangePct;

            try
            {
                pictureBoxCurrencyPic.Image = await NomicsApiHelpers.GetImageAsync(currencyTicker.LogoUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click (object sender, EventArgs e)
        {
            listBoxCurrencies_SelectedIndexChanged(sender, e);
        }

        private void txtBoxApiKey_TextChanged (object sender, EventArgs e)
        {
            Api.SetApiKey(txtBoxApiKey.Text);
        }


        System.Windows.Forms.Timer Timer = new System.Windows.Forms.Timer();

        private void btnAutoRefresh_Click (object sender, EventArgs e)
        {
            var interval = (RefreshIntervals)comboBoxRefreshInterval.SelectedItem;
            Timer.Interval = (int)interval * 1000;

            if (Timer.Enabled)
            {
                Timer.Tick -= Timer_Tick;
                Timer.Stop();
            }
            else
            {
                Timer.Tick += Timer_Tick;
                Timer.Start();
            }

            SetAutorefreshBtnText();
        }

        private void Timer_Tick (object? sender, EventArgs e)
        {
            listBoxCurrencies_SelectedIndexChanged(sender, e);

            SetAutorefreshBtnText();
        }

        private void SetAutorefreshBtnText()
        {
            if (Timer.Enabled)
                btnAutoRefresh.Text = "Stop!";
            else
                btnAutoRefresh.Text = "Set Autorefresh";
        }
    }
}