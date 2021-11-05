using System;

namespace Design_Principles.Interface_Segregation_Principle.GoodSample
{
    public class Driver
    {
        private IVehicle vehicle;
        public Driver(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public void Drive()
        {
            vehicle.Run();
        }
    }
}
