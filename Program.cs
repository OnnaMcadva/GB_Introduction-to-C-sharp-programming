/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

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
    System.Console.WriteLine("Введите координаты первой точки через пробел:");
    int[] coordA = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    System.Console.WriteLine("Введите координаты второй точки через пробел:");
    int[] coordB = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    System.Console.WriteLine("Расстояние между точками: " 
    + Math.Round(Math.Sqrt(Math.Pow(coordA[0]-coordB[0], 2) 
    + Math.Pow(coordA[1]-coordB[1], 2) 
    + Math.Pow(coordA[2]-coordB[2], 2)), 2));
    }
  }
}