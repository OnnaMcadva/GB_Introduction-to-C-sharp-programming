/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

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
      System.Console.WriteLine("Введите натуральное число: ");
      int natNum = Convert.ToInt32(Console.ReadLine());
      int index = 1;
      
      if(natNum <= 1) {
      System.Console.WriteLine("Вы ввели ненатуральное число");
      } 
      else {

      while (index <= natNum)
      {
         System.Console.Write(Math.Pow(index , 3) + " ");
         index++;
       }
    }
  }
}
}