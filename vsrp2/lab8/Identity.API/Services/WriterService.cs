namespace Identity.API.Services
{
    public class WriterService : IWriterService
    {
        public void Write<T>(T item, string fileName)
        {
            var json = JsonConvert.SerializeObject(item, Formatting.Indented);

            File.WriteAllText(fileName, json);
        }
    }
}
