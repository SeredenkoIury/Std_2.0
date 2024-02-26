Console.Clear();
Console.WriteLine("Seminar 03, Mass Homework");
Console.WriteLine("");


//=================================================================================== Theory
// тип возвращаемого значения     void + Name + () + {}
// для вызова - название + ()

// //=================================================================================== Task 01

// // Задайте массив из N случайных чисел (N вводится с клавиатуры)
// // Найдите количество чисел, которые оканчиваются на 1 и десятся нацело на 7.

// //============================================================ обычным способом
// // Console.WriteLine("Add the number of elements of the array");
// // int size = Convert.ToInt32(Console.ReadLine());

// // int[] array = new int[size];

// // for(int i = 0; i<array.Length; i = i + 1)
// // {
// //     array[i] = new Random().Next(1, 40);
// // }

// // for(int i = 0; i<array.Length; i = i + 1)
// // {
// //     Console.Write(array[i] + " ");
// // }

// // int count = 0;
// // for(int i = 0; i<array.Length; i = i + 1)
// // {
// //     if (array[i]%10==0 && array[i] % 7 == 0)
// //     {
// //         count = count + 1;
// //     }
// // }

// // Console.WriteLine(" ");
// // Console.WriteLine(count);

// //====================================================с помощью функций
// Console.WriteLine("Add the number of elements of the array");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[size];

// void FillArray()
// {
//     for (int i = 0; i < array.Length; i = i + 1)
//     {
//         array[i] = new Random().Next(1, 40);
//     }
// }

// void Printarray()
// {
//     for (int i = 0; i < array.Length; i = i + 1)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int GetCountNumber()
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i = i + 1)
//     {
//         if (array[i] % 10 == 1 && array[i] % 7 == 0)
//         {
//             count = count + 1;
//         }
//     }
//     return count;
// }

// FillArray();
// Printarray();
// Console.WriteLine(" ");
// Console.WriteLine(GetCountNumber());
// //=================================================================================== Task 01


//=================================================================================== Task 02
