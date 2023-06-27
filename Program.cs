/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix = GetMatrix(rows, columns, 0, 10);
PrintMatrix(resultMatrix);
ChangedMatrix(resultMatrix);
Console.WriteLine("Матрица результат: ");
PrintMatrix(resultMatrix);

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = new Random().Next(min, max + 1);

        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
} 
void ChangedMatrix(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
if (rows != columns)
{
    Console.WriteLine("Error");
    return;
}


int[,] resultMatrix = GetMatrix(rows, columns, 0, 10);
PrintMatrix(resultMatrix);

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = new Random().Next(min, max + 1);

        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
} 

int GetRowsSum(int[,] array, int i)
{
int sum = array[i,0];
for (int j = 1; j < array.GetLength(1); j++)
{
sum += array[i,j];
}
return sum;
}

int minSum = 1;
int sum = GetRowsSum(resultMatrix, 0);
for (int i = 1; i < resultMatrix.GetLength(0); i++)
{
if (sum > GetRowsSum(resultMatrix, i))
{
sum = GetRowsSum(resultMatrix, i);
minSum = i+1;
}
}
Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");
*/


/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/*
Console.Write("Введите количество строк первой матрицы: ");
int firstRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов первой матрицы: ");
int firstColumns = Convert.ToInt32(Console.ReadLine());

int[,] resultFirstMatrix = GetFirstMatrix(firstRows, firstColumns, 0, 10);
PrintFirstMatrix(resultFirstMatrix);

int[,] GetFirstMatrix(int m, int n, int min, int max)
{
    int[,] firstMatrix = new int[m, n];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {

            firstMatrix[i, j] = new Random().Next(min, max + 1);

        }
    }
    return firstMatrix;
}

void PrintFirstMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк второй матрицы: ");
int secondRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов второй матрицы: ");
int secondColumns = Convert.ToInt32(Console.ReadLine());
if (firstColumns != secondRows)    //Чтобы можно было умножить две матрицы, количество столбцов первой матрицы 
{                                  //должно быть равно количеству строк второй матрицы.
    Console.WriteLine("Error");
    return;
}

int[,] resultSecondMatrix = GetSecondMatrix(secondRows, secondColumns, 0, 10);
PrintSecondMatrix(resultSecondMatrix);

int[,] GetSecondMatrix(int m, int n, int min, int max)
{
    int[,] secondMatrix = new int[m, n];
    for (int i = 0; i < secondMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {

            secondMatrix[i, j] = new Random().Next(min, max + 1);

        }
    }
    return secondMatrix;
}

void PrintSecondMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int GetMatrixProduct(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(0); k++)
            {
                matrixC [i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

Не закончил задачу, уперся в тупик!!!
*/

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


int x = 2;
int y = 2;
int z = 2;

int[,,] matrix = new int[x, y, z];
int indexX = 0;
int indexY = 0;
int indexZ = 0;

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        for (int k = 0; k < z; k++)
        {
            matrix[i, j, k] = new Random().Next(10, 100);
            indexX = i;
            indexY = j;
            indexZ = k;
            Console.Write($"{matrix[i, j, k]}({i},{j},{k}) \t");
        }
        Console.WriteLine();
    }
}
