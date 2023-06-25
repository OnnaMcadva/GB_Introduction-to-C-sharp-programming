/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  		public static void Lottery(int number) {
	  		     double [] numbers = new double[number]; 
	  		 double min = Int32.MaxValue;
         double max = Int32.MinValue; 
         Console.Write("[");	  		     
      for (int i = 0; i < number-1; i++)
      {
         numbers [i] = Convert.ToDouble(new Random().Next(-1000,1000)) / 100;
        
          Console.Write(numbers [i] + ", ");
              if (numbers[i] > max) {max = numbers[i];}
              if (numbers[i] < min) {min = numbers[i];}
        }	  
         numbers [number-1] = Convert.ToDouble(new Random().Next(-1000,1000)) / 100;
              if (numbers[number-1] > max) {max = numbers[number-1];}
              if (numbers[number-1] < min) {min = numbers[number-1];}
        
      Console.Write(numbers [number-1] + "] => " + max + " - (" + min + ") = "  + (max - min));
     
	  }
	  
		public static void Main(string[] args)
		{
    Console.Write("Задайте количество чисел в массиве: ");
    int yourNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Pазницa между максимальным и минимальным элементами массива: ");
    Lottery(yourNumber);
		}
	}
}