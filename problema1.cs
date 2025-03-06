// Problema 1 : Cálculo da variável SOMA

using System;

class CalcularSoma
{
  public static void Executar()
  {
    int INDICE = 13, SOMA = 0, K = 0;

    while (K < INDICE)
    {
      K += 1;
      SOMA += K;
    }

    Console.WriteLine($"O valo da variável SOMA é: {SOMA}");
    // Valor esperado é 91
  }
  
}



