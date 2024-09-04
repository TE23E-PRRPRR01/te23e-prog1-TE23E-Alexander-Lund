// interaktiv berättelse.
Console.Clear();

Console.WriteLine($"""

Du befinner dig vid kanten av en gammal, mystisk skog som enligt legenden döljer en hemlighet. 
Du har hört att om du är modig nog att gå in, kan du hitta en skatt eller kanske något ännu mer fantastiskt. 
Du står vid två stigar som leder in i skogen.

""");
Console.Write("Går du till höger eller vänster? (h/v) ");
string answer = Console.ReadLine().ToLower();
// Vänster stig
if (answer == "v")
{
    Console.WriteLine($"""
    
    Stigen leder dig genom en tät del av skogen. 
    Efter en stund ser du en gammal, övervuxen byggnad genom buskarna. 
    Det verkar som om det har varit ett tempel här en gång.
    
    """);
    Console.Write("Utforskar du templet (u) eller fortsätter du (f)? ");
    answer = Console.ReadLine().ToLower();
    // utforska tempel
    if (answer == "u")
    {
        Console.WriteLine($"""
        
        Inuti templet hittar du en gammal bok på ett altare. 
        Boken verkar magisk och börjar lysa svagt när du rör vid den. 
        Plötsligt öppnar sig en hemlig passage bakom altaret.
        
        """);
        Console.Write("Tar du boken och lämmnar (t), eller går du in i passagen (g)? ");
        answer = Console.ReadLine().ToLower();
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
        // Tar boken och lämnar
        else
        {
            Console.WriteLine($"""
            
            När du lämnar templet börjar du läsa boken och upptäcker att den innehåller formler för att utföra magi. 
            Du blir en mäktig magiker och kan använda din nyvunna kunskap för att hjälpa andra eller kanske söka fler äventyr.

            Slut:

            Du lever ett liv fullt av magi och äventyr, där du använder din kunskap för att göra världen till en bättre plats.
            """);
        }
    }
    // Fortsätter längst stigen
    else
    {
        Console.WriteLine($"""
        
        Efter en lång promenad genom skogen kommer du till en vacker glänta med en källa som rinner klart vatten. 
        Det verkar som en fridfull plats och du beslutar dig för att vila här.

        Slut:

        Du finner ro och fred i gläntan och njuter av den enkla skönheten i naturen. 
        Livet blir enklare och mer harmoniskt, och du känner dig förnyad och glad.
        """);
    }
}
// Höger stig
else
{
    Console.WriteLine($"""
    
    Stigen leder dig genom en mer öppen del av skogen där du snart hittar en gammal övergiven stuga. 
    Stugan verkar ha stått där i många år och är täckt med mossa.
    
    """);
    Console.Write("Går du in i stugan (i) eller går du runt stugan och utforskar området (r)? ");
    answer = Console.ReadLine().ToLower();
    //går in i stugan
    if (answer == "i")
    {
        Console.WriteLine($"""
        
        Inuti stugan hittar du en gammal, dammig karta som visar en plats som är markerad med ett X. 
        Det verkar som om det kan vara en skattkarta.
        
        """);
        Console.Write("Följer du kartan direk för att hitta skatten (f) eller tar du kartan och lämnar stugan (l)? ");
        answer = Console.ReadLine().ToLower();

        //följer kartan direkt
        if (answer == "f")
        {
            Console.WriteLine($"""
            Kartan leder dig till en gömd grotta där du hittar en skattkista fylld med juveler och guld. 
            Du blir rik och lever ett liv i lyx och överflöd.

            Slut:

            Du blir en välbärgad person med mycket rikedom, 
            men du lär dig att rikedom inte alltid ger lycka och söker en djupare mening med livet.
            """);
        }
        else
        {
            Console.WriteLine($"""
            
            När du senare studerar kartan noggrant upptäcker du att det finns många ledtrådar i den som leder till fler äventyr. 
            Du beslutar dig för att fortsätta söka efter skatter och mysterier i framtiden.
            
            Slut:

            Du ger dig ut på ett livslångt äventyr för att upptäcka nya skatter och lösa mysterier, 
            vilket ger dig ett liv fullt av spänning och upptäckter.
            """);
        }
    }
    //Går runt stugan
    else
    {
        Console.WriteLine($"""
        
        När du går runt stugan, upptäcker du en liten, dold trädgård bakom ett buskage. 
        Trädgården är fylld med sällsynta och färgglada blommor, och i dess mitt står en gammal fontän. 
        Vid foten av fontänen hittar du en förseglad glasflaska som verkar innehålla en mystisk vätska.

        Du öppnar flaskan och en magisk dimma börjar stiga upp och forma sig till en strålande ande. 
        Anden tackar dig för att du befriade den och erbjuder dig en önskan i gengäld.

        Slut:

        Du väljer din önskan och lämnar skogen med ett hjärta fyllt av tacksamhet. 
        Din önskan förändrar ditt liv på ett sätt du aldrig kunnat föreställa dig, 
        och skogen förblir en plats av magi och mystik i ditt minne.
        """);
    }
}