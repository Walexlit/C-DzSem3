// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("введите пятизначное число");
// int numberA = Convert.ToInt32(Console.ReadLine());
// string str = Convert.ToString(numberA);
// int f = 0;
// if (numberA < 10000 | numberA > 99999)
// {
//     Console.WriteLine("Ошибка, введите пятизначное число");
// }
// else
// {
//     for (int i = 0; i < 2; i++)
//     {
//         if (str.Substring(i, 1) != str.Substring(4 - i, 1))
//         {
//             f = 1;
//             break;
//         }
//     }
//     if (f == 0)
//     {
//         Console.WriteLine("полендром");
//     }
//     else
//     {
//         Console.WriteLine("не полендром");
//     }
// }








// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.WriteLine("введите координаты первой точки по оси X");
// int numberX1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите координаты первой точки по оси Y");
// int numberY1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите координаты второй точки по оси X");
// int numberX2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите координаты второй точки по оси Y");
// int numberY2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите координаты первой точки по оси Z");
// int numberZ1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите координаты второй точки по оси Z");
// int numberZ2 = Convert.ToInt32(Console.ReadLine());


// double sum = Math.Sqrt((numberX2 - numberX1) * (numberX2 - numberX1) + (numberY2 - numberY1) * (numberY2 - numberY1) + (numberZ2 - numberZ1) * (numberZ2 - numberZ1)); 
// {
//     Console.WriteLine($"отрезок длинной {sum}");
// }






// // Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.WriteLine("введите число");
// int numberA = Convert.ToInt32(Console.ReadLine());
// int numberB = Convert.ToInt32(1);
// while (numberB<=numberA)
// {
//  Console.WriteLine ($"{numberB}:{(Math.Pow (numberB,3))}");
// numberB++;
// }
