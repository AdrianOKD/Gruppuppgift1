//Hämta in en sträng från terminalen. Skriv ut det sista ordet i strängen (ord definieras är som text som separeras av mellanslag).
public class LastString{

public static void Run()
{


System.Console.WriteLine("Skriv något :)");

String användarMening = Console.ReadLine()!;


char[] mellan = {';', ' ', '.', '!', '?', ','};

String[] ord = användarMening.Split(mellan);

Console.WriteLine($"Sista ordet i strängen är: {ord[^1]}");
}

}






