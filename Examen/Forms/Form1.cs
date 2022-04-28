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
using AppCore.Interfaces;
using Domain.Entities;
using Newtonsoft.Json;

namespace Examen.Forms
{
    public partial class Form1 : Form
    {
        IJsonServices jsonServices;
        public Form1(IJsonServices jsonServices)
        {
            this.jsonServices = jsonServices;
            InitializeComponent();
        }
        string apiKey = "cce6c84d83b1a7c75e8a6331e023a33a";
        void GetClimate()
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    //DateTime date = new DateTime(2022, 04,22);
                    string url = string.Format("http://api.openweathermap.org/data/2.5/onecall/timemachine?lat={0}&lon={1}&dt={2}&appid={3}", label2.Tag, label1.Tag, 1650838482, "cce6c84d83b1a7c75e8a6331e023a33a");
                    string json = web.DownloadString(url);
                    JsonString json1 = new JsonString
                    {
                        json=json
                    };
                    jsonServices.Add(json1);
                    WeatherInfo.Current Info = JsonConvert.DeserializeObject<WeatherInfo.Current>(json);
                    dataGridView1.DataSource = GetHourlies();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void GetCity()
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtCity.Text, apiKey);
                    var json = web.DownloadString(url);
                    CityInfo.root Info = JsonConvert.DeserializeObject<CityInfo.root>(json);
                    label1.Tag = Info.coord.lon;
                    label2.Tag = Info.coord.lat;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public List<WeatherInfo.Hourly> GetHourlies()
        {
            List<WeatherInfo.Hourly> hourlies=new List<WeatherInfo.Hourly>();
            foreach (WeatherInfo.Current a in jsonServices.Convertir())
            {
                foreach(WeatherInfo.Hourly b in a.hourly)
                {
                    hourlies.Add(b);
                }
            }
            return hourlies;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetHourlies();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            GetCity();
            GetClimate();
        }
    }
}
