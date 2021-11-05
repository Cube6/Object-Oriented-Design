using System;

namespace Design_Principles.Interface_Segregation_Principle.BadSample
{
    public interface IVehicle
    {
        void Run();

        void Gas();

        void Charge();
    }
}
