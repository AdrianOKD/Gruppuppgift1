using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

public class SearchandWrite
{


    public static void Run ()
    {
    System.Console.WriteLine("Type in the name of the text file (Test.txt):");
    
    string fileName = Console.ReadLine()!;

    string fileContent = File.ReadAllText(fileName);

    Console.WriteLine(fileContent);    
    }
}
