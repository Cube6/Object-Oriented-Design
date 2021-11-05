using Design_Patterns.Creational.AbstractFactory.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.AbstractFactory
{
	public class AbstractFactoryDemo
	{
        private Glass glass;
        private Wheel wheel;
        public AbstractFactoryDemo(CarFactory factory)
        {
            glass = factory.CreateGlass();
            wheel = factory.CreateWheel();
        }
        public void Run()
        {
            Console.WriteLine(glass.GetType().Name +
              " interacts with " + wheel.GetType().Name);
        }
    }
}
