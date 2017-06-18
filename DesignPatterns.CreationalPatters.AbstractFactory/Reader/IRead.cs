namespace DesignPatterns.CreationalPatters.AbstractFactory.Reader
{
    public interface IReader
    {
        string Read();
        void Open();
        void Close();
    }
}
