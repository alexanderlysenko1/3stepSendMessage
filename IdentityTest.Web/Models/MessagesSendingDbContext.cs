using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SMSSending.Models;

namespace SMSSending
{
    public class MessagesSendingDbContext: DbContext
    {
        public MessagesSendingDbContext() : base("MessagesSendingDB") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MessageResepient> MessageResepients { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<AdInfo> AdInfos { get; set; }
    }
}
