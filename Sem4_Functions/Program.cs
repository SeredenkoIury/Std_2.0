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

// // Заполните массив на N (вводится с консоли, не более 8)
// // случайных целых чисел от 0 до 9.
// // Сформируйте целое число, которое будет состоять из цифр из
// // массива. Старший разряд числа находится на 0-м индексе,
// // младший – на последнем.
// // Пример
// // [1 3 2 4 2 3] => 132423
// // [2 3 1] => 231

// System.Console.WriteLine("Введите число");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[size];

// void FillingArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }


// int GetNumber()
// {
//     string num = "";

//     for (int i = 0; i < array.Length; i++)
//     {
//         num = num + array[i];
//     }
//     return Convert.ToInt32(num);
// }

// FillingArray();
// PrintArray();
// System.Console.WriteLine(GetNumber());
// //=================================================================================== Task 02

//=================================================================================== Task 03
// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2                   // 19     2 3 4 5 6 18
// [4 3 4 1 9 5 21 13] => 3           // 21      2 3 

System.Console.WriteLine("Введите число");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreatArray()
{
    int[] array = new int[size];
    return array;
}

void FillingArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2, 30);
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}


int GetNumber()
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        bool isFind = true;

        for (int j = 2; j < array[i]; j++)
        {
            if (array[i] % j == 0)
            {
                isFind = false;
            }
        }

        if (isFind == true)
        {
            count = count + 1;
        }
    }
    return count;
}

FillingArray();
PrintArray();
System.Console.WriteLine(GetNumber());
//=================================================================================== Task 03

//=================================================================================== Task 04