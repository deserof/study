namespace Identity.API.Services
{
    public interface IWriterService
    {
        void Write<T>(T item, string fileName);
    }
}
