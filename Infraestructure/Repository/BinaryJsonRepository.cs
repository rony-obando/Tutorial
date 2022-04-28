using Domain.Entities;
using Domain.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class BinaryJsonRepository : IJsonModel
    {
        private RAFContext context;
        private const int SIZE = 10000;
        public BinaryJsonRepository()
        {
            context = new RAFContext("json", SIZE);
        }
        public void Add(JsonString t)
        {
            context.Create<JsonString>(t);
        }

        public void Delete(JsonString t)
        {
            context.Delete(t.Id);
        }

        public List<JsonString> Read()
        {
           return context.GetAll<JsonString>();
        }

        public int Update(JsonString t)
        {
            throw new NotImplementedException();
        }

        public List<WeatherInfo.Current> Convertir()
        {
            List<WeatherInfo.Current> weather=new List<WeatherInfo.Current>();
            foreach (JsonString json in Read())
            {
                WeatherInfo.Current Info= JsonConvert.DeserializeObject<WeatherInfo.Current>(json.json);
                weather.Add(Info);
            }
            return weather;
        }
    }
}
