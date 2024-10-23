using System.ComponentModel;
using System.Diagnostics;

namespace Grupparbete_1;

class Program
{
    static void Main(string[] args)
    {
        bool endrun = true;

        while (endrun) 
        {
            Console.WriteLine("Välj program att köra");
            Console.WriteLine("1. Array, 2. LastString, 3. SearchandWrite, 4. Baklänges, 5. Bytplats, 0. Avsluta:");
            int Val;

           
            if (!int.TryParse(Console.ReadLine(), out Val))
            {
                Console.WriteLine("Ogiltigt val, försök igen.");
                continue; 
            }

            switch (Val)
            {
                case 1:
                    Uppgift1Array.Run();
                    break;
                case 2:
                    Uppgift2LastString.Run();
                    break;
                case 3:
                    Uppgift3SearchandWrite.Run();
                    break;
                case 4:
                    Uppgift4Reversed.Run();
                    break;
                case 5:
                    Uppgift5CchangePosition.Run();
                    break;
                case 0:
                    endrun = false; // Exit the loop
                    Console.WriteLine("Avslutar programmet.");
                    break;
                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;
            }
        }
    }
}
