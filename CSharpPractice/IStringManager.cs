namespace CSharpPractice
{
    public interface IStringManager
    {
        public int GetStringLength(string word);
        public int GetNumberOfLetterAppearances(string word, char letter);
        public int GetNumberOfVowels(string word);
        public int GetNumberOfWords(string phrase);
        public string RemoveCharacter(string word, char character);
        public bool CheckStringsEquality(string firstWord, string secondWord);
        public string GetStringBackwards(string word);
        public bool IsStringPalindrome(string word);
    }
}
