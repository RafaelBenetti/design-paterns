
namespace DesignPatterns.BehavioralPatterns.Strategy.Animals
{
    public class Spider : Animal
    {
        public Spider()
        {
            NumberOfLegs = 8;
        }

        public override int GetNumberOfLegs()
        {
            return NumberOfLegs;
        }
    }
}
