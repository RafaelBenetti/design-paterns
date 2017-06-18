using System;

namespace DesignPatterns.CreationalPatters.AbstractFactory.Reader
{
    public class ReaderPdf : IReader
    {
        public void Close()
        {
            Console.WriteLine("Closing PDF..");
        }

        public void Open()
        {
            Console.WriteLine("Opening PDF..");
        }

        public string Read()
        {
            return "Content read from PDF.";
        }
    }
}
