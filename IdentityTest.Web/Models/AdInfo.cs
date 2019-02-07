using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SMSSending.Models
{
    public class AdInfo
    {
        [Key]
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("IdPhone")]
        public int IdPhone { get; set; }
        [JsonProperty("AddInfo")]
        public string AddInfo { get; set; }

        [ForeignKey("Id")]
        public Phone phone { get; set; }
    }
}