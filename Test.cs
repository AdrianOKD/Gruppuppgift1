  public class Test {


    public static void kör(){
  
  //Fråga 2
  /*
  //cedric
        Console.Write("Skriv in en sträng: ");
        string input = Console.ReadLine();

        string[] ord = input.Split(' ', '!');
        string sistaOrd = ord[ord.Length - 1];

        Console.WriteLine("Det sista ordet är: " + sistaOrd);

 text.txt inte text.cs

//

System.Console.WriteLine("Skriv något :)");

String användarMening = Console.ReadLine()!;

char[] mellan = {';', ' ', '.', '!', '?', ','};

String[] ordet = användarMening.Split(mellan);

Console.WriteLine($"Sista ordet i strängen är: {ordet[^1]}");
 //Adrian


{
 
 Console.WriteLine("Skriv in en mening:");
        string input = Console.ReadLine();

        
        string[] ord = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        
        if (ord.Length > 0)
        {
            
            Console.WriteLine("Sista ordet är: " + ord[^1]);
        }
        else
        {
            Console.WriteLine("Ingen giltig mening angavs.");
        }


       }*/
    
/*for (int i = length - 1; i >= 0 ; i--)
{
       
}
*/

//Fråga 4

//Adrian 
/*
        System.Console.WriteLine("Skriv in ett ord:  ");

        string ord = Console.ReadLine()!;

        for (int i = ord.Length - 1; i >= 0 ; i--)
        {
        Console.Write(ord[i]);
        }

    /*
//ismail
 Console.WriteLine("Skriv in en mening:");
        string input = Console.ReadLine();
        Console.WriteLine(string.Join(" ", input.Split(' ').Reverse()));

*/
/*
//Filip
  Console.Write("Skriv en sträng: ");
        string input = Console.ReadLine();
        char[] ord = input.ToCharArray();
        Array.Reverse(ord);
        Console.WriteLine(new string(ord));


//    cedric    

*/
/*
Console.Write("Skriv ett ord: ");
        string ord = Console.ReadLine();

        char[] charArray = ord.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        Console.WriteLine("ordet omvänt är: " + reversedString);


  */
  

  //Fråga 5
  

  //Adrian
/*
string a = "Hej, jag gillar glass. Vad gillar du?";
string[] mening1 = a.Split(' ', '?');

int jag1 = Array.IndexOf(mening1, "jag");
int du1 = Array.IndexOf(mening1, "du");

if (jag1 != -1 && du1 != -1)
{
    (mening1[jag1], mening1[du1]) = (mening1[du1], mening1[jag1]);
}

string färdigtOrd1 = string.Join(" ", mening1);
Console.WriteLine(färdigtOrd1);

  
//

//Cedric
string a = "Hej, jag gillar glass. Vad gillar du ?";
string b = "Jag brukar programmera. Är du en programmerare också?";
string c = "Du måste handla mat medan jag städar.";
        string result = JagochDu(a);
        string result1 = JagochDu(b);
        string result2 = JagochDu(c);

System.Console.WriteLine();
System.Console.WriteLine(result);
        System.Console.WriteLine(result1);
        System.Console.WriteLine(result2);
    

    static string JagochDu(string input)
    {
        string temp = input.Replace("jag", "#temp#");
        temp = temp.Replace("du", "jag");
        temp = temp.Replace("#temp#", "du");

        return temp;
    }

//Filip
    {
        Console.Write("Skriv en mening: ");
        string mening = Console.ReadLine()!;
        string BytaPlatsPåJagDu = BytaJagDu(mening!);
        Console.WriteLine(BytaPlatsPåJagDu);
    }

    static string BytaJagDu(string mening)
    {
        string[] ord = mening.Split(' ', '!', '?','.',',');
        for (int i = 0; i < ord.Length; i++)
        {
            if (ord[i] == "jag")
                ord[i] = "du";
            else if (ord[i] == "du")
                ord[i] = "jag";
        }
        return string.Join(" ", ord);
    }

      //Uppgift 3

      //Cedric 

           //Pass the file path and file name to the streamReader constructor
        StreamReader sr = new StreamReader("C:Sample.txt");

        //Read the first line of text
        line = sr.ReadLine();
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
        Console.ReadLine();


        

  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  */
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
    }
  }




