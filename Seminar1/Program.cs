//Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Введите первое натуральное число ");
// int a=Convert.ToInt32 ( Console.ReadLine());
// Console.WriteLine("Введите второе натуральное число ");
// int b=Convert.ToInt32 ( Console.ReadLine());
// int max = a;
// if (a > max) max = a;
// else max = b;
// Console.Write("max = ");
// Console.WriteLine(max);

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите первое натуральное число ");
// int a=Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите второе натуральное число ");
// int b=Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите третье натуральное число ");
// int c=Convert.ToInt32 (Console.ReadLine());
// int max = a;
// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// Console.Write(" ");
// Console.WriteLine(max);

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите натуральное число ");
// int num=Convert.ToInt32 (Console.ReadLine());
// int i=num % 2;
// if (i == 0) Console.WriteLine("yes");
// else Console.WriteLine("no");

// 4 -> да
// -3 -> нет
// 7 -> нет

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Введите натуральное число ");
// int N = int.Parse(Console.ReadLine());

// for (int i = 1; i <= N; i++)
//     if (i % 2 == 0)
//         Console.Write(i+",");

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
