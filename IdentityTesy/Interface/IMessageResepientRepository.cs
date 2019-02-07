using IdentityTest.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityTest.Web.Interface
{
    public interface IMessageResepientRepository : IRepository<MessageResepient>
    {
        List<MessageResepient> GetRecepientsMessagesByMessageId(int messageId);
        List<MessageResepient> GetRecepientsMessagesByRecipientId(int messageId);
    }
}
