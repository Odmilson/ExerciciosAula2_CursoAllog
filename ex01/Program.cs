using System;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Insira o valor da cotação:");
        double cotacao;
        while(!double.TryParse(Console.ReadLine().Replace('.', ','), out cotacao) || cotacao <= 0){
            Console.WriteLine("Valor invalido! Digite novamente:");
        }

        Console.WriteLine("Insira o valor em dolar:");
        double dolar;
        while (!double.TryParse(Console.ReadLine().Replace('.', ','), out dolar) || dolar <= 0)
        {
            Console.WriteLine("Valor invalido! Digite novamente:");
        }

        double real = dolar * cotacao;



        Console.WriteLine("O valor convertido é:" + Convert.ToString(real));
        Console.ReadLine();
    }
}