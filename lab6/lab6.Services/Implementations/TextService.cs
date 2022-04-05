using lab6.Repositories.Interfaces;
using lab6.Services.Interfaces;
using System;

namespace lab6.Services.Implementations
{
    public class TextService : ITextService
    {
        private readonly ITextRepository _textRepository;

        public TextService(ITextRepository textRepository)
        {
            _textRepository = textRepository;
        }

        public string GetText() => _textRepository.GetText();

        public void SaveText(string text) => _textRepository.SetText(text.Trim());

        public bool TryGetStartAndLengthSubstringIndex(string searchText, out int startIndex, out int length)
        {
            string text = _textRepository.GetText();
            startIndex = text.IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase);
            length = searchText.Length;

            if (startIndex < 0 || startIndex > text.Length || length > text.Length)
            {
                return false;
            }

            return true;
        }

        public string ReplaceText(string findText, string replaceText)
        {
            _textRepository.SetLastReplacedText(findText, replaceText);
            string text = _textRepository.GetText();
            return text.Replace(findText, replaceText);
        }

        public string RemoveText(string removeText)
        {
            _textRepository.SetLastRemovedText(removeText);
            string text = _textRepository.GetText();
            return text.Replace(removeText, string.Empty);
        }
    }
}
