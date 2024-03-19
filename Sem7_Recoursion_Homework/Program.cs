Console.Clear();
Console.WriteLine("Seminar 7, Recoursion Homework & Attestation");
Console.WriteLine("by Seredenko Iury Danilovich");
Console.WriteLine("");


// // ================================================================================================ Task 01
// // Задача 1: Задайте значения M и N. Напишите программу, которая 
// // выведет все натуральные числа в промежутке от M до N.
// //  Использовать рекурсию, не использовать циклы.

// //============================== FUNCTIONS ===============================
// void StraightFromMtoN (int bigger, int lower)
//     {
//         if (bigger > lower)
//     }

// int Bigger(int m, int n)
// {
//     if (m > n)
//     {
//         return m;
//     }
//     else return n;
// }

// int Lower(int m, int n)
// {
//     if (m > n)
//     {
//         return n;
//     }
//     else return m;
// }

// int Pull_M()
// {
//     Console.WriteLine("Add the M number and press Enter");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.Clear();
//     return m;
// }

// int Pull_N()
// {
//     Console.WriteLine("Add the N number and press Enter");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.Clear();
//     return n;
// }

// void PrintFromLowToBig(int low, int big)
// {
//     if (low + 1 == big) return;
//     PrintFromLowToBig(low, big - 1);
//     Console.Write(big - 1 + " ");
// }

// // //================================= MAIN =================================
// int m = Pull_M();
// int n = Pull_N();
// Console.Write("Straight numbers from " + Lower(m, n) + " to " + Bigger(m, n) + " is -> ");
// PrintFromLowToBig(Lower(m, n), Bigger(m, n));
// Console.WriteLine();
// //================================================================================================ Task 01

// //================================================================================================ Task 02
// // Задача 2: Напишите программу вычисления функции Аккермана
// //  с помощью рекурсии. Даны два неотрицательных числа m и n.

// //============================== FUNCTIONS ===============================

// int Pull_M()
// {
//     Console.WriteLine("Add the M number and press Enter");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.Clear();
//     return m;
// }
// int Pull_N()
// {
//     Console.WriteLine("Add the N number and press Enter");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.Clear();
//     return n;
// }

// int AkkermanFunction(int m, int n)
// {
//     if (m == 0)
//     {
//         Console.Write(n + 1 + " ");
//         return n + 1;
//     }
//     else if (m > 0 && n == 0)
//     {
//         Console.Write(AkkermanFunction(m - 1, 1) + " ");
//         return AkkermanFunction(m - 1, 1);
//     }
//     else if (m > 0 && n > 0)
//     {
//         Console.Write(AkkermanFunction(m - 1, AkkermanFunction(m , n - 1)));
//         return AkkermanFunction(m - 1, AkkermanFunction(m , n - 1));
//     }
//     else 
//     {
//         Console.WriteLine("WARNING ----------- WRONG NUMBERS BEEN ADDED ----------- WARNING");
//         return 0;
//     }

// }
// //================================= MAIN =================================
// int m = Pull_M();
// int n = Pull_N();
// Console.WriteLine();
// Console.WriteLine("Result is " + AkkermanFunction(n, m));
// //================================================================================================ Task 02

// //================================================================================================ Task 03
// // Задача 3: Задайте произвольный массив. Выведете его элементы, 
// // начиная с конца. Использовать рекурсию, не использовать циклы.


// System.Console.WriteLine("Add the number of elements of the Array");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];

// //============================== FUNCTIONS ===============================

// void FillingTheArray(int[] arr, int count) //using the recoursion
// {
//     if (count >= arr.Length)
//     {
//         return;
//     }
//     else
//     {
//         FillingTheArray(arr, count + 1);
//         arr[count] = new Random().Next(0, 100);

//     }
// }

// //================== ARRAY TEST WITHOUT RECOURSION ================
// void PrintArrayTest(int[] arr) // array check
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();
// }
// //================== ARRAY TEST WITHOUT RECOURSION ================

// void PrintTheReversedArray(int[] array, int count) //using the recoursion
// {
//     if (count >= array.Length) return;
//     else
//     {
//         PrintTheReversedArray(array, count + 1);
//         Console.Write(array[count] + " ");
//     }
// }

// //================================= MAIN =================================

// FillingTheArray(array, 0);
// Console.WriteLine("This is your random Array:  ");
// PrintArrayTest(array);
// Console.WriteLine();
// Console.WriteLine("This is Array reversed by the recoursion: ");
// PrintTheReversedArray(array, 0);

// //================================================================================================ Task 03
