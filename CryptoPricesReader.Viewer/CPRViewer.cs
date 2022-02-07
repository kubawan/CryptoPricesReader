using CryptoPricesReader.Data.Enums;
using CryptoPricesReader.NomicsAPI;
using CryptoPricesReader.Utilities.Helpers;

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
            List<Currencies> list = new List<Currencies>();
            list.Add(Currencies.BTC);
            list.Add(Currencies.ETH);

            comboBoxCurrencies.DataSource = list;
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

                txtBoxRawData.Text = rawData;
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
    }
}