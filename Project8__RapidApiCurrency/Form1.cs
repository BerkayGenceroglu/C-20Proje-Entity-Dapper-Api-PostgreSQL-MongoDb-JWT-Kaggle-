using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Project8__RapidApiCurrency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            #region Dolar
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://exchange-rates7.p.rapidapi.com/convert?base=USD&target=TRY"),
                Headers =
    {
        { "x-rapidapi-key", "74c798356emshdc56074822e04fap19ad87jsna76feb084a7f" },
        { "x-rapidapi-host", "exchange-rates7.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                //HTTP yanıtları ham veri olarak gelir ve C# içinde ilk olarak bir metin (string) olarak okunmalıdır.
                //HTTP/1.1 200 OK
                //Content - Type: application / json
                //Content - Length: 123
                //{ "convert_result": { "rate": 30.25} }
                //JSON, XML, HTML gibi farklı formatlarda olabilir, ancak önce bir string olarak alınır.
                //Daha sonra gerektiğinde JSON gibi veri formatlarına dönüştürülür.
                var body = await response.Content.ReadAsStringAsync();
                //JSON olarak okumak için önce string'e çevirmek gerekecek.
                var json = JObject.Parse(body);
                var value = json["convert_result"]["rate"].ToString();
                lblDolarAlıs.Text = value;

            }
            #endregion
            #region EURO
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://exchange-rates7.p.rapidapi.com/convert?base=EUR&target=TRY"),
                Headers =
    {
        { "x-rapidapi-key", "74c798356emshdc56074822e04fap19ad87jsna76feb084a7f" },
        { "x-rapidapi-host", "exchange-rates7.p.rapidapi.com" },
    },
            };
            using (var response2 = await client.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                var json2 = JObject.Parse(body2);
                var value2 = json2["convert_result"]["rate"].ToString();
                lblEuroAlıs.Text = value2;

            }
            #endregion
            #region STERLİN
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://exchange-rates7.p.rapidapi.com/convert?base=GBP&target=TRY"),
                Headers =
    {
        { "x-rapidapi-key", "74c798356emshdc56074822e04fap19ad87jsna76feb084a7f" },
        { "x-rapidapi-host", "exchange-rates7.p.rapidapi.com" },
    },
            };
            using (var response3 = await client.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                var json3 = JObject.Parse(body3);
                var value3 = json3["convert_result"]["rate"].ToString();
                lblSterlinAlıs.Text = value3;

            }
            #endregion
        }

        private void btnİşlemiYap_Click(object sender, EventArgs e)
        {
            decimal dolar = decimal.Parse(lblDolarAlıs.Text);
            decimal euro = decimal.Parse(lblEuroAlıs.Text);
            decimal sterlin = decimal.Parse(lblSterlinAlıs.Text);
            decimal unitprice = decimal.Parse(txtBirimTutar.Text);
            if (radiodolar.Checked == true)
            {
                txtÖdenecekTutar.Text = (dolar * unitprice).ToString();
            }
            if (radioEuro.Checked == true)
            {
                txtÖdenecekTutar.Text = (euro * unitprice).ToString();
            }
            if (radioSterlin.Checked == true)
            {
                txtÖdenecekTutar.Text = (sterlin * unitprice).ToString();
            }
        }
    }
}
