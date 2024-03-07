Console.Clear();
Console.WriteLine("Sem4, Functions Homework");
Console.WriteLine("");

//=========================================================================== Task 1
//  Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//  Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// bool check = true;
// while (check == true)
// {
//     Console.WriteLine("Add the integer number or `Q` to stop the programm and press ENTER");
//     string input = Console.ReadLine();
//     if (input == "q")
//     {
//         check = false;
//         Console.WriteLine("[STOP]             YOU ENTERED THE Q             [STOP]");
//     }
//     else if (input == "Q")
//     {
//         check = false;
//         Console.WriteLine("[STOP]             YOU ENTERED THE Q             [STOP]");

//     }
//     else
//     {
//         int number = Convert.ToInt32(input);
//         int sum = 0;
//         while (number > 0)
//         {
//             sum = sum + number % 10;
//             number = number / 10;
//         }
//         if (sum % 2 == 0)
//         {
//             check = false;
//             Console.WriteLine("[STOP]             THE SUM IS EVEN             [STOP]");
//         }
//     }
// }

//=========================================================================== Task 1


//=========================================================================== Task 2
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// System.Console.WriteLine("Введите число");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[size];

// void FillingArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]}\t");
//     }
//     System.Console.WriteLine();
// }

// int GetNumber()
// {
//     int num = 0;

//     for (int i = 0; i < array.Length; i++)
//     {

//         if (array[i] % 2 == 0)
//         {
//             num = num + 1;
//         }
//     }
//     return Convert.ToInt32(num);
// }

// FillingArray();
// PrintArray();
// System.Console.WriteLine(GetNumber());

//=========================================================================== Task 2



//=========================================================================== Task 3
// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

// System.Console.WriteLine("Введите число");
// int size = Convert.ToInt32(Console.ReadLine());


// int[] array = new int[size];
// int[] array2 = new int[size];

// void FillingArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]}\t");
//     }
//     System.Console.WriteLine();
// }
// void PrintArray2()
// {
//     for (int i = 0; i < array2.Length; i++)
//     {
//         System.Console.Write($"{array2[i]}\t");
//     }
//     System.Console.WriteLine();
// }

// void Recombination() //при помощи создания массива 2
// {
//     for (int i = 0; i < array.Length; i++)
//     { 
//         array2[i] = array[size - i - 1];
//     }
    
// }
// void Recombination2()
// {
//     int safe01 = 0;

//     for (int i = 0; i < array.Length/2; i++)
//     {
//         safe01 = array[i];
//         array[i] = array[size - i - 1];
//         array[size - i - 1] = safe01;
//         //Console.Write($"{array2[i]}\t");
//     }
    
// }

// FillingArray();
// PrintArray();
// //Recombination();
// Recombination2();
// PrintArray();

//=========================================================================== Task 3
