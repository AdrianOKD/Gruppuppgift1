public class Array1{

    public static void Run(){

        System.Console.WriteLine("Hej!, skriv in 10 nummer: ");



        int [] numbers = new int [10];
        //int input = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < 10; i++) 
        {
            numbers[i] = int.Parse(Console.ReadLine()!);

        }
        //System.Console.WriteLine(input);
            
        Array.Sort (numbers);
        
        int smallest = numbers[0];
        int largest = numbers[numbers.Length - 1];

        Console.WriteLine("Smallest number: " + smallest);
        Console.WriteLine("Largest number: " + largest);

  
     

     }

 }