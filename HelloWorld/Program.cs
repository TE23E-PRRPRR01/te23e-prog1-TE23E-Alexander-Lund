using System.Runtime.CompilerServices;

Console.Clear();

Console.WriteLine("Hej världen!");
Console.WriteLine("detta är mitt första C# program");
Console.WriteLine("vad heter du? ");
string namn = Console.ReadLine();
Console.WriteLine("hej " + namn);
Console.WriteLine("vad gillar du att göra på fritiden?");
string aktivitet = Console.ReadLine();
Console.WriteLine("kul! Jag gillar också att " + aktivitet);

Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("Såg du på OS i sommar?");