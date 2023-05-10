internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Insira seu nome:");
        double salario;

        while(!double.TryParse(Console.ReadLine(), out salario) || salario <= 0)
        {
            Console.WriteLine("Valor Invalido ! Insira novamente:");
        }

        if (salario <= 1849.99)
        {
            salario += 320;
        }
        else
        {
            salario += 180;
        }

        Console.WriteLine("O salário com reajuste é: " + salario.ToString("F2"));
        Console.ReadLine();
    }
}