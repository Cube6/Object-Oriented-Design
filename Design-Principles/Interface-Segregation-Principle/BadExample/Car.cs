using System;

namespace Design_Principles.Interface_Segregation_Principle.BadSample
{
    public class Car : IVehicle
    {
		public void Charge()
		{
			Console.WriteLine("Charge the car...");
		}

		public void Gas()
		{
			Console.WriteLine("Fill the gas...");
		}

		public void Run()
        {
            Console.WriteLine("Car Running...");
        }
    }
}
