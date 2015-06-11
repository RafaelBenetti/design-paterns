using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.Strategy.Animals
{
    public class AnimalsManagement
    {
        private List<Animal> _animals;

        public AnimalsManagement()
        {
            this._animals = new List<Animal>();
        }

        public List<Animal> GetAll()
        {
            PopulateAnimals();
            return this._animals;
        }

        private void PopulateAnimals()
        {
            var turtle = new Turtle();
            var elephant = new Spider();
            var tiger = new Penguin();           

            this._animals.Add(turtle);
            this._animals.Add(elephant);
            this._animals.Add(tiger);
        }
    }
}
