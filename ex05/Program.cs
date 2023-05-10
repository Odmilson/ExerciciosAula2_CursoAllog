internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Insira o valor em graus Fahrenheit:");
        double f;
        while (!double.TryParse(Console.ReadLine().Replace('.', ','), out f) || f <= -1)
        {
            Console.WriteLine("Valor invalido! Digite novamente:");
        }

        double c = (f - 32) * 5 / 9;



        Console.WriteLine("O valor convertido em graus Celsius é:" + Convert.ToString(c));
        Console.ReadLine();
    }
}