// Problema 5: Inverta os caracteres de uma palavra 

using System;

class InverterString
static string Inverter(string s)
{
    {
        char[] invertida = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            invertida[i] = s[s.Length - i - 1];
        }
        return new string(invertida);
    }
    static void Main()
    {
        Console.Write("Informe uma palavra: ");
        string leitura = Console.ReadLine();
        Console.Write("String Invertida: {Inverter(entrada)}");
    }
}





