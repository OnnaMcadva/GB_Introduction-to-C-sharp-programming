/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */



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

			Console.WriteLine("Введите количество чисел: ");
			int length = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите числа через пробел: ");
          int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
          int counter = 0;
          for (int i = 0; i < length; i++) {
              if (numbers[i] > 0) {
              counter++;
              //Console.WriteLine(numbers[i]);
              }
          }
      Console.WriteLine($"Среди введенных чисел количество значений больше нуля = {counter}");
		}
	
	}	

}