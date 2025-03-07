using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    public static class Desafio3
    {
        public static void Desafio()
        {
            Console.Clear();
            Console.Write("Digite um número (De 1 a 100): ");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero <= 100 && numero > 0)
            {
                if (IsNumeroPerfeito(numero))
                    Console.WriteLine($"{numero} é um número perfeito.");
                else
                    Console.WriteLine($"{numero} não é um número perfeito.");
            }
            else
            {
                Console.WriteLine("Digite um número inteiro, positivo de 1 a 100.");
            }
        }
        private static bool IsNumeroPerfeito(int n)
        {
            int somaDivisores = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    somaDivisores += i;
                }
            }

            return somaDivisores == n;
        }
    }
}
