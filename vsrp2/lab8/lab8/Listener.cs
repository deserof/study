using lab8.Models.Entities;

namespace lab8
{
    public class Listener
    {
        private const string Path = "..\\..\\..\\History.json";

        private readonly WriterService _writerService;

        private readonly ReaderService _readerService;

        public Listener()
        {
            _writerService = new WriterService();
            _readerService = new ReaderService();
        }

        public void l_OnAdd(Medicine medicine)
        {
            WriteHistory("Add", medicine.ToString());
        }

        public void l_OnSell(Medicine medicine)
        {
            WriteHistory("Sell", medicine.ToString());
        }

        public void l_OnChange(Medicine medicine)
        {
            WriteHistory("Change", medicine.ToString());
        }

        public void l_OnDelete(Medicine medicine)
        {
            WriteHistory("Delete", medicine.ToString());
        }

        private void WriteHistory(string operation, string info)
        {
            Hist hist = new()
            {
                Operation = operation,
                Info = info
            };

            var hists = _readerService.Read<List<Hist>>(Path);
            hists.Add(hist);
            _writerService.Write<List<Hist>>(hists, Path);
        }
    }
}
