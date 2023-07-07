/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
      
      Console.WriteLine("Bведите число от 2 до 10: ");
      int size = Convert.ToInt32(Console.ReadLine());
      if(size < 2 || size > 10) {
      Console.WriteLine("Bведено неверное число!");       
      } 
      else {
         
      int [,] numbers1 = new int [size,size];
      int [,] numbers2 = new int [size,size];      
      Console.WriteLine("Первая матрица: ");     
      FillMatrix(numbers1);
      PrintMatrix(numbers1);
      Console.WriteLine("Вторая матрица: ");
      FillMatrix(numbers2);    
      PrintMatrix(numbers2);  
      Console.WriteLine("Полученная матрица: ");      
      MatrixProduct(numbers1, numbers2);
 
      }  

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
    public static void MatrixProduct(int[,] matrix1, int[,] matrix2)
    {
        int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        PrintMatrix(result);

    }
	}
}

