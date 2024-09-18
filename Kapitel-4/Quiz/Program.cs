// Quiz
Console.Clear();


// introduktion

Console.WriteLine($"""
                          /\
                         |  |
                         |  |
                        .'  '.
                        |    |
                        |    |
                        | /\ |
                      .' |__|'.
                      |  |  |  |
                     .'  |  |  '.
                /\   |   \__/   |   /\
               |  |  |   |  |   |  |  |
           /|  |  |,-\   |  |   /-,|  |  |\
           ||  |,-'   |  |  |  |   '-,|  ||
           ||-'       |  |  |  |       '-||
|\     _,-'           |  |  |  |           '-,_     /|
||  ,-'   _           |  |  |  |               '-,  ||
||-'    =(*)=         |  |  |  |                  '-||
||                    |  \  /  |                    ||
|\________....--------\   ||   /--------....________/|
                      /|  ||  |\
                     / |  ||  | \
                    /  |  \/  |  \
                   /   |      |   \   
                 //   .|      |.   \\
               .' |_./ |      | \._| '.
              /     _.-|||  |||-._     \
              \__.-'   \||/\||/   '-.__/ 
""");
Console.WriteLine("Välkommen till F/A-18 Hornet quizzet!");
Console.Write("Vad heter du? ");
string namn = Console.ReadLine();

// poäng

int poäng = 0;

// quiz

while (true)
{
    //fråga 1
    Console.Write($"""

    När kom första F/A-18 (dvs A/B varianterna) i aktiv tjänst?
    a) 1983
    b) 1977
    c) 1993

    Ditt svar (a, b, c): 
    """);
    string svar1 = Console.ReadLine();
    if (svar1 == "a")
    {
        Console.WriteLine("Rätt svar!");
        poäng++;
    }
    else
    {
        Console.WriteLine("Fel svar!");
        poäng--;
    }

    //Fråga 2

    Console.Write($"""

    Ungefär hur snabbt kan en F/A-18 flyga som snabbast?
    a) Mach 1.4
    b) Mach 2.0
    c) Mach 1.7

    Ditt svar (a, b, c): 
    """);
    string svar2 = Console.ReadLine();
    if (svar2 == "c")
    {
        Console.WriteLine("Rätt svar!");
        poäng++;
    }
    else
    {
        Console.WriteLine("Fel svar!");
        poäng--;
    }

    // Fråga 3

    Console.Write($"""

    Vilket land använder INTE F/A-18 i sin militär
    a) Finland
    b) Tyskland
    c) Spanien

    Ditt svar (a, b, c): 
    """);
    string svar3 = Console.ReadLine();
    if (svar3 == "b")
    {
        Console.WriteLine("Rätt svar!");
        poäng++;
    }
    else
    {
        Console.WriteLine("Fel svar!");
        poäng--;
    }

    // Fråga 4

    Console.Write($"""

    Ungefär hur mycket väger en F/A-18 som mest (max startvikt)?
    a) 23 ton
    b) 26 ton
    c) 19 ton

    Ditt svar (a, b, c): 
    """);
    string svar4 = Console.ReadLine();
    if (svar4 == "a")
    {
        Console.WriteLine("Rätt svar!");
        poäng++;
    }
    else
    {
        Console.WriteLine("Fel svar!");
        poäng--;
    }

    // Fråga 5

    Console.Write($"""

    Hur mycket kostar den senaste varianten av F/A-18 (dvs E/F Super hornet)?
    a) $57 miljoner
    b) $70 miljoner
    c) $66 Miljoner

    Ditt Svar (a, b, c): 
    """);
    string svar5 = Console.ReadLine();
    if (svar5 == "c")
    {
        Console.WriteLine("Rätt svar!");
        poäng++;
    }
    else
    {
        Console.WriteLine("Fel svar!");
        poäng--;
    }

    // Poäng

    if (poäng == 5)
    {
        Console.WriteLine($"Grymt Jobbat {namn}! ({poäng}/5 poäng)");
    }
    else if (poäng > 2)
    {
        Console.WriteLine($"Inte illa {namn}! ({poäng}/5 poäng)");
    }
    else
    {
        Console.WriteLine($"Ajdå {namn}, försök igen! ({poäng}/5 poäng)");
    }

    // Spela igen?

    Console.Write("Vill du spela igen? (j/n) ");
    string spela = Console.ReadLine();
    if (spela == "n")
    {   
        break;
    }
    
}

// slutmeddelande

Console.WriteLine("Tack för att du spelade!");