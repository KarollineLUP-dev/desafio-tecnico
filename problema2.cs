// Problema 2 : Verifica se um número pertence a sequência de Fibonacci
using System;

class CheckFibonacci
{
    public static void Executar()
    {
        Console.WriteLine("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (PertenceFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence a sequência Fibonacci");

        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence a sequência Fibonacci");
        }
    }
    static bool PertenceFibonacci(int num)
    {
        int a = 0, b = 1;
        while (a <= num)
        {
            if (a == num)
            {
                return true;

            }
            int temp = a + b;
            a = b;
            b = temp;
        }
        return false;
    }
}




