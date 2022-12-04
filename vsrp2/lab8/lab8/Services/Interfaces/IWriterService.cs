namespace lab8.Services.Interfaces
{
    public interface IWriterService
    {
        void Write<T>(T item, string path);
    }
}
