Console.Clear();
Console.WriteLine("Lesson 2, Task 2");
Console.WriteLine("");

//Напишите программу, которая на вход принимает цифру - колличество элементов массива,
// а на выходе выводит массив с рандомными значениями

//=============================================================================== My own decision 

// Console.WriteLine("Add the number of the array Elements");
// int n = Convert.ToInt32(Console.ReadLine());
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

//=============================================================================== My own decision 2 

// Console.WriteLine("Add the number of the array Elements");
// int n = Convert.ToInt32(Console.ReadLine());
//while (i < n) // создаем массив с рандомными числами и одновременно его выводим
// {
//     arr[i] = new Random().Next(1, 100);
//     Console.Write("| " + arr[i] + " |");
//     i = i + 1;
// }
//=============================================================================== 

//Создайте массив, и заполните его целыми числами от 1 до N,
//где N - произвольное натуральное число и выведите элементы массива на экран


int n = 10;
int [] arr = new int[n];
int i = 0;

while(i < arr.Length)
{
    arr[i] = i + 1;
    // Console.Write(arr[i]);
    // Console.Write(" ");
    Console.Write($"{arr[i]} ");
    i = i + 1;

}