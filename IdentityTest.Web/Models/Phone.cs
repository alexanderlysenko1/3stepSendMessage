using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace SMSSending
{
    public class Phone
    {
        
        [Key]
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber { get; set; }
        

        public ICollection<MessageResepient> MessageResepients { get; set; }

        public Phone()
        {
            MessageResepients= new List<MessageResepient>();
        }
    }
}
