Console.Clear();
Console.WriteLine("Lesson 2, Task 4");
Console.WriteLine("");

//Создайте массив из 5 рандомных элементов, найтиде и выведете больший из них

//========================================================== My own solution
// Console.WriteLine("Add the number of the elements");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// int i = 0;

// Console.WriteLine("Random Array:");
// while(i<array.Length)
// {
//     array[i] = new Random().Next(1,100);
//     Console.Write(array[i] + " ");
//     i = i + 1;
// }
// i = 0;
// Console.WriteLine(" ");
// int Max = array[0];
// while(i<array.Length)
// {
//     if (array[i] > Max)
//     {
//         Max = array[i];
//     }
//     i = i + 1;
// }

// Console.WriteLine("Maximum is " + Max);

int n = 5;
int[] array = { 2231, 400, 3724, 3, 92 };
int max = array[0];
int i = 0;
while(i<n)
{
    if(array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine("Max is " + max);

max = array[0];
for(int j = 0; j < n; j = j + 1)
{
    if(array[j] > max)
    {
        max = array[j];
    }
}
Console.WriteLine("Max is " + max);
max = array[0];

foreach (int e in array)
{
     if(e > max)
    {
        max = e;
    }
}
Console.WriteLine("Max is " + max);
