// Problema 5: Inverta os caracteres de uma palavra 

using System;

class InverterString
{
    public static void Executar()
    {
        Console.Write("Informe uma palavra: ");
        string leitura = Console.ReadLine();
        Console.WriteLine($"Palavra Invertida: {Inverter(leitura)}");
    }
    static string Inverter(string word)
    {
        {
            char[] invertida = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                invertida[i] = word[word.Length - 1 - i];
            }
            return new string(invertida);
        }

    }

}



