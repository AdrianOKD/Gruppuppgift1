public class Array1{

    public static void Run(){

        System.Console.WriteLine("Type in 10 numbers: ");

        int [] numbers = new int [10];

        for (int i = 0; i < 10; i++) 
        {
            numbers[i] = int.Parse(Console.ReadLine()!);
        }
            
        Array.Sort (numbers);
        
        int smallest = numbers[0];
        int largest = numbers[numbers.Length - 1];

        Console.WriteLine("Smallest number: " + smallest);
        Console.WriteLine("Largest number: " + largest);

  
     

     }

 }
