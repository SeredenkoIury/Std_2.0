Console.Clear();
Console.WriteLine("Seminar 01, connected with Lesson 1");
Console.WriteLine("");
// //=================================================================================================01
// // Напишите программу которая на вход принимает любое целое число, а на выходе выдает 
// // квадрат этого числа. 
// //   (число умноженное на само себя).
// // Например:
// // 4 -> 16 
// // -3 -> 9 
// // -7 -> 49

// // !! int number = Convert.ToInt32(Console.ReadLine());
// // Даже если человек напишет целое, нормальное 
// // число, программа автоматически воспринимает его как string - строчку, а нужно в нашем случае в инт
// // чтобы стринг преобразовать в инт чтобы потом работать с этим, нужно использовать Convert.ToInt32
// // почему 32. Интов бывает 16, 32 и 64 бита. значения различаются только обьемом которое можем
// // запихнуть в это число. По умолчанию принято использовать обычно 32 бита - int по умолчанию 32 битный

// Console.WriteLine("Program been started. Write a number you want to convert: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = number * number;

// Console.WriteLine(result);

// // ====================================================================================================01


// //=====================================================================================================02

// //Напишите программы, которая на вход берет 2 числа, и показывает, 
// //является ли первое число квадратом 2го числа.

// Console.WriteLine("Write the first number");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Write the second number");
// int number2 = Convert.ToInt32(Console.ReadLine());


// if(number1 == number2 * number2)
// {
//     Console.WriteLine("Yes, first is the second ^ 2");
// }
// else
// {
//     Console.WriteLine("No, first is not the second ^ 2");
// }
//=====================================================================================================02


// //=====================================================================================================03
// //Написать программу, которая по номеру дня недели будет выдавать этот день недели.

// Console.WriteLine("Add the number from 1 to 7");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number == 1)
// { 
// Console.WriteLine("Monday");
// }
// else if(number == 2)
// { 
// Console.WriteLine("Tuesday");
// }
// else if(number == 3)
// { 
// Console.WriteLine("Wednesday");
// }
// else if(number == 4)
// { 
// Console.WriteLine("Thursday");
// }
// else if(number == 5)
// { 
// Console.WriteLine("Friday");
// }
// else if(number == 6)
// { 
// Console.WriteLine("Saturday");
// }
// else if(number == 7)
// { 
// Console.WriteLine("Sunday");
// }
// else 
// { 
// Console.WriteLine("There is no day of your number");
// }

// //=====================================================================================================03


// //======================================================================================================04
// //Напишите программу которая на вход примнимает число, а на выходе
// //показывает все целые числа от - до + 

// Console.WriteLine("write a number");
// int num1 = Convert.ToInt32(Console.ReadLine());

// int negNum = num1 * -1;

// while (negNum <= num1)
// {
//     Console.Write(negNum + " | ");

//     negNum = negNum + 1;
// }
// //======================================================================================================05

//======================================================================================================06
// Напишите программу которая на ввод принимает трехзначное число, 
// а программа должна выдавать последнюю цифру от числа
// пример - 345 -> 5

// ! int result = num %10;
// если любое число поделить на 10, мы получим в виде остатка его последнюю цифру


Console.WriteLine("write a number");
int num = Convert.ToInt32(Console.ReadLine());

int result = num %10;
Console.WriteLine(result);