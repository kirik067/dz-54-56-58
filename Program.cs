// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] a = new int[3, 4];
// Random random = new Random();
// FillArrayRandomNumbers(a);
// PrintArray(a);
// Console.WriteLine();
// arrangethenumbers(a);
// Print(a);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < a.GetLength(0); i++)
//     {        
//         for (int j = 0; j < a.GetLength(1); j++)
//         {
//             a [i,j] = new Random().Next(0, 10);
            
//         }   
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//           Console.Write(array[i,j] + " ");
//         }   
//         Console.Write("]");
//         Console.WriteLine(""); 
//     }
// }

// void arrangethenumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) -1 ; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                    int temp = 0;
//                     temp = array[i, k];
//                     array[i, k] = array[i, k + 1];
//                     array[i, k + 1] = temp;
//                 }
//             }
//         }
//     }
// }

// void Print(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//     {
//             Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i,j] + " ");
//             }   
//         Console.Write("]");
//             Console.WriteLine(""); 
//     }
// }



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] a = new int[3, 4];
// Random random = new Random();
// FillArrayRandomNumbers(a);
// PrintArray(a);
// Console.WriteLine();
// int minsum = Int32.MaxValue;
// int minSumLine = 0;


//     for (int i = 0; i < a.GetLength(0); i++)
//     {
//        int sum = 0;
//         for (int j = 0; j < a.GetLength(1); j++)
//         {  
//           sum = sum + a[i, j]; 
//         }
//         if (sum < minsum)
//         {
//             minsum = sum;
//             minSumLine++;
//          }
//     }

// Console.Write( + (minSumLine+1) + " строкa с наименьшей суммой " + (minsum) + " элементов ");

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < a.GetLength(0); i++)
//     {        
//         for (int j = 0; j < a.GetLength(1); j++)
//         {
//             a [i,j] = new Random().Next(0, 10);
            
//         }   
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//           Console.Write(array[i,j] + " ");
//         }   
//         Console.Write("]");
//         Console.WriteLine(""); 
//     }
// }


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int size = InputInt("размерность матриц: ");
// int[,] matrixA = new int[size, size];
// int[,] matrixB = new int[size, size];
// FillArrayRandomNumbers(matrixA);
// FillArrayRandomNumbers(matrixB);
// int[,] matrixC = new int[size, size];

// for (int i = 0; i < size; i++)
// {
//     for (int j = 0; j < size; j++)
//     {
//         for (int k = 0; k < size; k++)
//         {
//             matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
//         }
//     }
// }
// Console.WriteLine("Матрица - А");
// PrintArray(matrixA);
// Console.WriteLine();
// Console.WriteLine("Матрица - В");
// PrintArray(matrixB);
// Console.WriteLine();
// Console.WriteLine("Произведение матриц А*В");
// PrintArray(matrixC);


// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 5); 
//         }
//     }
// }
// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }