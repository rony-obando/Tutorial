using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Entities.City;

namespace Domain.Entities
{
    public class City
    {
        public class hourly
      {
        public double dt { get; set; }
            public double temp { get; set; }
            public double feels_like { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
            public double dew_point { get; set; }
            public double clouds { get; set; }
            public double wind_speed { get; set; }
            public double wind_deg { get; set; }
            public double wind_gust { get; set; }
        }
       public class weather
          {
           public int id { get; set; }
           public string main { get; set; }
           public string description { get; set; }
           public string icon { get; set; }
          }
        
       /* public double cod { get; set; }
        public double message { get; set; }
        public double cnt { get; set; }

        public class city
        {
            public int id { get; set; }
            public string name { get; set; }
            
        }
        public class coord
        {
            public double lat { get; set; }
            public double lon { get; set; }

        }*/
        public class root
        {
            public hourly hourly { get; set; }
            public List<weather> weather { get; set; }
            //public weather Weather { get; set; }
        }
    }
}
