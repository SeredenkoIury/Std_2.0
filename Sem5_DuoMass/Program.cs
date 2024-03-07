Console.Clear();
Console.WriteLine("Sem5, Dual Mass");
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

//=============================================================================================Task 1
// Задайте двумерный массив и найдите элементы у которых оба индекса четных и 
// замените эти элеименты на их

// int[,] array = new int[4, 5];

// void FillingArray()
// {

//     for (int i = 0; i < array.GetLength(0); i = i + 1) // заполнение массива
//     {

//         for (int j = 0; j < array.GetLength(1); j = j + 1)
//         {
//             array[i, j] = new Random().Next(1, 10);

//         }
//     }

// }

// void PrintArray()
// {

//     for (int i = 0; i < array.GetLength(0); i = i + 1) // вывод двумерного массива 
//     {

//         for (int j = 0; j < array.GetLength(1); j = j + 1)
//         {
//             Console.Write($"{array[i, j]}\t");
//         }
//         Console.WriteLine(" ");
//     }
// }

// FillingArray();
// PrintArray();
// Console.WriteLine(" ");
// Console.WriteLine(" ");
// Change();
// PrintArray();

// void Change()
// {

//     for (int i = 0; i < array.GetLength(0); i = i + 1) // вывод двумерного массива 
//     {

//         for (int j = 0; j < array.GetLength(1); j = j + 1)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i, j] = array[i, j] * array[i, j];
//             }
//         }
//     }
// }

//=============================================================================================Task 1



//=============================================================================================Task 2

// Задайте двумерный массив и найдите сумму элементов находящихся на главной диагонали с
//  индексами 0-0, 1-1 и тд

// int[,] array = new int[4, 5];
// void FillingArray()
// {

//     for (int i = 0; i < array.GetLength(0); i = i + 1) // заполнение массива
//     {

//         for (int j = 0; j < array.GetLength(1); j = j + 1)
//         {
//             array[i, j] = new Random().Next(1, 10);

//         }
//     }

// }

// void PrintArray()
// {

//     for (int i = 0; i < array.GetLength(0); i = i + 1) // вывод двумерного массива 
//     {

//         for (int j = 0; j < array.GetLength(1); j = j + 1)
//         {
//             Console.Write($"{array[i, j]}\t");
//         }
//         Console.WriteLine(" ");
//     }
// }

// int GetCountNumber()
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i = i + 1) // вывод двумерного массива 
//     {

//         for (int j = 0; j < array.GetLength(1); j = j + 1)
//         {
//             if (i == j)
//             {
//                 sum = sum + array[i,j];
//             }
//         }
//     }
//     return sum;
// }

// FillingArray();
// PrintArray();
// Console.WriteLine(" ");
// Console.WriteLine(" ");
// Console.WriteLine(GetCountNumber());

// //=============================================================================================Task 2

//============================================================================================= Task 3
// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

int[,] array = new int[4,5];
double[] array2 = new double[array.GetLength(0)];

void FillingArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]= new Random().Next(1,10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j]+ " ");
        }
        System.Console.WriteLine();
    }
}

void GetCountNumberInArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum =0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
           sum = sum + array[i,j];
        }

        array2[i]= sum/ array.GetLength(1); 
    }
}

void PrintArray2()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write(array2[i]+ " ");
    }
}

FillingArray();
PrintArray();
GetCountNumberInArray();
System.Console.WriteLine();
PrintArray2();
