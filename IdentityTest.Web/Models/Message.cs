using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SMSSending
{
   
    public class Message
    {
        [Key]
        [JsonProperty("MessageId")]
        public int MessageId { get; set; }
        [JsonProperty("UserId")]
        public int UserId { get; set; }
        [JsonProperty("TextOfMessage")]
        public string TextOfMessage { get; set; }

        [ForeignKey("UserId")]
        public User Sender { get; set; }
        public ICollection<MessageResepient> MessageResepients { get; set; }

        public Message()
        {
            MessageResepients = new List<MessageResepient>();
        }
    }
}
