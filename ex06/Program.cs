using System;
internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Insira uma frase:");
        string a = Console.ReadLine();

        char[] frase = a.ToCharArray();

        for(int i = 0; i < frase.Length; i++)
        {
            if(frase[i] == 'A' || frase[i] == 'a')
            {
                frase[i] = '&';
            }
        }

        Console.WriteLine(frase);
        Console.ReadLine();
    }
}