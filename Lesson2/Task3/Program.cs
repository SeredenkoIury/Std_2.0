Console.Clear();
Console.WriteLine("Lesson 2, Task 3");
Console.WriteLine("");

//Создайте целочисленный массив на 10 элементов и заполните его произвольными числами.
//Выведите на экран только четные числа

//=====================================================My own decision
// int[] array = new int[10];
// int i = 0;

// Console.WriteLine("Random Mass");
// while (i < array.Length)
// {
//     array[i] = new Random().Next(10, 100);
//     Console.Write(array[i] + " ");
//     i = i + 1;
// }
// i = 0;
// Console.WriteLine("");

// Console.WriteLine("Even Elements of Random Mass");
// while (i < array.Length)
// {
//     if (array[i]%2==0)
//     {
//         Console.Write(array[i] + " ");
//     }
//     i = i + 1;
// }
// i = 0;
//=====================================================My own decision

//int n = 1032;
int[] array = { 1,2,3,5,6,7,8,9,6,3 };
int i = 0;
while(i<array.Length)
{
    if(array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i+1;
}