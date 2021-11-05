using System;
namespace Design_Principles.Interface_Segregation_Principle.GoodSample
{
    public class Truck : IVehicle ,IGasolineVehicle
    {
		public void Gas()
		{
			
		}

		public void Run()
        {
            Console.WriteLine("Truck Running...");
        }
    }
}

