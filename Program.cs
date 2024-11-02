using System;

namespace MatricesSaadatian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int count = 0;
            Console.WriteLine("Please, enter number of rows for the matris No. 1:");
            int rowMatris1 = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Please, enter number of columns for the matris No. 1:");
            int columnMatris1 = int.Parse(Console.ReadLine() ?? "");
            int [ , ] matris1 = new int[rowMatris1, columnMatris1];
            Console.WriteLine("Please, enter elements of the matris No. 1:");
            for (int i = 0; i < rowMatris1; i++)
            {
                for (int j = 0; j < columnMatris1; j++)
                {
                        try
                        {
                            matris1[i, j] = int.Parse(Console.ReadLine() ?? "");
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Sorry, element is invalid. Try again!");
                            Console.ResetColor();
                            j = j - 1;
                        }
                }
            }
            
            Console.WriteLine("Please, enter number of rows for the matris No. 2:");
            int rowMatris2 = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Please, enter number of columns for the matris No. 2:");
            int columnMatris2 = int.Parse(Console.ReadLine() ?? "");
            int[,] matris2 = new int[rowMatris2, columnMatris2];
            Console.WriteLine("Please, enter elements of the matris No. 2:");
            for (int i = 0; i < rowMatris2; i++)
            {
                for (int j = 0; j < columnMatris2; j++)
                {
                    try
                    {
                        matris2[i, j] = int.Parse(Console.ReadLine() ?? "");
                        
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Sorry, element is invalid. Try again!");
                        Console.ResetColor();
                        j = j - 1;

                    }
                }
            }
            // Two matrix summation
            Matrices.SumMatris(rowMatris1 , columnMatris1, rowMatris2, columnMatris2 , matris1, matris2);

            //Two matrix multiplication
            Matrices.MultiMatris(rowMatris1, columnMatris1, rowMatris2, columnMatris2, matris1, matris2);


        }
    }
}
