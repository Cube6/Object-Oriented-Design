using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.ObjectPool.Sample
{
    public class DBConnection : IDisposable
    {
        string username;
        string password;
        public DBConnection(string username, string password)
        {
            //Configuring connection...
            this.username = username;
            this.password = password;

            //...
            //...
            //Long processes.
            Thread.Sleep(1000);
        }

        public void Dispose()
        {
            //Do dispose
        }

        public void ProcessData()
        {
            //Do something
        }
    }
}
