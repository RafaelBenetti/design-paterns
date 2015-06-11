
namespace DesignPatterns.BehavioralPatterns.Strategy.Animals
{
    public class Turtle : Animal
    {
        public Turtle()
        {
            NumberOfLegs = 4;
        }

        public override int GetNumberOfLegs()
        {
            return NumberOfLegs;
        }
    }
}