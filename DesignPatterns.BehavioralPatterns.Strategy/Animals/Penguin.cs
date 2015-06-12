
namespace DesignPatterns.BehavioralPatterns.Strategy.Animals
{
    public class Penguin : Animal
    {
        public Penguin()
        {
            NumberOfLegs = 2;
        }

        public override int GetNumberOfLegs()
        {
            return NumberOfLegs;
        }
    }
}
