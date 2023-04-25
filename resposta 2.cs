using System;

class Program
{
    static void Main(string[] args)
    {
        int n, i, a = 0, b = 1, c = 0;
        bool encontrado = false;

        Console.Write("Informe um número inteiro positivo: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n == 0)
        {
            Console.WriteLine("0 pertence à sequência de Fibonacci.");
            return;
        }

        for (i = 1; i <= n; i++)
        {
            if (c == n)
            {
                encontrado = true;
                break;
            }
            c = a + b;
            a = b;
            b = c;
        }

        if (encontrado)
            Console.WriteLine("{0} pertence à sequência de Fibonacci.", n);
        else
            Console.WriteLine("{0} não pertence à sequência de Fibonacci.", n);

        Console.ReadKey();
    }
}
