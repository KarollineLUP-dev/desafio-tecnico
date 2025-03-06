// Problema 4: Calcule o percentual do faturamento por estado

using System;

class FaturamentoEstados
{
    public static void Executar()
    {
        var (totalFaturamento, percentualEstado) = Calcular();
        Console.WriteLine($"Valor Total Mensal: {totalFaturamento.ToString("C")}");
        Console.WriteLine($"Estado | Porcentagem");

        foreach (var estado in percentualEstado)
        {
            Console.WriteLine($"{estado.Key}     | {estado.Value}%");
        }
    }
    static (double, Dictionary<string, double>) Calcular()
    {

        Dictionary<string, double> faturamento = new Dictionary<string, double>
        {
            {"SP",67836.43},
            {"RJ",36678.66},
            {"MG",29229.88},
            {"ES",27165.48},
            {"Outros",19849.53}
        };
        double totalFaturamento = faturamento.Values.Sum();
        Dictionary<string, double> percentualEstado = new Dictionary<string, double>();

        foreach (var estado in faturamento)
        {
            double percentual = (estado.Value / totalFaturamento) * 100;
            percentualEstado[estado.Key] = Math.Round(percentual, 2);

        }

        return (totalFaturamento, percentualEstado);
    }

}



