using SMSSending.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSSending.Repositories
{
    public interface IMessageRepository : IRepository<Message>
    {
        List<Message> GetMessagesBySenderId(int senderId);
    }
}
