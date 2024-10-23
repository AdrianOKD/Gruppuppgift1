public class Baklänges
{

    public static void Run()
    
    {

        System.Console.WriteLine("Skriv in ett ord:  ");


        string ord = Console.ReadLine()!;

        for (int i = ord.Length - 1; i >= 0 ; i--)
        {
        Console.Write(ord[i]);
        }







    }






}
