public class BytPlats

{

    public static void Run () 
    
    
    {

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

string b = "Jag brukar programmera. Är du en programmerare också?";

string[] ord2 = b.Split(' ');

int jag2 = Array.IndexOf(ord2, "Jag");
int du2 = Array.IndexOf(ord2, "du");

if (jag2 != -1 && du2 != -1)
{
    (ord2[jag2], ord2[du2]) = (ord2[du2], ord2[jag2]);
}

string färdigtOrd2 = string.Join(" ", ord2);
Console.WriteLine(färdigtOrd2);

string c = "Du måste handla mat medans jag städar huset.";

string[] ord3 = c.Split(' ');

int jag3 = Array.IndexOf(ord3, "jag");
int du3 = Array.IndexOf(ord3, "Du");

if (jag3 != -1 && du3 != -1)
{
    (ord3[jag3], ord3[du3]) = (ord3[du3], ord3[jag3]);
}

string färdigtOrd3 = string.Join(" ", ord3);
Console.WriteLine(färdigtOrd3);

}






}