using System;
using System.Collections.Generic;
using System.Text;
using IdentityTest.DAL.Entities;

namespace IdentityTest.DAL.Interface
{
    public interface IClientManager : IDisposable
    {
        void Create(ClientProfile item);
    }
}
