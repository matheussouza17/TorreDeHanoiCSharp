using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreDeHanoi {
    internal class Torre {
        private int tam = 1;
        private int[] torreA;
        private int[] torreB;
        private int[] torreC;
        private int topA;
        private int topB;
        private int topC;
        public Torre(int tam) {
            this.tam = tam;
            topA = tam - 1;
            topB = -1;
            topC = -1;
            torreA = new int[tam];
            torreB = new int[tam];
            torreC = new int[tam];

            for (int i = 0, j = tam; i < tam; i++, j--)
                torreA[i] = j;

            for (int i = 0; i < tam; i++) {
                torreB[i] = 0;
                torreC[i] = 0;
            }

        }

        public int PUSH_POP(char origem, char destino) {
            if (origem == 'A') {
                if (destino == 'B') {
                    topB++;
                    torreB[topB] = torreA[topA];
                    torreA[topA] = 0;
                    topA--;

                }
                else {
                    topC++;
                    torreC[topC] = torreA[topA];
                    torreA[topA] = 0;
                    topA--;

                }
            }
            else if (origem == 'B') {
                if (destino == 'A') {
                    topA++;
                    torreA[topA] = torreB[topB];
                    torreB[topB] = 0;
                    topB--;

                }
                else {
                    topC++;
                    torreC[topC] = torreB[topB];
                    torreB[topB] = 0;
                    topB--;

                }
            }
            else {
                if (destino == 'B') {
                    topB++;
                    torreB[topB] = torreC[topC];
                    torreC[topC] = 0;
                    topC--;

                }
                else {
                    topA++;
                    torreA[topA] = torreC[topC];
                    torreC[topC] = 0;
                    topC--;

                }
            }

            return 0;
        }//PUSH e POP

        public void trocaTorres(char origem, char destino) { //Validações
            if (origem == 'A' && topA != -1) {
                if (destino == 'B') {
                    if (topB == -1||torreA[topA] < torreB[topB]) {
                        PUSH_POP(origem, destino);
                    }
                    else {
                        Console.WriteLine("ATENÇÃO, VALOR DE ORIGEM TEM QUE SER MENOR QUE DESTINO!");
                    }
                }
                else if (destino == 'C') {
                    if (topC == -1||torreA[topA] < torreC[topC] ) {
                        PUSH_POP(origem, destino);
                    }
                    else {
                        Console.WriteLine("ATENÇÃO, VALOR DE ORIGEM TEM QUE SER MENOR QUE DESTINO!");
                    }
                }
                else {
                    Console.WriteLine("DIGITE VALOR DE DESTINO VALIDO!");
                }
            }
            else if (origem == 'B' && topB != -1) {
                if (destino == 'A') {
                    if (topA == -1 || torreB[topB] < torreA[topA] ) {
                        PUSH_POP(origem, destino);
                    }
                    else {
                        Console.WriteLine("ATENÇÃO, VALOR DE ORIGEM TEM QUE SER MENOR QUE DESTINO!");
                    }
                }
                else if (destino == 'C') {
                    if (topC == -1 || torreB[topB] < torreC[topC]) {
                        PUSH_POP(origem, destino);
                    }
                    else {
                        Console.WriteLine("ATENÇÃO, VALOR DE ORIGEM TEM QUE SER MENOR QUE DESTINO!");
                    }
                }
                else {
                    Console.WriteLine("DIGITE VALOR DE DESTINO VALIDO!");
                }

            }
            else if (origem == 'C' && topC != -1) {
                if (destino == 'B') {
                    if (topB == -1||torreC[topC] < torreB[topB]) {
                        PUSH_POP(origem, destino);
                    }
                    else {
                        Console.WriteLine("ATENÇÃO, VALOR DE ORIGEM TEM QUE SER MENOR QUE DESTINO!");
                    }
                }
                else if (destino == 'A') {
                    if (topA == -1||torreC[topC] < torreA[topA]) {
                        PUSH_POP(origem, destino);
                    }
                    else {
                        Console.WriteLine("ATENÇÃO, VALOR DE ORIGEM TEM QUE SER MENOR QUE DESTINO!");
                    }
                }
                else {
                    Console.WriteLine("DIGITE VALOR DE DESTINO VALIDO!");
                }
            }
            else {
                Console.WriteLine("DIGITE VALOR DE DESTINO VALIDO!");
            }
        }//Validações das torres

        public bool verificaEnd() {
            if (topC == tam - 1)
                return true;
            return false;
        } //Verifica se concluiu a Torre

        public void printTorres() {

            Console.WriteLine("TORRES: \n");
            for (int i = tam - 1; i >= 0; i--) {
                Console.Write($"\n  {torreA[i]}\t");
                Console.Write($"  {torreB[i]}\t");
                Console.Write($"  {torreC[i]}\t\n");

            }
            Console.WriteLine("TORRE A\tTORRE B\tTORRE C\n\n");
        }  //Imprime torres




    }
}
