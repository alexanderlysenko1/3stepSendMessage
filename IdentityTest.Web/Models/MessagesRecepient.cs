using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SMSSending.Models;

namespace SMSSending
{
    public class MessageResepient
    {
        [Key]
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("RecepientId")]
        public int RecepientId { get; set; }
        [JsonProperty("MessageId")]
        public int MessageId { get; set; }
        [JsonProperty("DateTimeCreate")]
        public DateTime DateTimeCreate { get; set; }
        [JsonProperty("DateTimeStart")]
        public DateTime DateTimeStart { get; set; }
        [JsonProperty("DateTimeEnd")]
        public DateTime DateTimeEnd { get; set; }
        [JsonProperty("Period")]
        public int Period { get; set; }

      
        [ForeignKey("MessageId")]
        public Message messege { get; set; }
        [ForeignKey("Id")]
        public Phone phone { get; set; }
    }
}
