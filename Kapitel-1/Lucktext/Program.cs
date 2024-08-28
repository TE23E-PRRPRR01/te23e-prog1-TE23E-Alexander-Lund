// Lucktext
using System.Runtime.InteropServices;

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding =  System.Text.Encoding.Unicode;
Console.Write("Ange ditt namn: ");
string namn = Console.ReadLine();
Console.Write("Ange en interessant uppfinning: ");
string uppfinning = Console.ReadLine();
Console.Write("Ange en funktion till uppfinningen: ");
string funktion = Console.ReadLine();
Console.Write("Ange kaotisk händelse, t ex exploderade: ");
string händelse = Console.ReadLine();
Console.WriteLine($"En dag bestämde sig {namn} för att bygga en {uppfinning} som skulle kunna {funktion}. Men när {namn} satte igång uppfinningen så {händelse} den och fattade eld!");

// om namn glömt
if (namn == "")
{
    Console.WriteLine("glöm inte att skriva ditt namn!");
}

// om uppfinning glömt
if (uppfinning == "")
{
    Console.WriteLine("Glöm inte att skriva en uppfinning!");
}

//om funktion glömt
if (funktion == "")
{
    Console.WriteLine("Glöm inte att skriva en funktion!");
}

//om kaotisk händelse glömt
if (händelse == "")
{
    Console.WriteLine("Glöm inte att skriva en kaotisk händelse!");
}