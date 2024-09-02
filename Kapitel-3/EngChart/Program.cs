// Program som simulerar Engeneering Flowchart
using System.Runtime.CompilerServices;

Console.Clear();
Console.WriteLine("välkommen till ingengörens flödesschema!");

// Visa en ASCii art
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

Console.Write("Does it move? (y/n) ");
string answer = Console.ReadLine();

// om svar är ja eller nej
if (answer == "y")
{
    Console.Write("should it? (y/n) ");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("No problem!");
    }
    else
    {
        Console.WriteLine("Please apply duct tape.");
    }
}
else
{
    Console.Write("Should it? (y/n) ");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("Please apply WD-40.");
    }
    else
    {
        Console.WriteLine("No problem!");
    }
}