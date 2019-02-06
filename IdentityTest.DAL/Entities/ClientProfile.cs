using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace IdentityTest.DAL.Entities
{
    public class ClientProfile : IdentityUser
    {
        [Key]
        [ForeignKey("ApplicationUser")]
       

        public string Name { get; set; }
       

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
