// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в 
// промежутке от M до N. Использовать рекурсию, 
// не использовать циклы.


// Console.Write("Введите значение M:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N:");
// int n = Convert.ToInt32(Console.ReadLine());
// void che (int m, int n)
// {
//     if (m > n)
//     return;
//     if (m %2 == 0)
//     {
//         Console.Write($"{m},");
//     }
//     che(m + 1, n);
// }
// che(m, n);


// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных 
// числа m и n.


// using System.Security.Cryptography.X509Certificates;

// Console.Write("Введите значение M:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N:");
// int n = Convert.ToInt32(Console.ReadLine());

// int akkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if(n == 0) return akkerman(m - 1, 1);
//     else return akkerman(m -1, akkerman(m, n - 1));
// }
// Console.Write($"Функция Аккермана равна {akkerman(m, n)}");


// Задайте произвольный массив. Выведете его 
// элементы, начиная с конца. Использовать 
// рекурсию, не использовать циклы.

// using System;

// class Program 
// {
//     static void Main() 
//     {   
//         int[] array = { 1, 2, 5, 0, 10, 34 };

        
//         PrintArrayReverse(array, array.Length - 1);
//     }

//     static void PrintArrayReverse(int[] array, int index) 
//     {
//         if (index < 0) 
//         {
//         return;
//         }

        
//         Console.WriteLine(array[index]);

        
//         PrintArrayReverse(array, index - 1);
//     }
// }

