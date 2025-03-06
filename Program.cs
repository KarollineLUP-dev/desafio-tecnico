using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Escolha o Problema para executar a solução:");
            Console.WriteLine("1 - Calcule a variável SOMA");
            Console.WriteLine("2 - Verifique se o número pertence à sequência Fibonacci");
            Console.WriteLine("3 - Análise o faturamento Mensal");
            Console.WriteLine("4 - Calcule o percentual do faturamento por estado");
            Console.WriteLine("5 - Inverter os caracteres da palavra");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("\nOpção:");

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    CalcularSoma.Executar();
                    break;
                case "2":
                    CheckFibonacci.Executar();
                    break;
                case "3":
                    FaturamentoDiario.Executar();
                    break;
                case "4":
                    FaturamentoEstados.Executar();
                    break;
                case "5":
                    InverterString.Executar();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("\nOpção Inválida!");
                    break;
            }
            Console.WriteLine("Precione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}

