using Design_Patterns.Creational.ObjectPool.Sample;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.ObjectPool
{
    //Advantages
    //  It offers a significant performance boost
    //  It manages the connections and provides a way to reuse and share them
    //  Object pool pattern is used when the rate of initializing an instance of the class is high

    //Disadvantages (When trying not to use Object pool):
    //  Pool generally work on a fixed-block-size principle, and if that fixed size greatly exceeds the number of concurrently alive instances, you're wasting memory.

    //If you can't reasonably bound the maximum number of instances, you're left with either not being able to use a pool, or use one that "grows" by allocating another fixed0size-block. This starts to undermine some of the initial advantages of using a pool.

    //If the cost a resetting a "released" slot in a pool (so it can be used by a future instance) is higher that the cost a initial construction, that's a mark against using a pool for such objects.

    //If you're using a pool for improved locality of reference you generally want to swap released objects with the last used slot so you have a clear separation in the pool between "alive" and "dead" slots. If the cost of that swap is high, or if some other aspect of the object semantics require the ordering within the pool to be preserved, pools might be a poor choice.

    //When to use Object Pool Design Pattern
    //  When we have a work to allocates or deallocates many objects
    //  Also, when we know that we have a limited number of objects that will be in memory at the same time.
    public class ObjectPoolDemo : PatternDemoBase
    {
        public override string PatternName => "Object Pool";

        protected override void RunImpl()
        {
            Stopwatch watch = new Stopwatch();
            //Used not object pool;
            watch.Start();

            using (var conn1 = new DBConnection("ConfiguredUsername", "ConfiguredPassword"))
            {
                conn1.ProcessData();
            }
            using (var conn2 = new DBConnection("ConfiguredUsername", "ConfiguredPassword"))
            {
                conn2.ProcessData();
            }
            using (var conn3 = new DBConnection("ConfiguredUsername", "ConfiguredPassword"))
            {
                conn3.ProcessData();
            }

            watch.Stop();
            Console.WriteLine("Used not object pool, operation costs {0}", watch.Elapsed);


            //Used object pool

            watch.Restart();

            var pool = new ObjectPool.Sample.ObjectPool();
            var con1 = pool.Rent();
            con1.ProcessData();
            pool.Return(con1);
            var con2 = pool.Rent();
            con2.ProcessData();
            pool.Return(con2);
            var con3 = pool.Rent();
            con3.ProcessData();

            watch.Stop();
            Console.WriteLine("Used object pool, operation costs {0}", watch.Elapsed);
        }
    }
}
