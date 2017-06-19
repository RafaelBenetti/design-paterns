using DesignPatterns.StructuralPatterns.Facade.Vehicle;

namespace DesignPatterns.StructuralPatterns.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new VehicleFacade();
            facade.CreateCompleteVehicle();
        }
    }
}
