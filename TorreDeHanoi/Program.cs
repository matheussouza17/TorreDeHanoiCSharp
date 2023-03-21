using System;
using TorreDeHanoi;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            int tam = 0;
            int cont = 0;
            Console.WriteLine("\tSeja bem vindo(a)!");

            while (tam < 3 || tam > 20) {
                Console.WriteLine("Digite tamanho das torres(3 - 20):");
                tam = int.Parse(Console.ReadLine());
            }
            Torre torre = new Torre(tam);

            bool isEnd = false;
            bool sair = false;
            torre.printTorres();
            while (isEnd == false && sair == false) {
                string origem, destino;
                Console.WriteLine("Digite a torre de origem:");
                origem = Console.ReadLine();

                Console.WriteLine("Digite a torre de destino: \nOu digite 'S' para sair");
                destino = Console.ReadLine();

                origem = origem.ToUpper();
                destino = destino.ToUpper();

                if (destino[0] == 'S')
                    sair = true;
                else {
                    Console.Clear();
                    torre.trocaTorres(origem[0], destino[0]);
                    isEnd = torre.verificaEnd();
                    torre.printTorres();
                }
                cont++;
            }
            if (isEnd == true)
                Console.WriteLine($"VOÇÊ GANHOU em {cont} jogadas\n\tPARABÉNS!\n");
            Console.WriteLine("Developed by Matheus Henrique Souza\n\n");
        }
    }
}