using Desafios;
class ProgramaDesafios
{
    static void Main()
    {
        while (true)
        {

            MostrarMenu();
            string input = Console.ReadLine();

            if (input == "0")
            {
                Console.WriteLine("Programa encerrado.");
                break;
            }

            switch (input)
            {
                case "1":
                    Desafio1.Desafio();
                    break;
                case "2":
                    Desafio2.Desafio();
                    break;
                case "3":
                    Desafio3.Desafio();
                    break;
                case "4":
                    Desafio4.Desafio();
                    break;
                case "5":
                    Desafio5.Desafio();
                    break;
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
    static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("Bem-vindo(a)! Este é um programa em C# feito para demonstração dos desafios propostos para a vaga de estágio na UltraLIMS.");
        Console.WriteLine("Escolha um número de 1-5 para acessar o desafio desejado, ou digite 0 para sair:");
        Console.WriteLine("\n===== DESAFIOS DE LÓGICA =====");
        Console.WriteLine("1 - Desafio 1: Sequência de Fibonacci");
        Console.WriteLine("2 - Desafio 2: Busca Binária");
        Console.WriteLine("3 - Desafio 3: Número perfeito");
        Console.WriteLine("4 - Desafio 4: Maior Substring Palindrômica");
        Console.WriteLine("5 - Desafio 5: Simulação de saque em Caixa Eletrônico");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("==============================\n");
    }

    
}




