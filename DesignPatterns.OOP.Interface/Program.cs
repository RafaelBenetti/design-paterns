using DesignPatterns.OOP.Interface.Files;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OOP.Interface
{
    [ExcludeFromCodeCoverage]
    class Program
    {        
        static void Main(string[] args)
        {
            var image = new Image("penguin.png");
            image.Open();
            image.Edit();
            image.Print();

            Console.WriteLine();

            var mp3 = new MP3("muse.mp3");
            mp3.Open();

            Console.ReadKey();
        }
    }
}
