using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSSending.Repositories
{
    public class RecepientRepository : Repository<Phone>, IRecepientRepository
    {
        public RecepientRepository(MessagesSendingDbContext sendingDbContext) : base(sendingDbContext)
        { }

        public Phone GetByPhoneNumber(string phoneNumber)
        {
            return _dbSet.FirstOrDefault(item => item.PhoneNumber == phoneNumber);
        }
    }
}
