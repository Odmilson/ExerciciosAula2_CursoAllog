internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Insira o tempo de viagem (hh:mm:ss):");
        string tempoentrada = Console.ReadLine();
        
        string[] partes = tempoentrada.Split(':');

        if(partes.Length != 3)
        {
            Console.WriteLine("Formato inválido");
            return;
        }

        int horas, minutos, segundos;

        if(!int.TryParse(partes[0], out horas) || partes[0].Length != 2 || !int.TryParse(partes[1], out minutos) || partes[1].Length != 2 ||  !int.TryParse(partes[2], out segundos) || partes[3].Length != 2)
        {
            Console.WriteLine("Formato inválido");
            return;
        }

        Console.WriteLine("Insira a velocidade:");
        double velocidade;

        while (!double.TryParse(Console.ReadLine().Replace('.', ','), out velocidade) || velocidade <= 0)
        {
            Console.WriteLine("Valor invalido! Digite novamente:");
        }

        double tempo = horas + (Convert.ToDouble(minutos) / 60) + (Convert.ToDouble(segundos) / 3600);

        double distancia = tempo * velocidade;

        double litros_usados = distancia / 12;

        Console.WriteLine("Você usou " + litros_usados.ToString("F2") + " litros de combustivel");
        Console.ReadLine();
    }
}