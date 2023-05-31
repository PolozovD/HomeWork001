// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int Prompt (string message)
// {
//     Console.WriteLine(message);
//     string value = Console.ReadLine();
//     int result = Math.Abs(Convert.ToInt32(value));
//     return result;
// }

// int[] CreateUserArray (int size)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write("Input number: ");
//         newArray[i] = Convert.ToInt32(Console.ReadLine()); 
//     }
//     return newArray;
// }

// void PrintArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
// }

// int CountPosNum (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     return count;
// }

// int size = Prompt("Input the number M of numbers you want to enter next: ");

// int[] myArray = CreateUserArray(size);
// PrintArray(myArray);

// Console.WriteLine();
// Console.WriteLine($"The number of positive numbers entered by the user -> {CountPosNum(myArray)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.



