using SMSSending.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSSending.Repositories
{
    public interface IMessageResepientRepository : IRepository<MessageResepient>
    {
        List<MessageResepient> GetRecepientsMessagesByMessageId(int messageId);
        List<MessageResepient> GetRecepientsMessagesByRecipientId(int messageId);
    }
}
