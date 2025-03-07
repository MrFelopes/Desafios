namespace Desafios
{
    public static class Desafio2
    {
       public static void Desafio()
        {
            Console.Clear();
            int[] lista = { 3, 8, 12, 15, 23, 29, 36, 42, 50 };
            Console.WriteLine("Lista (em ordem): 3, 8, 12, 15, 23, 29, 36, 42, 50");
            Console.WriteLine("\nDigite o número que deseja buscar");

            if (int.TryParse(Console.ReadLine(), out int alvo) && alvo <= 50 && alvo >= 3)
            {
                int indice = BuscaBinaria(lista, alvo);
                if (indice != -1)
                    Console.WriteLine($"O número {alvo} está no índice {indice}");
                else Console.WriteLine("-1 (Número não encontrado)");
            }
            else
            {
                Console.WriteLine("Digite um número válido");
            }
            
        }
        //Busca Binária
        private static int BuscaBinaria(int[] lista, int alvo)
        {
            int esquerda = 0, direita = lista.Length - 1;

            while (esquerda <= direita)
            {
                int meio = (esquerda + direita) / 2;
                if (lista[meio] == alvo)
                    return meio;

                if (lista[meio] < alvo)
                    esquerda = meio + 1;
                else
                    direita = meio - 1;
            }
            return -1;
        }
    }
}
