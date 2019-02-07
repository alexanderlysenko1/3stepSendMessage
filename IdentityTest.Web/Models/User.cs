using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.RegularExpressions;
using SMSSending.Repositories;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace SMSSending
{
    public class User
    {
        [Key]
        [JsonProperty("UserId")]
        public int UserId { get; set; }
        [JsonProperty("Login")]
        public string Login { get; set; }
        [JsonProperty("UserPhone")]
        public string UserPhone { get; set; }
        [JsonProperty("Password")]
        public string Password { get; set; }
        [JsonProperty("FullName")]
        public string FullName { get; set; }


        public ICollection<Message> Messages { get; set; }

        public User()
        {
            Messages = new List<Message>();
        }
    }
}
