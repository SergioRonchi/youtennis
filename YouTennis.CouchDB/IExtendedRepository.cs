using LoveSeat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTennis.DAL
{
    public interface IExtendedRepository<T>:IRepository<T> where T : class, IBaseObject
    {
        IEnumerable<T> GetList(string view_name);
    }
}
