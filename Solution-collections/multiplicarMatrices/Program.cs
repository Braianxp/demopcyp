using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicarMatrices
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz1 = new int[2, 3] { { 1, 2,-3 },{ 4,0,-2} };
            int[,] matriz2 = new int[3, 2] { { 3 ,1}, { 2,4},{ -1,5} };
            
            int total = 0;

            if (Verificar(matriz1, matriz2))
            {
                int[,] matrizfinal = new int[matriz1.GetLength(0), matriz2.GetLength(1)];

                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz2.GetLength(1); j++)
                    {
                        for (int k = 0; k < matriz1.GetLength(1); k++)
                        {
                            total += matriz1[i, k] * matriz2[k, j];
                        }
                        matrizfinal[i, j] = total;
                        total = 0;
                    }

                }

                Console.WriteLine("Matriz final");
                string t = "";
                for (int i = 0; i < matrizfinal.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizfinal.GetLength(1); j++)
                    {
                        t = t + (matrizfinal[i, j].ToString());
                    }
                    Console.WriteLine("[" + t + "]\n");
                    t = "";

                }
                
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Imposible multiplicar estas dos matrices");
                Console.ReadLine();
            }
        }
    

        public static Boolean Verificar(int[,] matriz1, int[,]matriz2)
        {
            return matriz1.GetLength(1) == matriz2.GetLength(0);
        }
    }
}
