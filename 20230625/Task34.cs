/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

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
	  		     int count = 0;
         Console.Write("[");	  		     
      for (int i = 0; i < number-1; i++)
      {
         numbers [i] = new Random().Next(100, 1000);
          if (numbers [i] % 2 == 0) {count = count +1;}
          Console.Write(numbers [i] + ", ");
        }	  
         numbers [number-1] = new Random().Next(100, 1000);
         if (numbers [number-1] % 2 == 0) {count = count +1;}
      Console.Write(numbers [number-1] + "]");
      Console.Write(" -> " + count);
	  }
	  
		public static void Main(string[] args)
		{
    Console.Write("Задайте количество трехзначных чисел в массиве: ");
    int yourNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ваш массив и количество четных чисел в нем: ");
    Lottery(yourNumber);
		}
	}
}