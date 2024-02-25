Console.Clear();
Console.WriteLine("Seminar 02, Homework");
Console.WriteLine("");

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

Console.WriteLine("Add the number between 10 and 99 ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >=100 || number < 10)
{
    Console.WriteLine("The number is incorrect");
}
else
{
int a = number/10;
int b = number%10;

    if (a > b)
    {
         Console.WriteLine("The first figure " + a + " is more than the second figure " + b);
    }
    else if (a < b)
    {
         Console.WriteLine("The second figure " + b + " is more than the first figure " + a);
    }
    else
    {
        Console.WriteLine("The first figure " + a + " and the second figure " + b + " are equal");
    }

}



//=================================================================== Task 03

//=================================================================== Task 04
// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.
//=================================================================== Task 04