namespace Desafios
{
    public static class Desafio4
    {
       public static void Desafio()
        {
            Console.Clear();
            Console.Write("Digite um texto: ");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                string maiorPalindromo = MaiorSubstringPalindromica(input);
                Console.WriteLine($"Maior substring palindrômica: {maiorPalindromo}");
            }
            else
            {
                Console.WriteLine("Digite uma string válida.");
            }
        }

        private static void VerificarPalindromo(string s, int esquerda, int direita, ref int inicio, ref int maxLen)
        {
            while (esquerda >= 0 && direita < s.Length && s[esquerda] == s[direita])
            {
                int len = direita - esquerda + 1;
                if (len > maxLen)
                {
                    inicio = esquerda;
                    maxLen = len;
                }
                esquerda--;
                direita++;
            }
        }
        static string MaiorSubstringPalindromica(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";

            int inicio = 0, maxLen = 0;

            for (int i = 0; i < s.Length; i++)
            {
                VerificarPalindromo(s, i, i, ref inicio, ref maxLen);

                VerificarPalindromo(s, i, i + 1, ref inicio, ref maxLen);
            }

            return s.Substring(inicio, maxLen);
        }

    }
}

