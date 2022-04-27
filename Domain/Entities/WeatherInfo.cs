using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class WeatherInfo
    {
    
    public class current {
     public double dt { get; set; }
     public double sunrise { get; set; }
     public double sunset { get; set; }
     public double temp { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
            public double clouds { get; set; }
            public double visibility { get; set; }
            public double wind_speed { get; set; }
            public double wind_deg { get; set; }
      
    }
        public class weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }
        /*public class weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }
        public class clouds
        {
            public double all { get; set; }
        }
        public class wind
        {
            public string speed { get; set; }
            public double deg { get; set; }
            public double gust { get; set; }
        }
        public class sys
        {
            public string pod { get; set; }
        }*/
        public class root
    {
        //public List<weather> weather { get; set; }
        public current current { get; set; }
        public weather weather { get; set; }

    }
}
}
