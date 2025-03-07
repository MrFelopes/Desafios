namespace Desafios
{
    public static class Desafio1
    {
        public static void Desafio()
        {
            Console.Clear();
            Console.WriteLine("Sequência de Fibonacci");
            Console.WriteLine("Digite a quantidade de números na sequência de Fibonacci (Escolha de 1 a 10):");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0 && n < 10)
            {
                Console.WriteLine("\nSequência:");
                SFibonacci(n);
            }
            else
            {
                Console.WriteLine("Insira um número INTEIRO, POSITIVO e MENOR QUE 10.");
            }
        }

        private static void SFibonacci(int quantidade)
        {
            int primeironum = 0, segundonum = 1;

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(primeironum + (i < quantidade - 1 ? "," : "\n"));
                int proximonum = primeironum + segundonum;
                primeironum = segundonum;
                segundonum = proximonum;
            }
        }
    }
}
