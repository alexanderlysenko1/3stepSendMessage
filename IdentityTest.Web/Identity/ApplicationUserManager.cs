using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNet.Identity;
using IdentityTest.DAL.EF;


namespace IdentityTest.DAL.Identity
{
    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser> store)
                : base(store)
        {
        }
    }
}
