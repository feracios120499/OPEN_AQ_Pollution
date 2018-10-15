using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPEN_AQ_Pollution
{
    public class Pollution
    {
        [Key]
        public int Id { get; set; }
        [JsonProperty("parameter")]
        public string Parameter { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("lastUpdated")]
        public DateTime LastUpdate { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        public string City { get; set; }

        public string Location { get; set; }

        public string Country { get; set; }



    }
}
