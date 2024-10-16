// morse kod program
Console.WriteLine("Översättningsprogram för morsekod.");
Console.Clear();

// två listor
List<string> alfabetet = [  "A", "B", "C", "D", "E", "F", "G", "H", "I", 
                            "J", "K", "L", "M", "N", "O", "P", "Q", "R", 
                            "S", "T", "U", "V", "W", "X", "Y", "Z", "Å", "Ä", "Ö"];

List<string> morsekod = [    ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", 
                             "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", 
                             "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", 
                              "-.--", "--..", ".--.-", ".-.-", "---.", "/" ];

// Läs in en text

Console.Write("Ange ett meddelande: ");
string bokstav = Console.ReadLine();

// uppslag i alfabetet efter index
int index = alfabetet.IndexOf(bokstav);

if (index >= 0)
{
    Console.WriteLine($"{bokstav} finns på index {index}");

    // plocka ut morsetecken för detta index
    string morsetecken = morsekod[index];
    Console.WriteLine($"{bokstav} är i morsekod {morsetecken}");
}
else
{
    Console.WriteLine("error");
}