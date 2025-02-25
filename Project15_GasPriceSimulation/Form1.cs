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

namespace Project15_GasPriceSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double gasoLinePrice = 7.5;
        double dieselPrice = 6.5;
        double LpgPrice = 4.5;
        double gasAmount = 0;
        double dieselAmount = 0;
        double lpgAmount = 0;
        double progresbar = 0;
        double totalPrice = 0;
        int count = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            gasAmount = Convert.ToDouble(txtGasoline.Text);
            dieselAmount = Convert.ToDouble(txtDiesel.Text);
            lpgAmount = Convert.ToDouble(txtLpg.Text);
            timer1.Start();
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = count.ToString();
            if (radiobenzin.Checked)

            {
                count++;
                if (count <= gasAmount)
                {
                    totalPrice += gasoLinePrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }
                progresGas.Value += 3;
                if (progresGas.Value == 99)
                {
                    timer1.Stop();
                }

            }
            else if (radiomotorin.Checked)
            {
                count++;
                if (count <= dieselAmount)
                {
                    totalPrice += dieselPrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }
                progresGas.Value += 3;
                if (progresGas.Value == 99)
                {
                    timer1.Stop();
                }
            }
            else if (radiolpg.Checked)
            {
                count++;
                if (count <= lpgAmount)
                {
                    totalPrice += LpgPrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }
                progresGas.Value += 3;
                if (progresGas.Value == 99)
                {
                    timer1.Stop();
                }
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://akaryakit-fiyatlari.p.rapidapi.com/fuel/istanbul"),
                Headers =
    {
        { "x-rapidapi-key", "74c798356emshdc56074822e04fap19ad87jsna76feb084a7f" },
        { "x-rapidapi-host", "akaryakit-fiyatlari.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var gasolineJsonValue = json["data"][16]["prices"][0]["benzin"];
                var dieselJsonValue = json["data"][16]["prices"][0]["motorin"];
                var lpgJsonValue = json["data"][16]["prices"][0]["lpg"];
                txtGasoline.Text = gasolineJsonValue.ToString() + " ₺";
                txtDiesel.Text = dieselJsonValue.ToString() + " ₺";
                txtLpg.Text = lpgJsonValue.ToString() + " ₺";
            }
        }
    }
}



