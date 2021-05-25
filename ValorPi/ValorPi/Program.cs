using System;
using static System.Math;
using System.Threading;

namespace ValorPi
{
    class Program
    {
        static void Main(string[] args)
        {

            char resposta;

            // Função que calcula o valor de pi simulando uma circunferência dentro de um quadrado
            static double calcularPiPorCircunferenciaInscrita(int tentativas)
            {
                int acertos = 0;

                for (int i = 0; i < tentativas; i++)
                {
                    double x = new Random().NextDouble(); // Gera números aleatórios entre 0 e 1
                    double y = new Random().NextDouble(); // Gera números aleatórios entre 0 e 1

                    if (Pow(x, 2) + Pow(y, 2) < 1.0) // Regra para o ponto gerado estar na circunferência
                    {
                        acertos++;
                    }
                }

                Console.WriteLine("Acertos na circunferência = " + acertos + "/" + tentativas);
                return (double)(4.0 * acertos / tentativas);
            }

            do
            {

                int tentativas;

                Console.Clear();
                Console.WriteLine("Cálculo do valor de pi através de pontos aleatórios em uma circunferência inscrita");
                Thread.Sleep(1000);
                Console.WriteLine();

                Console.Write("Quantos pontos você deseja marcar? ");
                tentativas = int.Parse(Console.ReadLine());

                Thread.Sleep(2000);
                Console.WriteLine();

                double pi = calcularPiPorCircunferenciaInscrita(tentativas);
                Console.WriteLine("Pi = " + pi);
                Console.WriteLine();

                Console.Write("Deseja tentar novamente (S/N): ");
                resposta = Console.ReadLine().ToCharArray()[0];

            } while (resposta.Equals('S'));

            Console.WriteLine();
            Console.WriteLine("Obrigado por utilizar o programa! :)");
            Thread.Sleep(2000);

        }
    }
}
