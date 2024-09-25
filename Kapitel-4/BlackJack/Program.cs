// Blackjack, aka 21:an
Console.Clear();
Console.WriteLine("BlackJack");

// Kortens värde är 2-10 = 2-10
// Knekt, dam, kung = 10
// Ess = 1 eller 11

// Variabler
int summaspelare = 0;
int summadator = 0;
int kort = 0;

// Dela ut 2 kort till spelaren
kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
summaspelare += kort;
kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
summaspelare += kort;

// Dela ut 2 kort till datorn
kort = Random.Shared.Next(1, 11);
summadator += kort;
kort = Random.Shared.Next(1, 11);
summadator += kort;


// Flera gånger (loop)
while (true)
{
    // Skriv ut summorna
    Console.WriteLine($"""
    Du har {summaspelare} poäng
    datorn har {summadator} poäng
    """);

    // Fråga; stanna eller dra ett kort?
    Console.Write("Vill du dra ett till kort (j/n)?");
    string svar = Console.ReadLine().ToLower();
    if (svar == "n")
    {
        // @todo Datorn får fortfarande ta extra kort
        // vem har vunnit (den som har närmast 21 har vunnit
        while (true)
        {
            if (summadator < 18)
            {
                Console.WriteLine("Datorn drar ett extra kort..");
                kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
                summadator += kort;
                Console.WriteLine($"Datorn fick en {kort}:a");
            }
            else
            {
            break;
            }
        }
        if (summadator < 18)
        {
            Console.WriteLine("Datorn drar ett extra kort..");
            kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
            summadator += kort;
            Console.WriteLine($"Datorn fick en {kort}:a");
        }
        else
        {
            Console.WriteLine("Datorn stannar.");
        }
        if (summaspelare > summadator && summaspelare < 21)
        {
            Console.WriteLine("""
            
            Du har vunnit!
            """);
            Console.WriteLine($"""
            Du fick {summaspelare} poäng
            datorn fick {summadator} poäng
            """);
            break;
        }
        else
        {
            Console.WriteLine("""
            
            Datorn har vunnit!
            """);
            Console.WriteLine($"""
            Du fick {summaspelare} poäng
            datorn fick {summadator} poäng
            """);
            break;
        }
    }

    // Ta ett extra kort
    kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
    summaspelare += kort;
    // Skriv ut kortet
    Console.WriteLine($"Du fick en {kort}:a");

    // Datorn får också ett nytt kort
    kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
    summadator += kort;
    // Skriv ut kortet
    Console.WriteLine($"Datorn fick en {kort}:a");
    // Om datorn får 21 och vinner
    if (summadator == 21)
    {
        Console.WriteLine("""
        
        Datorn har vunnit! (21 poäng)
        """);
        Console.WriteLine($"""
        Du fick {summaspelare} poäng
        datorn fick {summadator} poäng
        """);
        break;
    }
    // Om spelaren får 21 och vinner
    else if (summaspelare == 21)
    {
        Console.WriteLine("""
        
        Du har vunnit! (21 poäng)
        """);
        Console.WriteLine($"""
        Du fick {summaspelare} poäng
        datorn fick {summadator} poäng
        """);
        break;
    }

    // är spelaren tjock?
    if (summaspelare > 21)
    {
        Console.WriteLine("""
        
        Du har förorat! (för tjock)
        """);
        Console.WriteLine($"""
        Du fick {summaspelare} poäng
        datorn fick {summadator} poäng
        """);
        break;
    }
    // Är datorn tjock?
    if (summadator > 21)
    {
        Console.WriteLine("""
        
        Du vann! (dator för tjock)
        """);
        Console.WriteLine($"""
        Du fick {summaspelare} poäng
        datorn fick {summadator} poäng
        """);
        break;
    }
}