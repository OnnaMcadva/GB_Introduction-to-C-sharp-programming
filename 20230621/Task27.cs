/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  		public static int Sum(int number) {
		    int result = 0;
		    while (number > 0) {
		      result += number % 10;
		      number = number / 10;
		    }
		    return result;
		  }
		  
		public static void Main(string[] args)
		{

		  
		  Console.Write("Введите положительное число: ");
		  int num = Convert.ToInt32(Console.ReadLine());
		  if (num < 0) {
		  Console.WriteLine("Вы ввели отрицательное число");  
		  }
		  else {
		  int result = Sum(num);
		  Console.WriteLine("Сумма цифр в числе равна: " + result);
		  }			

		}
	}
}