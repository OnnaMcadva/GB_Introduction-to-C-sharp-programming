/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
Слово тоже можно ввести))) */



using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите пятизначное число: ");
        string numbFiveDig = Console.ReadLine();
        int arrlength = numbFiveDig.Length;

        if (arrlength == 5)
        {
            if (numbFiveDig[0] == numbFiveDig[4] && numbFiveDig[1] == numbFiveDig[3])
            {
                Console.WriteLine(numbFiveDig + " да");
            }

            else
            {
                Console.WriteLine(numbFiveDig + " нет");
            }
        }
        else
        {
            Console.WriteLine("Введеное число не является пятизначным");
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}