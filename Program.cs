﻿/* Задача 4: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Clear ();
Console.WriteLine (" Введите три числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max;

    if (a>b||a>c) 
    { 
    max = a;
    Console.Clear ();
    Console.Write (max);
    }

    if (b>a||b>c) 
    { 
    max = b;
    Console.Clear ();
    Console.Write (max);
    }

    if (c>b||c>a) 
    { 
    max = c;
    Console.Clear ();
    Console.Write (max);
    }