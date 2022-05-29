using lab6.Repositories.Interfaces;
using lab6.Repositories.Storage;
using System.Collections.Generic;

namespace lab6.Repositories.Implementations
{
    public class TextRepository : ITextRepository
    {
        public string GetText() => TextStorage.Text;
        public List<string> GetReplacedText() => TextStorage.ReplacedText;

        public List<string> GetRemovedText() => TextStorage.RemovedText;

        public void SetText(string text) => TextStorage.Text = text;

        public void SetLastReplacedText(string findText, string replaceText)
        {
            TextStorage.ReplacedText.Add($"find - {findText}, replace - {replaceText}");
        }

        public void SetLastRemovedText(string removeText) => TextStorage.RemovedText.Add(removeText);
    }
}
