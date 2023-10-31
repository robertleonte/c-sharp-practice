namespace CSharpPractice
{
    public class StringManager
    {
        public int GetStringLength(string word)
        {
            return word.Length;
        }

        public int GetNumberOfLetterAppearances(string word, char letter)
        {
            // var nrOfAppearances = word.Split(letter).Length - 1;
            // return nrOfAppearances;

            var counter = 0;
            foreach (var character in word)
            {
                if (letter == character)
                {
                    counter++;
                }
            }
            return counter;
        }

        public int GetNumberOfVowels(string word)
        {
            // call GetNumberOfLetterAppearances for each vowel
            var counter = 0;
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
            foreach (var character in word)
            {
                if (vowels.Contains(character))
                {
                    counter++;
                }
            }
            return counter;
        }

        public int GetNumberOfWords(string phrase)
        {
            var counter = phrase.Split(' ').Length;
            return counter;
        }

        public string RemoveCharacter(string word, char character)
        {
            char emptySpace = '\0';
            var newWord = word.Replace(character, emptySpace);
            return newWord;
        }

        public bool CheckStringsEquality(string firstWord, string secondWord)
        {
            return firstWord.Equals(secondWord);
        }

        public string GetStringBackwards(string word)
        {
            var backwordList = word.Reverse();
            var backword = "";
            foreach (var character in backwordList)
            {
                backword += character;
            }
            return backword;
        }

        public bool IsStringPalindrome(string word)
        {
            if (word.CompareTo(GetStringBackwards(word)) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
