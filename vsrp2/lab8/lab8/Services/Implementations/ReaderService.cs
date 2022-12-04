﻿namespace lab8.Services.Implementations
{
    public class ReaderService : IReaderService
    {
        public async Task<IEnumerable<T>> ReadListAsync<T>(string fileName)
        {
            var json = await File.ReadAllTextAsync(fileName);

            return JsonConvert.DeserializeObject<IEnumerable<T>>(json);
        }
    }
}