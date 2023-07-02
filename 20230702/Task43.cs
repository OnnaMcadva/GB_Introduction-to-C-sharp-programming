/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */



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

    System.Console.WriteLine("Введите параметры первой первой прямой через пробел:");
    double[] paramA = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

    System.Console.WriteLine("Введите параметры первой второй прямой через пробел:");
    double[] paramB = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

       if (paramA[0] == paramB[0])  {
            if (paramA[1] == paramB[1])
            {
                Console.WriteLine("Прямые совпадают");
            }

            else {
                Console.WriteLine("Прямые параллельны");
            }
        }
        else {
           if (paramA[1] == paramB[1])
            {
                Console.WriteLine("Прямые пересекатются в точке (0;" + paramA[1] + ")");
            }
            else {
          double firstCoord = (paramA[1] - paramB[1]) / (paramB[0] - paramA[0]);
          double secondCoord = paramA[0] * firstCoord + paramA[1];
            Console.WriteLine("Прямые пересекатются в точке (" + firstCoord + ";" + secondCoord + ")");
        }
        }

		}
	
	}	

}