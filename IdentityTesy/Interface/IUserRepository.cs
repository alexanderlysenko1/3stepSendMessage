using IdentityTest.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityTest.Web.Interface
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByPhoneNumber(string phoneNumber);
    }
}
