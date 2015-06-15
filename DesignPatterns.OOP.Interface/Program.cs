using DesignPatterns.OOP.Interface.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OOP.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var image = new Image();
            image.Open();
            image.Edit();
            image.Print();

            Console.WriteLine();

            var mp3 = new MP3();
            mp3.Open();

            Console.ReadKey();
        }
    }
}
