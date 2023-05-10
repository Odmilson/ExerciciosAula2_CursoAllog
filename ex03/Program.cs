internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Insira seu peso em Kg:");
        double peso;
        while(!double.TryParse(Console.ReadLine().Replace('.', ','), out peso) || peso <= 0){
            Console.WriteLine("Valor invalido! Digite novamente:");
        }

        Console.WriteLine("Insira sua altura em m:");
        double altura;
        while (!double.TryParse(Console.ReadLine().Replace('.', ','), out altura) || altura <= 0)
        {
            Console.WriteLine("Valor invalido! Digite novamente:");
        }

        double IMC = peso / (altura * altura);

        Console.WriteLine("Seu IMC é:" + IMC.ToString("F2"));
        Console.ReadLine();
    }
}