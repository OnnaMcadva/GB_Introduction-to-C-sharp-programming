/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
      FillMatrix(numbers);
      PrintMatrix(numbers);
      MinSumLines(numbers);
      
		}

    public static void FillMatrix(int[,] matrix)
    {
        int lines = matrix.GetLength(0); 
        int columns = matrix.GetLength(1); 
          for (int i = 0; i < lines; i++) {
            for (int j = 0; j < columns; j++) {
            matrix[i, j] = new Random().Next(-10, 10);
            }
        }
    }
		public static void PrintMatrix(int[,] matrix)
    {
        int lines = matrix.GetLength(0); 
        int columns = matrix.GetLength(1); 
         for (int i = 0; i < lines; i++) 
        {
            for (int j = 0; j < columns; j++) 
            {
                Console.Write(matrix[i, j] + " "); 
            }
            Console.WriteLine(); 
        }
    }
    public static void MinSumLines(int[,] matrix)
    {
          int minSum = int.MaxValue;
          int minSumLineIndex = -1;
           for (int i = 0; i < matrix.GetLength(0); i++) {
            int sum = 0;
              for (int j = 0; j < matrix.GetLength(1); j++) {
                sum += matrix[i, j];
            }
             if (sum < minSum)
            {
                minSum = sum;
                minSumLineIndex = i;
            }
        }

        Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (minSumLineIndex + 1) + " строка");
    }
	}
}

