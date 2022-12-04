namespace lab8.Services.Interfaces
{
    public interface IReaderService
    {
        T Read<T>(string fileName);
    }
}
