
using System;
using System.Linq;
using System.Xml.Linq;

class FaturamentoDiario
{
    public static void Executar()
    {
        var(menorFaturamentoDia, maiorFaturamentoDia, diasAcimaMedia) = Analisar();

        Console.WriteLine($"Menor Valor de um faturamento Diário: {menorFaturamentoDia}");
        Console.WriteLine($"Maior Valor de um faturamento Diário: {maiorFaturamentoDia}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaMedia}");
    }
    static (double, double, int) Analisar()
    {
        string caminhoArquivoXML = "dados-faturamento-diario.xml";
        XDocument xmlDoc = XDocument.Load(caminhoArquivoXML);
        var faturamento = xmlDoc.Descendants("row").Select(d => (double)d.Element("valor")).Where(valor => valor > 0).ToArray();

        if (faturamento.Length == 0)
        {
            Console.WriteLine("Nenhum faturamento válido encontrado!");
            return (0, 0, 0);
        }

        double menorFaturamentoDia = faturamento.Min();
        double maiorFaturamentoDia = faturamento.Max();
        double mediaMensal = faturamento.Average();
        int diasAcimaMedia = faturamento.Count(valor => valor > mediaMensal);

        return (menorFaturamentoDia, maiorFaturamentoDia, diasAcimaMedia);
    }

}



