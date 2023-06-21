/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  		public static   int Exponentiation(int bas, int exp) {
		    int result = 1;
		    for(int i = 0; i < exp; i++) {
		      result *= bas;
		    }
		    return result;
		  }
		  
		public static void Main(string[] args)
		{

		  
		  Console.WriteLine("Введите целое число: ");
		  int bas = Convert.ToInt32(Console.ReadLine());
		  Console.WriteLine("Введите степень числа (целое число больше 0): ");
		  int exp = Convert.ToInt32(Console.ReadLine());		  
		  if (exp <= 0) {
		  Console.WriteLine("Степень числа должна быть больше 0");		    
		  }
		  else {
		  int result = Exponentiation(bas, exp);
		  Console.WriteLine("Результат возведения в степень: " + result);
		  }			

		}
	}
}