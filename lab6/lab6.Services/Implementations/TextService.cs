using lab6.Repositories.Interfaces;
using lab6.Services.Interfaces;

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

        public string SetStandartCaseForText()
        {
            string text = GetText();
            string temp1, temp2;

            for (int i = 0; i < text.Length; i++)
            {
                temp1 = text.Substring(i, 1);

                if (i + 2 == text.Length)
                {
                    break;
                }

                if (temp1 == "." || temp1 == "!" || temp1 == "?")
                {
                    temp2 = (text.Substring(i + 2, 1).ToUpper());
                    text = text.Replace(text.Substring(i + 2, 1), temp2);
                }
            }

            return text;
        }
    }
}
