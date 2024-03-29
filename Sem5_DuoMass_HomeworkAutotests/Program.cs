﻿Console.Clear();
Console.WriteLine("Sem5, Dual Mass Autotest Homework");
Console.WriteLine("");

//=============================================================================================Theory
// int[,] table = new int[3,5];
// где int это тип данных
//table это название
// [,] указание двумерного массива где вначале - колличество
// строк, а затем количество столбцов
// конкретно тут - целочисленный двумерный массив на 3 строчки
// и 5 столбцов
//table.GetLength(0) - запрос колличества строк
//table.GetLength(1) - запрос колличество столбцов
//=============================================================================================Theory


//============================================================================== Task 01
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет:
// "Позиция по рядам выходит за пределы массива"
// или "Позиция по колонкам выходит за пределы массива"
// Позиции в массиве считать от единицы.
// В коде, начальные условия:

// int[,] numbers = new int[,]
// {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// };

// int x = 2;
// int y = 2;
// Выводится: 6

// Поиск элемента по позициям
    int FindElementByPosition(int[,] array, int x, int y)
    {
        
    }

// Проверка позиций на вхождение в массив
    bool ValidatePosition(int[,] array, int x, int y)
    {
        //Напишите свое решение здесь
    }

    void PrintResult(int[,] numbers, int x, int y)
    {
        //Напишите свое решение здесь
    }







//============================================================================== Task 01

//============================================================================== Task 02
// Задайте двумерный массив. Напишите программу, которая поменяет
//местами первую и последнюю строку массива.
// Начальные условия:
// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// }; 


// Выводится:
// 9   10  11  12
// 5   6   7   8
// 1   2   3   4






//==================================
void PrintArray(int[,] array)
    {
           for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           System.Console.Write("{0}\t", array[i,j]);
        }
        System.Console.WriteLine();
    }
    }

// Обмен элементами массива
void SwapItems(int[,] array, int i)
    {
       //Напишите свое решение здесь
      int temp = array[0,i];
      array[0,i] = array [(array.GetLength(0) - 1),i];
      array [(array.GetLength(0)- 1),i] = temp;
    }

void PrintResult(int[,] numbers)
    {

    PrintArray(SwapFirstLastRows(numbers));

    }



//============================================================================== Task 02






//============================================================================== Task 03

// Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
// Начальные условия:

// // Начальные условия
// int[,] numbers = new int[,] {
//     {1, 2, 3},
//     {1, 1, 0},
//     {7, 8, 2},
//     {9, 10, 11}
// };

public static int[] SumRows(int[,] array)
    {
             int [] sum = new int[array.GetLength(0)];
       for (int i = 0; i < array.GetLength(0); i++)
        {
            //int [] sum = new int[array.GetLength(0)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
           sum[i] = sum[i] + array[i,j];
        }
         }
        return sum;

    }

    public static int MinIndex(int[] array)
    {
             int MinIndex = 0;
       for(int i =0; i<array.Length; i++)
       {
        if (array[MinIndex] > array[i])
        {
            MinIndex = i;
        }
       }
       return MinIndex;
    }

public static void PrintResult(int[,] numbers)
    {   
   Console.WriteLine( MinIndex(SumRows(numbers)));
    }

Выводится: 1
//============================================================================== Task 03





//================================================================= MEETING ============

https://github.com/ViktoriyaTsoy/GB_CSharpIntro_HW7.git