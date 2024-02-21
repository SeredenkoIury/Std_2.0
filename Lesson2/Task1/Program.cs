Console.Clear();
Console.WriteLine("Lesson 1, Task 1");
Console.WriteLine("");

// int[] arr = new int[5]; // Создали массив из целых чисел из 5 жлементов с именем arr
// arr[0] = 5;
// arr[1] = 7;
// arr[2] = 5;
// arr[3] = 4;
// arr[4] = 3;
// Console.WriteLine(arr[0]);
// Console.WriteLine(arr[1]);
// Console.WriteLine(arr[2]);
// Console.WriteLine(arr[3]);
// Console.WriteLine(arr[4]);

// //Console.WriteLine(arr[5]); выход за границы массива

// int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };

// int[] arr3 = { 1, 2, 3, 4, 5 };
//=====================================================The Theory of the Array==============

Console.WriteLine("Add the number of the array Elements");
int n = Convert.ToInt32(Console.ReadLine());

//int n = 10;


int[] arr = new int[n];
int i = 0;

//=============================================================================== My own decision 
// while (i < n) // создаем массив с рандомными числами
// {
//     arr[i] = new Random().Next(1, 100);
//     i = i + 1;
// }

// i = 0;

// while (i < n) // выводим массив созданный
// {
//     Console.Write("| " + arr[i] + " |");
//     i = i + 1;
// }
//=============================================================================== My own decision 
while (i < n) // создаем массив с рандомными числами и одновременно его выводим
{
    arr[i] = new Random().Next(1, 100);
    Console.Write("| " + arr[i] + " |");
    i = i + 1;
}
//=============================================================================== My own decision 