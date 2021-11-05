using System;

namespace Design_Principles.Interface_Segregation_Principle.GoodSample
{
    class ElectricVehicle : IElectricVehicle,IVehicle
    {

        public void Run()
        {
            Charge();
            Console.WriteLine("Electric Vehicle Run");
        }

        public void Charge()
        {
            Console.WriteLine("Electric Vehicle Charge");
        }
    }
}
