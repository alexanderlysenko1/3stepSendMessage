using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using IdentityTest.DAL.Entities;

namespace IdentityTest.DAL.EF
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext()
       : base("IdentityDB", throwIfV1Schema: false)
        {
        }
        public DbSet<ClientProfile> ClientProfiles { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }
        public DbSet<AddInfo> AddInfos { get; set; }
        public DbSet<PhoneRec> PhoneRecs { get; set; }
        public DbSet<MessageRec> MessageRecs { get; set; }
    }
}
