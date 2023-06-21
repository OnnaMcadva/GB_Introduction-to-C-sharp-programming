/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  		public static void Lottery(int number) {
	  		     int [] numbers = new int[number]; 
         Console.Write("[");	  		     
      for (int i = 0; i < number-1; i++)
      {
         numbers [i] = new Random().Next(1, 71);

          Console.Write(numbers [i] + ", ");
        }	  
         numbers [number-1] = new Random().Next(71, 100);
      Console.Write(numbers [number-1] + "]");
	  }
		  
		public static void Main(string[] args)
		{

    Console.Write("Счастливые номера для игры в лотерею: ");
    Lottery(8);

	  }			

		}
	}
