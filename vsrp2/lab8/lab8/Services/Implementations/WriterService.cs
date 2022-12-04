namespace lab8.Services.Implementations
{
    public class WriterService : IWriterService
    {
        public void Write<T>(T item, string path)
        {
            var json = JsonConvert.SerializeObject(item, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects
            });

            File.WriteAllText(path, json);
        }
    }
}
