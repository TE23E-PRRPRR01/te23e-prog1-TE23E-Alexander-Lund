// MenyProgram
Console.Clear();
Console.WriteLine("Litet program med meny");
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
// Variabel för svaren

string val = "";

// programloop

while (true)
{
    // Visar meny och läser användarens val
    Console.Write("""

    1. Omvandla en text till versaler

    2. Omvandla en text till gemener

    3. avsluta

    Välj ett av alternativen ovan: 
    """);
    val = Console.ReadLine();
    
    // hantera användarens val
    if (val == "1")
    {
        Console.Write("Skriv in en text; ");
        string text = Console.ReadLine().ToUpper();
        Console.WriteLine($"Texten i versaler blir; {text}");
    }
    else if (val == "2")
    {
        Console.Write("Skriv in en text; ");
        string text2 = Console.ReadLine().ToLower();
        Console.WriteLine($"Texten i gemener blir; {text2}");
    }
    else if (val == "3")
    {
        Console.WriteLine("Avslutar..");
        break;
    }
    else
    {
        Console.WriteLine("Ogiltig input, försök igen");
    }
}