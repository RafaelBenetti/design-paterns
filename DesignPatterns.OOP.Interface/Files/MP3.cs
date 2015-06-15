using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OOP.Interface.Files
{
    //Concrete Class
    public class MP3 : File
    {
        //Polimorfism
        public override void Open()
        {
            base.Open();
            Console.WriteLine(string.Format("Listening file {0}", Name));
        }
    }
}
