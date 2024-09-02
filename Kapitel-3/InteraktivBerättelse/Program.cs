// interaktiv berättelse.
Console.Clear();

Console.WriteLine($"""

Du befinner dig vid kanten av en gammal, mystisk skog som enligt legenden döljer en hemlighet. 
Du har hört att om du är modig nog att gå in, kan du hitta en skatt eller kanske något ännu mer fantastiskt. 
Du står vid två stigar som leder in i skogen.

""");
Console.Write("Går du till höger eller vänster? (h/v) ");
string answer = Console.ReadLine();
// Vänster stig
if (answer == "v")
{
    Console.WriteLine($"""
    
    Stigen leder dig genom en tät del av skogen. 
    Efter en stund ser du en gammal, övervuxen byggnad genom buskarna. 
    Det verkar som om det har varit ett tempel här en gång.
    
    """);
    Console.Write("Utforskar du templet eller fortsätter du? (u/f) ");
    answer = Console.ReadLine();
    // utforska tempel
    if (answer == "u")
    {
        Console.WriteLine($"""
        
        Inuti templet hittar du en gammal bok på ett altare. 
        Boken verkar magisk och börjar lysa svagt när du rör vid den. 
        Plötsligt öppnar sig en hemlig passage bakom altaret.
        
        """);
        Console.Write("Tar du boken och lämmnar (t), eller går du in i passagen (g)?");
        answer = Console.ReadLine();
        // Går in i passagen
        if (answer == "g")
        {
            Console.WriteLine($"""
            
            Passagen leder till en underjordisk kammare fylld med gyllene skatter och en mystisk figur som säger att du är den utvalde att bevara skatten. 
            Du blir belönad med en magisk amulett som ger dig speciella krafter.
            
            Slut: 

            Du lämnar skogen som en hjälte med nya krafter och en mystisk amulett. 
            Du vet att ditt liv aldrig kommer att vara detsamma igen.
            """);
        }
    }
    else
    {
        
    }
}
// Höger stig
