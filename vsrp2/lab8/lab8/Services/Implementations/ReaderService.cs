namespace lab8.Services.Implementations
{
    public class ReaderService : IReaderService
    {
        public T Read<T>(string fileName)
        {
            var json = File.ReadAllText(fileName);

            return JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects
            });
        }
    }
}
