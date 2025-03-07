namespace Desafios
{
    public static class Desafio5
    {
        public static void Desafio()
        {
            Console.Clear();
            Console.WriteLine("Digite um valor inteiro: ");

            if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
            {
                CalcularNotasEMoedas(numero);
            }
            else
                Console.WriteLine("Valor inválido, digite um valor inteiro positivo.");
        }
        private static void CalcularNotasEMoedas(int numero)
        {
            int[] notas = { 100, 50, 20, 10, 5, 2 };
            int[] moedas = { 1 };

            Console.WriteLine("\nNotas necessárias: ");
            foreach (int nota in notas)
            {
                int quantiaNotas = numero / nota;
                if (quantiaNotas > 0)
                {
                    Console.WriteLine($"{quantiaNotas} notas de R${nota}");
                    numero %= nota;
                }
            }

            Console.WriteLine("\nMoedas necessárias: ");
            foreach (int moeda in moedas)
            {
                int quantiaMoedas = numero / moeda;
                if (quantiaMoedas > 0)
                {
                    Console.WriteLine($"{quantiaMoedas} moedas de R${moeda}");
                    numero %= moeda;
                }
            }
        }
    }
}
