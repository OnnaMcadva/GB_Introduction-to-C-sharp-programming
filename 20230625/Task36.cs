/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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
	  		     int sum = 0;
         Console.Write("[");	  		     
      for (int i = 0; i < number-1; i++)
      {
         numbers [i] = new Random().Next(-100, 100);
          if (i % 2 == 1) {sum = sum + numbers[i];}
          Console.Write(numbers [i] + ", ");
        }	  
         numbers [number-1] = new Random().Next(-100, 100);
         if ((number-1) % 2 == 1) {sum = sum + numbers[number-1];}
      Console.Write(numbers [number-1] + "]");
      Console.Write(" -> " + sum);
	  }
	  
		public static void Main(string[] args)
		{
    Console.Write("Задайте количество чисел в массиве: ");
    int yourNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Cуммa элементов, стоящих на нечётных позициях: ");
    Lottery(yourNumber);
		}
	}
}