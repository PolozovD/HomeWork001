﻿// Урок 1. Знакомство с языком программирования С#
// 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Enter first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine("The first number greater than the second");
// }
// if (num1 == num2)
// {
//     Console.WriteLine("The first number is exactly the second");
// }
// else Console.WriteLine("The second number greater than the first");


// 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Enter first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;

// if(num1 > max) max = num1;
// if(num2 > max) max = num2;
// if(num3 > max) max = num3;

// Console.WriteLine($"max = {max}");

// или

// Console.Write("max = ");
// Console.WriteLine(max);

// 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num % 2 == 0)
// {
//     Console.WriteLine("The number is even");
// }
// else Console.WriteLine("This is an odd number");

// 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());

int counter = 1;

while (counter <= N)
{   
    if (counter % 2 == 0)
    {
        Console.Write($"{counter}, ");
    }
    counter++;
}

