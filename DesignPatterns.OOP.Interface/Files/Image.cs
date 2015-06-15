using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OOP.Interface.Files
{
    //Concrete Class
    public class Image : File, IEditable, IPrintable
    {
        public Image(string name)
        {
            this.Name = name;
        }

        //Polimorfism
        public override void Open()
        {
            base.Open();
            Console.WriteLine(string.Format("Viewing {0}...", Name));
        }

        public void Print()
        {
            Console.WriteLine("Printing {0}...", Name);
        }

        public void Edit()
        {
            Console.WriteLine("Editing {0}...", Name);
        }
    }
}
