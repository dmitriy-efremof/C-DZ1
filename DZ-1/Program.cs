﻿// ______________Задание 2

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.Write("max = ");
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.Write("max = ");
//     Console.WriteLine(num2);
// }

// ______________Задание 4

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if ((num1 > num2) && (num1 > num3))
// {
//     Console.Write("Max = ");
//     Console.WriteLine(num1); 
// }
// else if ((num2 > num1) && (num2 > num3))
// {
//    Console.Write("Max = ");
//     Console.WriteLine(num2); 
// }
// else if ((num3 > num1) && (num3 > num2))
// {
//     Console.Write("Max = ");
//     Console.WriteLine(num3);
// }
 
// ______________Задание 6

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num%2 == 0)
// {
//     Console.WriteLine("Число чётное");
// }
// else
// {
//     Console.WriteLine("Число не чётное");
// }

// ______________Задание 8

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int num2 = 1;

// while (num2 <= num)
// {
//     if (num2%2 == 0)
//     {
//         Console.Write("Чётные числа=");
//         Console.Write(num2 + ", ");
//     }
//     num2=num2+1;
// }
