Console.Clear();
Console.WriteLine("Seminar 02, Homework");
Console.WriteLine("");

//=============================================================================== Задания с сайта GB

//=================================================================== Task 01
// Задача 1: Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23

// Console.WriteLine("Add the number and press Enter");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine("Yes, The number is a multiple of 7 and 23");
// }
// else if (number % 7 == 0)
// {
//     Console.WriteLine("No, The number is a multiple of 7, but not of the 23");
// }
// else if (number % 23 == 0)
// {
//     Console.WriteLine("No, The number is a multiple of 23, but not of the 7");
// }
// else
// {
//     Console.WriteLine("No, The number is not a multiple of 7 or 23 at all");
// }
// 
//=================================================================== Task 01

//=================================================================== Task 02
// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

// Console.WriteLine("Add the number of X where X is not equel 0");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Add the number of Y where Y is not equel 0");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("The coordinate quarter I");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("The coordinate quarter IV");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("The coordinate quarter III");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("The coordinate quarter II");
// }
// if (x == 0 || y == 0)
// {
//     Console.WriteLine("The number is incorrect");
// }
//
//=================================================================== Task 02

//=================================================================== Task 03
// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

// Console.WriteLine("Add the number between 10 and 99 ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 100 || number < 10)
// {
//     Console.WriteLine("The number is incorrect");
// }
// else
// {
//     int a = number / 10;
//     int b = number % 10;

//     if (a > b)
//     {
//         Console.WriteLine("The first figure " + a + " is more than the second figure " + b);
//     }
//     else if (a < b)
//     {
//         Console.WriteLine("The second figure " + b + " is more than the first figure " + a);
//     }
//     else
//     {
//         Console.WriteLine("The first figure " + a + " and the second figure " + b + " are equal");
//     }

// }
//=================================================================== Task 03

//=================================================================== Task 04
// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.
//===============

    // Console.WriteLine("Add the natural number");
    // int number = Convert.ToInt32(Console.ReadLine());

    // if (number < 10 && number > 0)
    // {
    //     Console.WriteLine("Your number " + number + " is less than 2 figures");
    // }
    // else if (number < 1)
    // {
    //     Console.WriteLine("Your number is not natural");
    // }
    // else 
    // {
    //     while (number > 0)
    //     {
    //         int n = number % 10;
    //         //Console.WriteLine(n);
    //         number = number / 10;
    //         Console.Write (n + ", ");
    //     }
    // }

//=================================================================== Task 04


//=============================================================================== Задания с Семинара

//=================================================================== Task 01
// Напишите программу, которая принимает на вход трехзначное число,
//  и на выходе показывает вторую цифру этого числа.
//  Console.WriteLine("Add the number between 100 and 999");
//  int number = Convert.ToInt32(Console.ReadLine());
//  if (number > 99 && number < 1000)
//  {
//     number = number/10;
//     number = number%10;
//     Console.WriteLine(number);
//  }
//  else
//  {
//    Console.WriteLine("The number is incorrect");
//  }

//=================================================================== Task 01

//=================================================================== Task 02
// Напишите программу, которая принимает число и выводит третью цифру заданного числа, 
// либо сообщает что третьей цифры нету

//  Console.WriteLine("Add the number between 10 and 10000");
//  int number = Convert.ToInt32(Console.ReadLine());
//  if (number > 999 && number < 10000)
//  {
//     number = number/10;
//     number = number%10;
//     Console.WriteLine("Thurd number is " + number);
//  }
//  else if (number > 99 && number < 1000)
//  {
//     number = number%10;
//     Console.WriteLine("Thurd number is " + number);
//  }
//  else if (number > 9 && number < 100)
//  {
//     Console.WriteLine("There is no third figure");
//  }
//  else
//  {
//    Console.WriteLine("The number is incorrect");
//  }

// //=================================================================== Task 02
// //=================================================================== Task 03

// // Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// // и проверяет является ли этот день выходным
// Console.WriteLine("Add the day number of the week");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day > 0 && day < 6)
// {
//     Console.WriteLine("This is a work day");
// }
// else if ( day > 5 && day < 8)
// {
//     Console.WriteLine("This is a weekend");
// }
// else
// {
//     Console.WriteLine("This is not a week day");
// }

// //=================================================================== Task 03



