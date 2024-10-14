// övning på att använda listor för att skapa/hantera samlingar

Console.Clear();

// Lista på trevliga frukter, tex "äpple", "appelsin", "annanas"
List<string> frukter = ["äpple", "apelsin", "annanas"];

Console.WriteLine($"Min frunktlista : {frukter[0]} {frukter[1]} {frukter[2]}.");

// Ändra i listan:

frukter[0] = "banan";

Console.WriteLine($"Min frunktlista : {frukter[0]} {frukter[1]} {frukter[2]}.");

// Gå igenom listan = loopa igenom = från första till sista

foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}

// skapa en lista på valfri sak (4st)
// skriv ut varje sak på samma rad

List<string> planes = ["viggen", "gripen", "draken", "tunnan"];

foreach (var plane in planes)
{
    Console.Write($"{plane}, ");
}

for (int i = 0; i < planes.Count; i++)
{
    Console.Write($"{planes[i]} ");
}

Console.Clear();

// skapa ett register
// en tom lista
List<string> namnlista = [];

// while-loop
while (true)
{
    Console.Write("Ange ett namn: ");
    string namn = Console.ReadLine();
    namnlista.Add(namn);

    //skriv ut hela listan på en rad
    for (int i = 0; i < namnlista.Count; i++)
    {
        Console.Write($"{namnlista[i]}, ");
    }
    Console.WriteLine();
}