namespace lab8.Services.Interfaces
{
    public interface IReaderService
    {
        Task<IEnumerable<T>> ReadListAsync<T>(string fileName);
    }
}
