using System;

namespace Design_Principles.Interface_Segregation_Principle.GoodSample
{
    public class Car :  IGasolineVehicle
    {
        public void Run()
        {
            Gas();
            Console.WriteLine("Car Running...");
        }

        public void Gas()
		{
            Console.WriteLine("Fill Gas...");
        }
    }
}
