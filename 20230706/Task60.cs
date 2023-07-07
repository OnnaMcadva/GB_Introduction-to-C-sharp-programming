/* Задача 60. ...Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

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
         
      int [,,] numbers = new int [size,size,size];

      Console.WriteLine("Готовая матрица с координатами: ");     
      FillMatrix(numbers);
      PrintMatrix(numbers);

 
      }  

		}

    public static void FillMatrix(int[,,] matrix)
    {
        int d1 = matrix.GetLength(0); 
        int d2 = matrix.GetLength(1); 
        int d3 = matrix.GetLength(2); 
          for (int i = 0; i < d1; i++) {
            for (int j = 0; j < d2; j++) {
              for (int k = 0; k < d3; k++) {
            matrix[i,j,k] = new Random().Next(10, 100);
              }
            }
        }
    }
		public static void PrintMatrix(int[,,] matrix)
    {
        int d1 = matrix.GetLength(0); 
        int d2 = matrix.GetLength(1); 
        int d3 = matrix.GetLength(2); 

          for (int i = 0; i < d1; i++) {
            for (int j = 0; j < d2; j++) {
              for (int k = 0; k < d3; k++) {
                Console.Write(matrix[i,j,k] + "(" + i + "," + j + "," + k + ") "); 
            }
            Console.WriteLine(); 
        }
    }


    }
	}
}

