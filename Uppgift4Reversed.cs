public class Baklänges
{

    public static void Run()
    
    {
        System.Console.WriteLine("Type in a word:");

        string word = Console.ReadLine()!;

        for (int i = word.Length - 1; i >= 0 ; i--)
        {
        Console.Write(word[i]);
        }
        Console.ReadLine();
    }

}
