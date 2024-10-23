//Hämta in en sträng från terminalen. Skriv ut det sista ordet i strängen (ord definieras är som text som separeras av mellanslag).
public class LastString{

public static void Run()
{
System.Console.WriteLine("Type in a string of words:");

String userString = Console.ReadLine()!;

char[] seperator = {';', ' ', '.', '!', '?', ','};

String[] word = userString.Split(seperator, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"The last word in your string is: {word[^1]}");
}

}






