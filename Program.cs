// 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*


/// <summary>
/// этот метот упорядочит элементы каждой строки
/// </summary>
/// <param name="rows">строки</param>
/// <param name="cols">столбцы</param>
/// <returns></returns>

int[,] GetMatrix(int rows, int cols )
{
    int[,] matrix = { { 20, 9, 11 }, { 30, 5, 6 } };
    Console.WriteLine("ДО");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,3}", matrix[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine("ПОСЛЕ");

    for (int i = 0; i < matrix.GetLength(0); i++) // Сортировка массивов
    {
        for (int j = matrix.GetLength(1) - 1; j > 0; j--)
        {

            for (int k = 0; k < j; k++)
            {
                if (matrix[i, k] > matrix[i, k + 1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }
        Console.WriteLine();
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,3}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}


*/

//  56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*


int[,] matrix = new int[6, 4];
FillArrayRandom(matrix);
PrintArray(matrix);
Console.WriteLine();
NumberRowMinSumElements(matrix);

/// <summary>
/// Выдает номер строки с наименьшей суммой элементов
/// </summary>
/// <param name="array">двум.массив</param>


void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRow += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sumRow += matrix[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}




*/





//  58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*
namespace matrix_multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] a = new int[2, 2];
            Console.WriteLine("Введите числа 1-ой матрицы через enter ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Первая матрица: ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                  Console.Write(a[i,j]+"\t");
                }
                Console.WriteLine(); 
            }


            int[,] b = new int[2, 2];
            Console.WriteLine("Введите числа 2-ой матрицы через enter ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Вторая матрица: ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Произведение двух матриц: ");
            int[,] c = new int[2, 2];
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {


                    c[i,j]=0;
                     for (int k = 0; k < 2; k++)
                     {
                         c[i, j] +=  a[i, k] * b[k, j];
                     }
                 }
            }
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(c[i, j]+"\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}


*/


//  60. Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



/*

/// <summary>
/// 
/// </summary>
/// <returns></returns>
 int[, ,] Generate3DArray()
{
    int[, ,] array3D = new int[9, 9, 9];
    int[] combination = { 0, 0 };

    for (int x = 0; x < 9; x++)
    {
        for (int y = 0; y < 9; y++)
        {
            GenerateUniqueNumber(ref combination);
            for (int z = 0; z < 9; z++)
            {
                array3D[x, y, z] = combination[z];
            }
        }
    }

    return array3D;
}

static void GenerateUniqueNumber(ref int[] value)
{
    var rnd = new Random();
    int i = 0;
    while (i < 2)
    {
        int temp = rnd.Next(10, 99);
        if (!value.Contains(temp))
        {
            value[i] = temp;
            i++;
        }
    }
}

static void Print3DArray(int[, ,] array3D)
{
    for (int x = 0; x < 9; x++)
    {
        for (int y = 0; y < 9; y++)
        {
            Console.Write($"[{x}][{y}] : [");
            for (int z = 0; z < 9; z++)
            {
                Console.Write($"{array3D[x, y, z]}, ");
            }
            Console.WriteLine("");
        }
    }
}


*/




// ДОПОЛНИТЕЛЬНАЯ ЗАДАЧКА
//  62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

