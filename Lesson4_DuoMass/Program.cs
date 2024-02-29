Console.Clear();
Console.WriteLine("Lesson 4, Dual Mass");
Console.WriteLine("");

//=================================================================================== Theory

// int[,] table = new int[3,5];
// где int это тип данных
//table это название
// [,] указание двумерного массива где вначале - колличество
// строк, а затем количество столбцов
// конкретно тут - целочисленный двумерный массив на 3 строчки
// и 5 столбцов
//table.GetLength(0) - запрос колличества строк
//table.GetLength(1) - запрос колличество столбцов



//=================================================================================== Task 01
// Необходимо создать двумерный массив с размерами 3 х 5, состоящий
// из целых чисел и вывести его на экран

// int[,] CreateMatrix(int rowCount, int columsCount)
// {
//     int[,] matrix = new int[rowCount, columsCount];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i = i + 1) // заполнение массива
//     {

//         for (int j = 0; j < matrix.GetLength(1); j = j + 1)
//         {
//             matrix[i, j] = rnd.Next(1, 11); // рещение преподавателя + вывод во вне создание рандома
//             //matrix[i,j] = new Random().Next(50,100); //   мое решение
//         }
//     }
//     return matrix;
// }

// void ShowMatrix(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i = i + 1) // вывод двумерного массива 
//     {

//         for (int j = 0; j < matrix.GetLength(1); j = j + 1)
//         {
//             Console.Write($"{matrix[i, j]}\t");// интерполяция; \t это табуляция чтобы ровно все было
//         }
//         Console.WriteLine(" ");//перенос на новую строку чтобы была матрица 
//     }
// }

// int[,] matrix = CreateMatrix(4,5);
// ShowMatrix(matrix);


//=================================================================================== Task 01
