using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tablice dwuwymiarowe
            //int[,] ints = new int[4, 3];
            //Console.WriteLine(ints.Rank);//podaje ilu wymiarowa tablica
            //Console.WriteLine(ints.GetLength(0));//podaje dlugosc tablicy na pierwszym wymiarze
            //Console.WriteLine(ints.GetLength(1));//podaje dlugosc tablicy na drugim wymiarze

            //for(int i=0; i<ints.GetLength(0); i++)
            //{
            //    for(int j=0; j < ints.GetLength(1); j++)
            //    {
            //        Console.Write($"ints[{i},{j}]={ints[i,j]}  ");
            //    }
            //    Console.WriteLine();
            //}

            int[,,] cubs = new int[4, 3, 2];
            for (int i = 0; i < cubs.GetLength(0); i++)
            {
                for (int j = 0; j < cubs.GetLength(1); j++)
                {
                    for(int k = 0; k<cubs.GetLength(2); k++)
                    {
                        Console.Write($"cubs[{i},{j},{k}]={cubs[i, j, k]}  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
