using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using IdentityTest.DAL;
using IdentityTest.DAL.Entities;

namespace IdentityTest.BLL.Managers
{
   public class ApplicationUserManager : UserManager<ClientProfile>
    {
        public ApplicationUserManager(IUserStore<ClientProfile> store)
           : base(store)
        {
        }
        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options,
                                                IOwinContext context)
        {
            IdentityDbContext db = context.Get<IdentityDbContext>();
            ApplicationUserManager manager = new ApplicationUserManager(new UserStore<ClientProfile>(db));
            manager.EmailService = new EmailService();
            var dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider = new DataProtectorTokenProvider<ClientProfile>(dataProtectionProvider.Create("ASP.NET Identity"));
            }
            return manager;
        }
    }
}
