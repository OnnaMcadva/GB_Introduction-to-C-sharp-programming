/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */



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
      Console.WriteLine("Результат: " + Akkerman(firstNum,secondNum));
      
		}
		
    public static int Akkerman(int m, int n)
    {
      if (m == 0) {
          return n + 1;
     }
      else if (n == 0 && m > 0) {
         return Akkerman(m - 1, 1);
     }
     else {
         return (Akkerman(m - 1, Akkerman(m, n - 1)));
     }
    }
		}
	}