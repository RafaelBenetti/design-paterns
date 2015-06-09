using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObject.Animals
{
    public class CatManagement
    {
        public IAnimal FormatterCatToRun(IAnimal cat)
        {
            if (cat == null)
            {
                return new NullCat();
            }

            return cat;
        }
    }
}
