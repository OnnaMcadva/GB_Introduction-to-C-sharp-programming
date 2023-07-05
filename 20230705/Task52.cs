/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
      
      Console.WriteLine("Bведите количество строк: ");
      int line = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Bведите количество столбцов: ");
      int column = Convert.ToInt32(Console.ReadLine());
      int [,] numbers = new int [line,column];

        for (int i = 0; i < line; i++) {
          for (int j = 0; j < column; j++) {
          numbers[i, j] = new Random().Next(-100, 100);
          }
        }
      PrintMatrix(numbers);
      
        for (int j = 0; j < numbers.GetLength(1); j++) {
        double avarage = 0;
            for (int i = 0; i < numbers.GetLength(0); i++) {
            avarage = (avarage + numbers[i, j]);
            }
        avarage = avarage / line;
        Console.Write(avarage + "; ");
        }
      Console.WriteLine();



		}

		public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++) {

          for (int j = 0; j < matrix.GetLength(1); j++) {
          Console.Write(matrix[i, j] + " ");
          }

        Console.WriteLine("");
       }
    }

	}
}