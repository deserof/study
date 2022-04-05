namespace lab6.Services.Interfaces
{
    public interface ITextService
    {
        public string GetText();

        public void SaveText(string text);

        public bool TryGetStartAndLengthSubstringIndex(string searchText, out int startIndex, out int length);

        public string ReplaceText(string findText, string replaceText);

        public string RemoveText(string removeText);
    }
}
