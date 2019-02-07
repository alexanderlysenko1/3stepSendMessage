using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using IdentityTest.DAL.Identity;

namespace IdentityTest.DAL.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationUserManager UserManager { get; }
        IClientManager ClientManager { get; }
        ApplicationRoleManager RoleManager { get; }
        Task SaveAsync();
    }
}
