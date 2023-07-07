/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

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
      
      Console.WriteLine("Заданный массив: ");
      int[,] numbers = {
        {4, -4, 7, 128},
        {216, 102, -45, 57},
        {65, 76, -56, 0}      };
        
      PrintMatrix(numbers);

      Console.WriteLine("Отсортированный по убыванию в строках массив: ");

      SortLines(numbers);
      PrintMatrix(numbers);      
      
      

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

     static void SortLines(int[,] matrix)
    {
        int lines = matrix.GetLength(0); 
        int columns = matrix.GetLength(1); 
         for (int i = 0; i < lines; i++) 
        {
            for (int j = 0; j < columns - 1; j++)
            {
                for (int k = 0; k < columns - j - 1; k++) 
                {
                    if (matrix[i, k] < matrix[i, k + 1])
                    {
                        int temp = matrix[i, k]; 
                        matrix[i, k] = matrix[i, k + 1]; 
                        matrix[i, k + 1] = temp; 
                    }
                }
            }
        }
    }

	}
}

