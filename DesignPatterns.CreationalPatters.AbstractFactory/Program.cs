using DesignPatterns.CreationalPatters.AbstractFactory.Factory;
using DesignPatterns.CreationalPatters.AbstractFactory.Reader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatters.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var readerPdf = ReaderFactory.GetReader(ReaderTypeEnum.Pdf);
            readerPdf.Open();
            Console.WriteLine(readerPdf.Read());
            readerPdf.Close();

            var readerTxt = ReaderFactory.GetReader(ReaderTypeEnum.Txt);
            readerTxt.Open();
            Console.WriteLine(readerTxt.Read());
            readerTxt.Close();

            Console.ReadKey();
        }
    }
}
