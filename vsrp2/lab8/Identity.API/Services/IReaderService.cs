namespace Identity.API.Services
{
    public interface IReaderService
    {
        Task<IEnumerable<T>> ReadListAsync<T>(string fileName);
    }
}
