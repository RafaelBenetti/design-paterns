using System;

namespace DesignPatterns.CreationalPatters.AbstractFactory.Reader
{
    public class ReaderTxt : IReader
    {
        public void Close()
        {
            Console.WriteLine("Closing txt..");
        }

        public void Open()
        {
            Console.WriteLine("Opening txt..");
        }

        public string Read()
        {
            return "Content read from txt.";
        }
    }
}
