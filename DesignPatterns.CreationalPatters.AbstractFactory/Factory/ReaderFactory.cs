using DesignPatterns.CreationalPatters.AbstractFactory.Reader;
using System;

namespace DesignPatterns.CreationalPatters.AbstractFactory.Factory
{
    public class ReaderFactory
    {
        public static IReader GetReader(ReaderTypeEnum type)
        {
            switch (type)
            {
                case ReaderTypeEnum.Pdf:
                    return new ReaderPdf();
                case ReaderTypeEnum.Txt:
                    return new ReaderTxt();
                default:
                    throw new Exception("Invalid Reader Type");
            }
        }
    }
}
