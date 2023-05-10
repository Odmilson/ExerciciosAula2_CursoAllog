using System;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        while(true)
        {    
            Console.WriteLine("1 - Novo IMC");
            Console.WriteLine("2 - Consultar IMC");
            Console.WriteLine("0 - Sair\n");

            Console.WriteLine("Escolha uma opção:");
            int opcao;

            while(!int.TryParse(Console.ReadLine(), out opcao) || opcao <= -1 || opcao >= 3) // Força a entrada de opções válidas
            {
                Console.Clear();            //Limpa o console
                Console.WriteLine("Entrada Inválida ! Tente Novamente\n");
                Console.WriteLine("1 - Novo IMC");
                Console.WriteLine("2 - Consultar IMC");
                Console.WriteLine("0 - Sair\n");

                Console.WriteLine("Escolha uma opção:");
            }

            switch(opcao)
            {
                case 1:
                    CadastrarIMC();
                    break;
                case 2:
                    ConsultarIMC();
                    break;
                case 0:
                    return;
            }
        }
    }

    static void CadastrarIMC()
    {
        Console.Clear();
        Console.WriteLine("--- Cadastro de IMC ---\n\n");

        Console.Write("Nome: ");
        string nome = Console.ReadLine()
        
        Console.Write("Idade: ");
        int idade;
        while(!int.TryParse(Console.ReadLine(), out idade) || idade <= 0){
            Console.WriteLine("Valor invalido! Digite novamente:");
        }

        Console.Write("Peso (kg): ");
        double peso;
        while(!double.TryParse(Console.ReadLine().Replace('.', ','), out peso) || peso <= 0){
            Console.WriteLine("Valor invalido! Digite novamente:");
        }

        Console.Write("Altura (m): ");
        double altura;;
        while(!double.TryParse(Console.ReadLine().Replace('.', ','), out altura) || altura <= 0){
            Console.WriteLine("Valor invalido! Digite novamente:");
        }

        double imc = CalcularIMC(peso, altura);

        string nomeArquivo = "calculos_imc.txt";

        using (StreamWriter writer = File.AppendText(nomeArquivo)) //Inicia o arquivo para gravação
        {
            writer.WriteLine($"Nome: {nome}");          //Escreve uma nova linha no arquivo no formato -> Nome: Jubileu         
            writer.WriteLine($"Idade: {idade}");        
            writer.WriteLine($"Peso: {peso} kg");
            writer.WriteLine($"Altura: {altura} m");
            writer.WriteLine($"IMC: {imc:F2}");
            writer.WriteLine();
        }
        Console.Clear();
        Console.WriteLine("Cálculo de IMC cadastrado com sucesso!\n");
    }

    static void ConsultarIMC()
    {
        Console.WriteLine("----- Consulta de Cálculos de IMC -----");
        Console.WriteLine();

        string nomeArquivo = "calculos_imc.txt";

        if (File.Exists(nomeArquivo)) //Verifica se o arquivo existe
        {
            using (StreamReader reader = File.OpenText(nomeArquivo)) //Inicia o arquivo para leitura
            {
                string linha;
                while ((linha = reader.ReadLine()) != null) //Le linha por linha até o final do arquivo
                {
                    Console.WriteLine(linha);
                }
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Nenhum cálculo de IMC encontrado.");
        }

        Console.WriteLine("\n\nPressione qualquer tecla para voltar.");
        Console.ReadKey();
        Console.Clear();
    }

    static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura); // IMC = Peso ÷ Altura²
    }
}