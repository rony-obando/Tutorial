using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class JsonServices : BaseServices<JsonString>, IJsonServices
    {
        IJsonModel jsonModel;
        public JsonServices(IJsonModel model):base(model)
        {
            this.jsonModel = model;
        }
        public List<WeatherInfo.Current> Convertir()
        {
            return jsonModel.Convertir();
        }
    }
    
}
