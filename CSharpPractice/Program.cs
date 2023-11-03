using CSharpPractice;

var stringManager = new StringManager();
var anotherStringManager = new AnotherStringManager();

Console.WriteLine("     1. stringManager");
Console.WriteLine("GetStringLength: " + stringManager.GetStringLength("testword"));
Console.WriteLine("GetNumberOfLetterAppearances: " + stringManager.GetNumberOfLetterAppearances("testword", 't'));
Console.WriteLine("GetNumberOfVowels: " + stringManager.GetNumberOfVowels("Today is a good day"));
Console.WriteLine("GetNumberOfWords: " + stringManager.GetNumberOfWords("Today is a good day"));
Console.WriteLine("RemoveCharacter: " + stringManager.RemoveCharacter("abecedar", 'a'));
Console.WriteLine("CheckStringsEquality: " + stringManager.CheckStringsEquality("abecedar", "abecedar"));
Console.WriteLine("GetStringBackwards: " + stringManager.GetStringBackwards("abecedar"));
Console.WriteLine("IsStringPalindrome: " + stringManager.IsStringPalindrome("ana"));

Console.WriteLine("\n");

Console.WriteLine("     2. anotherStringManager");
Console.WriteLine("GetStringLength: " + anotherStringManager.GetStringLength("testword"));
Console.WriteLine("GetNumberOfLetterAppearances: " + anotherStringManager.GetNumberOfLetterAppearances("testword", 't'));
Console.WriteLine("GetNumberOfVowels: " + anotherStringManager.GetNumberOfVowels("Today is a good day"));
Console.WriteLine("GetNumberOfWords: " + anotherStringManager.GetNumberOfWords("Today is a good day"));
Console.WriteLine("RemoveCharacter: " + anotherStringManager.RemoveCharacter("abecedar", 'a'));
Console.WriteLine("CheckStringsEquality: " + anotherStringManager.CheckStringsEquality("abecedar", "abecedar"));
Console.WriteLine("GetStringBackwards: " + anotherStringManager.GetStringBackwards("abecedar"));
Console.WriteLine("IsStringPalindrome: " + anotherStringManager.IsStringPalindrome("ana"));
