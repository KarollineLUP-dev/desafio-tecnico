// Problema 2 : Verifica se um número pertence a sequência de Fibonacci
using System;

class checkFibonacci
{
    static bool PertenceFibonacci(int num)
    {
        int a = 0, b = 1;
        while (a <= num)
        {
            if (a == num)
            {
                return true;
                Console.WriteLine($"O número {num} pertence a sequência Fibonacci");

            }
            int temp = a + b;
            a = b;
            b = temp;
        }
        return false;
        Console.WriteLine($"O número {num} não pertence a sequência Fibonacci");
    }
}




