using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSSending.Repositories
{
    public interface IGetSetInFile<TEntity>
    {
        void SetInFileJson(TEntity entity);
        //TEntity[] GetFromFileJson();
        void SetInFileXml(TEntity entity);
        //TEntity[] GetFromFileXml();
    }
}
