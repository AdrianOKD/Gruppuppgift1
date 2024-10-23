using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

public class SearchandWrite
{


    public static void Run ()
    {
        
       /*    //Pass the filepath and file name to the streamReader constructor
        StreamReader sr = new StreamReader("C:Test.txt");
        

        //Read the first line of text
        string line = sr.ReadLine();
        //continue to read until end of file

        while(line != null)
        {
            //write the line to console window
           System.Console.WriteLine(line);

            //Read the next line
            line = sr.ReadLine();
        }
        //close the file
        sr.Close();
        Console.ReadLine();*/


    System.Console.WriteLine("filnamn.txt");
    string fileName = Console.ReadLine()!;

    string fileContent = File.ReadAllText(fileName);

    Console.WriteLine("\nfilnamn.txt:\n");
    Console.WriteLine(fileContent);

        

    }
}