/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */



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
      Console.WriteLine("Bведите первое число: ");
      int firstNum = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Bведите второе число: ");
      int secondNum = Convert.ToInt32(Console.ReadLine());
      Sum(firstNum,secondNum);
      
		}
		
		public static void Sum (int m, int n)
		{
      int sum = 0;
      if (m <= n) {
        while (m <= n) {
          sum = sum + m;
          m = m + 1;
        }
      } else {
        while (n <= m) {
          sum = sum + n;
          n = n + 1;
        }
      }
      Console.WriteLine("Сумма целых элементов в промежутке между числами равна: " + sum);      
    } 
		}
	}