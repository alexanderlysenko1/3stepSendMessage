using SMSSending.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSSending.Repositories
{
    public interface IRecepientRepository : IRepository<Phone>
    {
        Phone GetByPhoneNumber(string phoneNumber);
    }
}
