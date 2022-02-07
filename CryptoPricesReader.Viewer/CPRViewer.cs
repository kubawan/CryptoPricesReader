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

            StartUp();
        }

        private void StartUp()
        {
            comboBoxCurrencies.DataSource = Enum.GetValues(typeof(Currencies));
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

                txtBoxRawData.Text = rawData;
                lblCurrencyTag.Text = currenciesTicker.FirstOrDefault().Currency;
                lblPriceTag.Text = currenciesTicker.FirstOrDefault().Price;
                pictureBoxCurrencyPic.Image = await NomicsApiHelpers.SVGConvertAsync(currenciesTicker.FirstOrDefault().LogoUrl);
            }
        }

        private async Task<string> SendRequest()
        {
            var api = new ApiConnect(txtBoxApiKey.Text);

            string[] queryParmas = new string[1];
            queryParmas[0] = $"ids={comboBoxCurrencies.SelectedItem}";

            var result = await api.SendRequest(QueryType.CurrenciesTicker, queryParmas);

            return result;
        }

        private void CPRViewer_Load (object sender, EventArgs e)
        {

        }
    }
}