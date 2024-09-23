// Text Editor för filer

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("""
TextEditor

""");

string val = "";

// Läs in text från filen
string text = File.ReadAllText("text.txt");

// Skriv text i filen
File.WriteAllText("text.txt", text);

// while loop
while (true)
{
    Console.Write("""
    
    Meny;
    1. Skriv till fil
    2. Läs från fil
    3. Avsluta
    Skriv in val här: 
    """);
    val = Console.ReadLine();
    
    if (val == "1")
    {
        Console.Write("Skriv text Här; ");   
        text = Console.ReadLine();
        Console.WriteLine("Din text har sparats i text.txt");
        

    }
    else if (val == "2")
    {
        if (File.Exists("text.txt"))
        {
            Console.Write($"""
            Text från fil text.txt; {text}
            
            """);
        }
        else
        {
            Console.WriteLine("Filen hittades inte, kan ej läsa text.");
        }
    }
    else if (val == "3")
    {
        Console.WriteLine("Avlsutar..");
        break;
    }
    else
    {
        Console.WriteLine("Ogiltig input, försök igen.");
    }
}