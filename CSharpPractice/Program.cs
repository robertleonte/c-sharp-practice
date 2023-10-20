// See https://aka.ms/new-console-template for more information

using CSharpPractice;


var stringManager = new StringManager();

Console.WriteLine("GetStringLength: " + stringManager.GetStringLength("testword"));
Console.WriteLine("GetNumberOfLetterAppearances: " + stringManager.GetNumberOfLetterAppearances("testword", 't'));
Console.WriteLine("GetNumberOfVowels: " + stringManager.GetNumberOfVowels("Today is a good day"));
Console.WriteLine("GetNumberOfWords: " + stringManager.GetNumberOfWords("Today is a good day"));
Console.WriteLine("RemoveCharacter: " + stringManager.RemoveCharacter("abecedar", 'a'));
Console.WriteLine("CheckStringsEquality: " + stringManager.CheckStringsEquality("abecedar", "abecedar"));
Console.WriteLine("GetStringBackwards: " + stringManager.GetStringBackwards("abecedar"));
