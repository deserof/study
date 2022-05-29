namespace lab6.Services.Interfaces
{
    public interface ITextService
    {
        public string GetText();

        public void SaveText(string text);

        public string ReplaceText(string findText, string replaceText);

        public string RemoveText(string removeText);

        public string SetStandartCaseForText();

        public string FindLiteral(string text);
    }
}
