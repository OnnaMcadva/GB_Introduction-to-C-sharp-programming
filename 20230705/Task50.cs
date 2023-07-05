/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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
      Console.WriteLine("Я загадаю массив, а ты попробуешь угадать, есть ли число на заданном тобой месте :) ");
      Console.WriteLine("Bведи номер строки: ");
      int line = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Bведи номер столбца: ");
      int column = Convert.ToInt32(Console.ReadLine());
      int [,] numbers = new int [7,7];

        for (int i = 0; i < 7; i++) {
          for (int j = 0; j < 7; j++) {
          numbers[i, j] = new Random().Next(-100, 100);
          }
        }
      PrintMatrix(numbers);
      
      if (line > numbers.GetLength(0) || column > numbers.GetLength(1)) {
      Console.WriteLine("Не повезло - такого элемента в массиве нет :(");
      }
      else {
      Console.WriteLine($"Бинго! Значение элемента {line} строки и {column} столбца равно {numbers[line-1,column-1]}");
      }

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