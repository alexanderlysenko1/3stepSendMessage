using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSSending.Repositories
{
    public class RecepientMessageRepository : Repository<MessageResepient>, IMessageResepientRepository
    {
        public RecepientMessageRepository(MessagesSendingDbContext sendingDbContext) : base(sendingDbContext)
        { }

        public List<MessageResepient> GetRecepientsMessagesByMessageId(int messageId)
        {
            return _dbSet.Where(item => item.MessageId == messageId).ToList();
        }
        public List<MessageResepient> GetRecepientsMessagesByRecipientId(int recipientId)
        {
            return _dbSet.Where(item => item.MessageId == recipientId).ToList();
        }
    }
}
