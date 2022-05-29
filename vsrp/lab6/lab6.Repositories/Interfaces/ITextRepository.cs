using System.Collections.Generic;

namespace lab6.Repositories.Interfaces
{
    public interface ITextRepository
    {
        public string GetText();

        public List<string> GetReplacedText();

        public List<string> GetRemovedText();

        public void SetText(string text);

        public void SetLastReplacedText(string findText, string replaceText);

        public void SetLastRemovedText(string removeText);
    }
}
