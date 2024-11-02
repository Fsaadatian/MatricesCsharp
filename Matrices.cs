using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesSaadatian
{
    internal class Matrices
    {
        public static void SumMatris(int rowMatris1, int columnMatris1, int rowMatris2, int columnMatris2, int[,] matris1, int[,] matris2)
        {
            if (rowMatris1 != rowMatris2 || columnMatris1 != columnMatris2)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Sorry, these two matrices are not the same size to sum.");
                Console.ResetColor();
            }
            else
            {
                int[,] sumMatris = new int[rowMatris1,columnMatris1];
                for (int i = 0; i < rowMatris1; i++)
                {
                    for (int j = 0; j < columnMatris1; j++)
                    {
                        sumMatris[i,j] = matris1[i,j] + matris2[i, j];

                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Sum of the two matrices is:");
                ShowResult(sumMatris, rowMatris1, columnMatris1);
            }
        }
        public static void MultiMatris(int rowMatris1, int columnMatris1, int rowMatris2, int columnMatris2, int[,] matris1, int[,] matris2)
        {
            if (columnMatris1 != rowMatris2)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Sorry, these two matrices have not the suitable size to multiply.");
                Console.ResetColor();
            }
            else
            {
                int[,] multiMatris = new int[rowMatris1, columnMatris2];
                for (int i = 0; i < rowMatris1; i++)
                {
                    for (int j = 0; j < columnMatris2; j++)
                    {
                        for (int k = 0; k < columnMatris1; k++)
                        {
                            multiMatris[i, j] += matris1[i, k] * matris2[k, j];
                        }
                        

                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Multiplication of the two matrices is a matris{rowMatris1}*{columnMatris2} :");
                ShowResult(multiMatris, rowMatris1, columnMatris2);
                
            }
        }
        private static void ShowResult(int[,] matris, int rowMatris, int columnMatris)
        {
            Console.ResetColor();
            for (int i = 0; i < rowMatris; i++)
            {
                for (int j = 0; j < columnMatris; j++)
                {
                    Console.Write($"{matris[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
