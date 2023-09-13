using System;

class PolidromeChecker
{
    static bool isPolidrome(string text)
    {
        text = text.Replace(" ","").ToLower();
        char[] caracters = text.ToArray();
        Array.Reverse(caracters);
        string invertd = new string(caracters);

        return text == invertd;
    }


    static void Main(){
        Console.Write("Digite uma palavra: ");
        string text = Console.ReadLine();

        if(isPolidrome(text))
        {
            Console.WriteLine("Sua palavra é um palidromo.");
        }
        else
        {
            Console.WriteLine("Sua palavra não é um palidromo.");
        }
    }


}