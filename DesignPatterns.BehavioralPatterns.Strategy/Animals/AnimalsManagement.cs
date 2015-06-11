using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.Strategy.Animals
{
    public class AnimalsManagement
    {
        private List<Animal> _animals;

        public AnimalsManagement()
        {
            this._animals = new List<Animal>();
            PopulateAnimals();
        }

        public List<Animal> GetAll()
        {            
            return this._animals;
        }

        private void PopulateAnimals()
        {
            AddToList(new Turtle());
            AddToList(new Penguin());
            AddToList(new Spider());
        }

        private void AddToList(Animal animal)
        {
            this._animals.Add(animal);        
        }
    }
}
