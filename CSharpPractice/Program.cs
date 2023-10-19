// See https://aka.ms/new-console-template for more information

using CSharpPractice;


var stringManager = new StringManager();

Console.WriteLine("GetStringLength: " + stringManager.GetStringLength("testword"));

Console.WriteLine("GetNumberOfLetterAppearances: " + stringManager.GetNumberOfLetterAppearances("testword", 't'));

