using lab6.Repositories.Interfaces;
using lab6.Services.Interfaces;
using System.Collections.Generic;

namespace lab6.Services.Implementations
{
    public class HistoryService : IHistoryService
    {
        private readonly ITextRepository _textRepository;

        public HistoryService(ITextRepository textRepository)
        {
            _textRepository = textRepository;
        }

        public string GetReplaceHistory()
        {
            List<string> replacedText = _textRepository.GetReplacedText();
            return string.Join('\n', replacedText);
        }

        public string GetRemoveHistory()
        {
            List<string> removedText = _textRepository.GetRemovedText();
            return string.Join('\n', removedText);
        }
    }
}
