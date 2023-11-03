namespace CSharpPractice
{
    public class AnotherStringManager : IStringManager
    {
        public int GetStringLength(string word)
        {
            int counter = 0;
            foreach (char c in word)
            {
                counter++;
            }
            return counter;
        }

        public int GetNumberOfLetterAppearances(string word, char letter)
        {
            var nrOfAppearances = word.Split(letter).Length - 1;
            return nrOfAppearances;
        }

        public int GetNumberOfVowels(string word)
        {
            var counter = 0;
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
            foreach (var vowel in vowels)
            {
                counter += GetNumberOfLetterAppearances(word, vowel);
            }
            return counter;
        }

        public int GetNumberOfWords(string phrase)
        {
            phrase = phrase.Trim();
            var counter = 0;
            if (phrase.Length > 0)
            {
                counter = 1;
                foreach (char c in phrase)
                {
                    if (c == ' ')
                    {
                        counter++;
                    }

                }
            }

            return counter;
        }

        public string RemoveCharacter(string word, char character)
        {
            foreach (char c in word)
            {
                if (c == character)
                {
                    int pos = word.IndexOf(c);
                    if (pos >= 0)
                    {
                        word = word.Remove(pos, 1);
                    }
                }
            }
            return word;
        }

        public bool CheckStringsEquality(string firstWord, string secondWord)
        {
            if (firstWord.Length != secondWord.Length)
            {
                return false;
            }

            return String.Compare(firstWord, secondWord) == 0;
        }

        public string GetStringBackwards(string word)
        {
            var wordArray = word.ToCharArray();
            var backword = "";
            for (int i = wordArray.Length - 1; i >= 0; i--)
            {
                backword += wordArray[i];
            }
            return backword;
        }

        public bool IsStringPalindrome(string word)
        {
            var wordArray = word.ToCharArray();
            var wordReverseArray = word.Reverse().ToArray();

            for (int i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i] != wordReverseArray[i])
                    return false;
            }
            return true;

            //return wordArray == wordReverseArray;
        }

    }
}
