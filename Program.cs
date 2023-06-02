// Задача 19
// Напишите программу, которая 
// принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - ДА");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - Нет");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }


// Задача 21
// Напишите программу, которая 
// принимает на вход координаты 
// двух точек и находит расстояние 
// между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату X 1ой точки");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y 1ой точки");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z 1ой точки");
// int Z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату X 2ой точки");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y 2ой точки");
// int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z 2ой точки");
// int Z2 = Convert.ToInt32(Console.ReadLine());
// int A = X1 - X2;
// int B = Y1 - Y2;
// int C = Z2 - Z1;
// double length = Math.Sqrt(A * A + B * B + C * C);
// Console.WriteLine(length);


// Задача 23
// Напишите программу, которая 
// принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число N");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while (num >= count)
// {
//     Console.WriteLine(Math.Pow(count, 3));
//     count = count + 1;
// }

