Console.Clear();
Console.WriteLine("Seminar 7, Recoursion");
Console.WriteLine("");

//================================= theory
// void OpenMatryoshka(int size)
// {
//     Console.WriteLine($"Opening matryoshka of size {size} ...");

//     if (size == 1)
//     {
//         Console.WriteLine("Reached the smallest matryoshka!");
//         return;
//     }
//     OpenMatryoshka(size - 1);
// }
// OpenMatryoshka(1000);
//=========================================

// void PrintStr()
// {
//     Console.WriteLine("hello");
//     PrintStr();
// }

// PrintStr();
//=========================================================================== TASK 01
// // Задание 01(02) - Задать значение Н , написать
// // программу для вывода всех натуральных чисел до Н.

// //=========================== FUNCTIONS =======================
// int Readint(string msg) // write and read function
// {
//     Console.WriteLine(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void PrintNumbers (int N)
// {
//     if (N < 1 ) return; // EMERGENCY RECURSION STOP
//     PrintNumbers(N-1); // сначала уменьшаем фактически до нуля, 
//     Console.Write(N + " "); //  а уже после вывод 
// }
// //============================== MAIN ========================

// int number = Readint("Введите число");
// PrintNumbers(number);

//=========================================================================== TASK 01

//=========================================================================== TASK 02
// // Напишите программу которая на вход принимает число,
// //  а на выход дает сумму цифр в числе.

// //=========================== FUNCTIONS =======================
// int Readint(string msg) // write and read function
// {
//     Console.WriteLine(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int SumDigitsInNumber(int N)
// {
//     if (N < 1 ) return 0; // EMERGENCY RECURSION STOP
//     return N % 10 + SumDigitsInNumber(N / 10);
// }
// //============================== MAIN ========================
// int number = Readint("Введите число");
// Console.WriteLine(SumDigitsInNumber (number));
//=========================================================================== TASK 02

//=========================================================================== TASK 03!!!!!!!
// нужно считать строку с консоли латиницу и
//  вывести все буквы согласные через пробел

// //=========================== FUNCTIONS ======================= !!!!!!!!!!!

// bool IsConsonant (char c)
// {
//     return "bcdfghwlmnpqrstvxzl".Contains(c); // c = 'a'возвращает значение если буква содержится в строке
// }
// void PrintResultVowes(string str, int index)
// {
//     if(index >= str!.Length) return; // EMERGENCY FUNCTION STOP

//     char c = char.ToLower(str[index]);

//     if(IsConsonant(str[index]))
//     {
//         Console.Write(str[index] + " ");
//     }
//     PrintResultVowes(str, index + 1);
// }
// //============================== MAIN ========================
// Console.WriteLine("ADD THE STRING AND PRESS ENTER");
// string? inputStr = Console.ReadLine();
// PrintResultVowes(inputStr, 0);
// //=========================================================================== TASK 03!!!!!!!

// //================================================================================ 03
// // Считать строку с консоли, содержащую латинские буквы.
// // Вывести на экран согласные буквы этой строки.
// // Указание
// // Использовать рекурсию. Не использовать цикл.
// // Пример
// // “hello” => h l l
// // “World” => W r l d
// // “Hello world!” => H l l w r l d

// // ----------------- ОБЪЯВЛЕНИЕ ФУНКЦИЙ ---------

// bool IsConsonant(char c)
// {
//     return "bcdfghlmnpqrstvxzkw".Contains(c); 
// }

// void PrintWithoutVowels(string str, int index = 0)
// {
//     if(index >= str!.Length) return;

//     char c = char.ToLower(str[index]);

//     if(IsConsonant(c))
//     {
//         System.Console.Write(str[index] + " ");
//     }

//     PrintWithoutVowels(str, index + 1);
// }
// // ----------------- ОСНОВНОЙ КОД ---------------

// System.Console.Write("Введите строку: ");
// string? inputStr = Console.ReadLine();
// PrintWithoutVowels(inputStr);






