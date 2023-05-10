internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Insira o valor em graus celcius:");
        double c;
        while(!double.TryParse(Console.ReadLine().Replace('.', ','), out c) || c <= -273.16){
            Console.WriteLine("Valor invalido! Digite novamente:");
        }

        double f = (9 * c + 160) / 5;



        Console.WriteLine("O valor convertido em Fahrenheit é:" + Convert.ToString(f));
        Console.ReadLine();
    }
}