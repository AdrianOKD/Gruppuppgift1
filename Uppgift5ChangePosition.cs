public class BytPlats
{
    public static void Run()

    {
        string a = "Hej, jag gillar glass. Vad gillar du ?";
        string[] string1 = a.Split(' ', '?');

        int jag1 = Array.IndexOf(string1, "jag");
        int du1 = Array.IndexOf(string1, "du");

        if (jag1 != -1 && du1 != -1)
        {
            (string1[jag1], string1[du1]) = (string1[du1], string1[jag1]);
        }

        string newString1 = string.Join(" ", string1);
        Console.WriteLine(newString1);

        string b = "Jag brukar programmera. Är du en programmerare också?";

        string[] string2 = b.Split(' ');

        int jag2 = Array.IndexOf(string2, "Jag");
        int du2 = Array.IndexOf(string2, "du");

        if (jag2 != -1 && du2 != -1)
        {
            (string2[jag2], string2[du2]) = (string2[du2], string2[jag2]);
        }

        string newString2 = string.Join(" ", string2);
        Console.WriteLine(newString2);

        string c = "Du måste handla mat medans jag städar huset.";

        string[] string3 = c.Split(' ');

        int jag3 = Array.IndexOf(string3, "jag");
        int du3 = Array.IndexOf(string3, "Du");

        if (jag3 != -1 && du3 != -1)
        {
            (string3[jag3], string3[du3]) = (string3[du3], string3[jag3]);
        }

        string newString3 = string.Join(" ", string3);
        Console.WriteLine(newString3);
    }
}
