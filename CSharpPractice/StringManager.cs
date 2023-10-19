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
    }
}
