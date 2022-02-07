using CryptoPricesReader.Data.Enums;
using CryptoPricesReader.Data.Models.Responses;
using CryptoPricesReader.NomicsAPI;
using CryptoPricesReader.Utilities.Helpers;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CryptoPricesReader.Viewer
{
    public partial class CPRViewer : Form
    {
        public CPRViewer ()
        {
            InitializeComponent();
        }

        private async void btnGetPrices_Click (object sender, EventArgs e)
        {
            if (txtBoxApiKey.Text == "Your Api Key" || txtBoxApiKey.Text == "")
            {
                MessageBox.Show("Wrong API KEY!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var rawData = await SendRequest();
                List<CurrenciesTicker> currenciesTicker = NomicsApiHelpers.ParseJson<List<CurrenciesTicker>>(rawData);

                listBoxCurrencies.DataSource = currenciesTicker;
                listBoxCurrencies.DisplayMember = "Name";
            }

            lblCurrency.Visible = true;
            lblCurrencyTag.Visible = true;
            lblMaxSupply.Visible = true;
            lblMaxSupplyTag.Visible = true;
            lblPrice.Visible = true;
            lblPriceDate.Visible = true;
            lblPriceTag.Visible = true;
            lblStatus.Visible = true;
            lblStatusTag.Visible = true;
        }

        private async Task<string> SendRequest()
        {
            var api = new ApiConnect(txtBoxApiKey.Text);

            string[] queryParmas = new string[2];
            queryParmas[0] = $"filter=any";
            queryParmas[1] = "status=active";

            var result = await api.SendRequest(QueryType.CurrenciesTicker, queryParmas);

            return result;
        }

        private async void listBoxCurrencies_SelectedIndexChanged (object sender, EventArgs e)
        {
            var selectedItem = listBoxCurrencies.SelectedItem as CurrenciesTicker;

            if (selectedItem != null)
            {
                lblCurrencyTag.Text = selectedItem.Currency;
                lblPriceTag.Text = selectedItem.Price;
                lblStatusTag.Text = selectedItem.Status;
                try
                {
                    pictureBoxCurrencyPic.Image = await NomicsApiHelpers.GetImageAsync(selectedItem.LogoUrl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click (object sender, EventArgs e)
        {
            this.Close();
        }
    }
}