using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project13_WeatherApp
{
    public partial class Weather : Form
    {
        public Weather()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city/İstanbul/EN"),
                Headers =
            {
                { "x-rapidapi-key", "74c798356emshdc56074822e04fap19ad87jsna76feb084a7f" },
                { "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
            },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                string body = await response.Content.ReadAsStringAsync();
                /*
                 API’den dönen yanıt JSON formatında olduğu için ReadAsStringAsync() ile string olarak alıp, JSON'a parse ediyoruz. Eğer ReadAsStringAsync() kullanmazsak, JSON verisini doğrudan obje olarak işleyemeyiz. Bu yüzden dönüşüm yapmak zorundayız.*/
                var weather = JObject.Parse(body);
                lblFahrenheit.Text = weather["main"]["feels_like"].ToString();
                lblHumidity.Text = weather["main"]["humidity"].ToString() + " %";
                lblWindSpeed.Text = weather["wind"]["speed"].ToString();
                double celsius = (double.Parse(lblFahrenheit.Text)-32) / (1.8);
                lblTemperature.Text = celsius.ToString("0.00") ;



                var main = weather["weather"][0]["main"].ToString();

                string imagePath = "C:\\Users\\Berkay\\source\\repos\\C#20Proje\\Project13_WeatherApp\\images\\";
                string imageFile = "";

                switch (main)
                {
                    case "Clouds":
                        imageFile = "cloud.png";
                        break;

                    case "Clear":
                        imageFile = "cloudandsun.png";
                        break;

                    case "Rain":
                        imageFile = "rainy.png";
                        break;

                    case "Snow":
                        imageFile = "winter.png";
                        break;

                    case "Sun":
                        imageFile = "sunny.png";
                        break;

                    default:
                        imageFile = "cloudandsun.png"; // Default görsel
                        break;
                }

                string fullImagePath = Path.Combine(imagePath, imageFile);
                //Path.Combine(imagePath, imageFile) → imagePath ile imageFile'ı birleştirerek tam dosya yolunu oluşturur.
                pictureBox1.Image = Image.FromFile(fullImagePath);



            }
        }
       
    }
}
