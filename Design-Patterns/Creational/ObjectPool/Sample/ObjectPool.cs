using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.ObjectPool.Sample
{
    public class ObjectPool
    {
        ICollection<DBConnection> pool;
        public ObjectPool()
        {
            this.pool = new List<DBConnection>();
        }
        public void Return(DBConnection connection)
        {
            if (pool.Contains(connection) == false)
            {
                this.pool.Add(connection);
            }
        }
        public DBConnection Rent()
        {
            if (pool.Count > 0)
            {
                var item = pool.First();
                pool.Remove(item);
                return item;
            }
            else
            {
                return new DBConnection("ConfiguredUsername", "ConfiguredPassword");
            }
        }
    }
}
