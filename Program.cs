using System;

namespace JogoAdivinhe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a palavra secreta:");
            string palavraSecreta = Console.ReadLine().ToLower();

            Console.WriteLine("Digite a descrição do segredo:");
            string descricao = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Descrição do Segredo:");
            Console.WriteLine(descricao);

            Console.WriteLine("\nAgora tente adivinhar a palavra secreta!");

            int tentativasRestantes = 5;

            while (tentativasRestantes > 0)
            {
                Console.WriteLine($"\nTentativas restantes: {tentativasRestantes}");
                Console.Write("Digite sua resposta: ");
                string resposta = Console.ReadLine().ToLower();

                if (resposta == palavraSecreta)
                {
                    Console.WriteLine("\nParabéns! Você descobriu a palavra secreta!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nResposta incorreta. Tente novamente.");
                    tentativasRestantes--;
                }
            }

            if (tentativasRestantes == 0)
            {
                Console.WriteLine("\nFim do jogo. Suas tentativas acabaram.");
            }
        }
    }
}
