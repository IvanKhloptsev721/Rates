using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
namespace Rates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Resultlabel1_Click(object sender, EventArgs e)
        {

        }

        private void ResultButton1_Click(object sender, EventArgs e)
        {
            string from = comboBox1.Text;
            string to = comboBox2.Text;
            string amount = OUtTextBox1.Text;

            if (from == "" || to==""||amount=="")
            {
                MessageBox.Show("Заполните поля");
                return;
            }
            var client = new RestClient("https://api.apilayer.com");
            var request = new RestRequest($"currency_data/convert?from={from}&to={to}&amount={amount}", Method.Get);
            request.AddHeader("apikey", "lOmNJehjGlzCBAIkgabfM09sG9PpsPVH");

            var response = client.Execute(request);
            if (!response.IsSuccessful)
            {
                MessageBox.Show("Ошибка при запросе" + response.StatusCode);
                return;
            }
            dynamic responseAnswer = JsonConvert.DeserializeObject<dynamic>(response.Content);
            if (responseAnswer.result != null)
            {
                double result = responseAnswer.result;
                Resultlabel1.Text = result.ToString("N2");
            }
            else
            {
                MessageBox.Show("API вернул пустой результат. Проверьте параметры.");
                Resultlabel1.Text = "Ошибка";
            }

        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndex(object sender, EventArgs e)
        { 
        
        }
        private void comboBox2_SelectedIndex(object sender, EventArgs e)
        { 
        
        }
        private void OUtTextBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
