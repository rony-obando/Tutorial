using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.interfaces;
using Domain.Entities;
using Newtonsoft.Json;

namespace Examen.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string apiKey = "2824a69890cc1539e8bf46e1d43167fc";
        void GetClimate()
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("http://api.openweathermap.org/data/2.5/onecall/timemachine?lat={0}&lon={1}&dt={2}&appid={3}",185,50,DateTime.Now,apiKey);
                    var json = web.DownloadString(url);
                   Info = JsonConvert.DeserializeObject<City.root>(json);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        City.root Info;
        private void Form1_Load(object sender, EventArgs e)
        {
            GetClimate();
            lblName.Text = Info.weather[0].description.ToString();
        }
    }
}
