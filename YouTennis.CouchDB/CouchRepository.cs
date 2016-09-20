using LoveSeat;
using LoveSeat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTennis.DAL
{
    public class CouchRepository<T> : IExtendedRepository<T> where T : class, IBaseObject
    {
        protected readonly CouchDatabase _db = null;
        private const string DB_NAME = "youtennis";
     
        public CouchRepository()
        {
            CouchClient client =  new CouchClient("admin", "lnzldn");
            var db = client.GetDatabase(DB_NAME);
            _db = db;
        }

        public CouchRepository(CouchDatabase db)
        {
            _db = db;
        }

        public virtual void Save(T item)
        {
            if (item.Id == "")
                item.Id = Guid.NewGuid().ToString();
            var doc = new Document<T>(item);
            _db.SaveDocument(doc);
        }

        public virtual T Find(Guid id)
        {
            return _db.GetDocument<T>(id.ToString());
        }

        public virtual T Find(string id)
        {
            return _db.GetDocument<T>(id);
        }

        /// <summary>
        /// Repository methods don't have the business validation.  Use the service methods to enforce.
        /// </summary>
        /// <param name="obj"></param>
        public virtual void Delete(T obj)
        {
            _db.DeleteDocument(obj.Id.ToString(), obj.Rev);
        }

        public IEnumerable<T> GetList(string view_name)
        {
            var results = _db.View<T>(view_name);

            return results.Items;
        }
    }
}
