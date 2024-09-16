// Spelet  - gissa ett slumptal
Console.Clear();
Console.WriteLine("Spelet - gissa ett slumptal 1-100");

// Antal gissningar

int antal = 0;

// Ange intervaller

Console.Write("Ange min värde: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Ange max värde: ");
int max = int.Parse(Console.ReadLine());



// slumpar ett tal 1-100
int slumptal = Random.Shared.Next(min, max);

// upprepning - loop
while (true)
{

    // ställ fråga till användaren
    Console.Write($"Gissa ett tal ({min} - {max}): ");
    int gissning = int.Parse(Console.ReadLine());

    // Räkna upp antal med 1
    antal++;


    // kontroll om gissning är rätt?
    if (gissning == slumptal)
    {
        Console.WriteLine($"Rätt gissat! ({antal} gissningar)");

        Console.Write("Vill du spela igen? (j/n) ");
        string spela = Console.ReadLine();
        if (spela == "n")
        {
            break;
        }
    }
    else if (gissning > slumptal)
    {
        Console.WriteLine("För högt!");
    }
    else
    {
        Console.WriteLine("För lågt!");
    }


}

//slut på spelet
Console.WriteLine("Tack för att du spelade!");