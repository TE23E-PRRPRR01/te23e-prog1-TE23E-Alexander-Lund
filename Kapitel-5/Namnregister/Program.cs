Console.Clear();
List<string> namnlista = [];

//programloop
while (true)
{


//visa meny
Console.Write("""

1. Registrera namn
2. Skriva ut alla namn
3. avsluta

Ange ditt val: 
""");
string val = Console.ReadLine();

if (val == "1")
{
    Console.Write("Ange ett namn: ");
    string namn = Console.ReadLine();
    namnlista.Add(namn);
}

else if (val == "2")
{
    //skriv ut hela listan på en rad
    for (int i = 0; i < namnlista.Count; i++)
    {
        Console.Write($"{namnlista[i]}, ");
    }
    Console.WriteLine();
}

else if (val == "3")
{
    Console.WriteLine("Avslutar..");
    break;
}

}
