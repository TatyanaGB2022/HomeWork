// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int m = InputNumbers("Введите число строк 1-й матрицы > ");
int n = InputNumbers("Введите число столбцов 1-й матрицы > ");
int p = InputNumbers("Введите число столбцов 2-й матрицы > ");
int range = InputNumbers("Введите диапазон случайных чисел от 1 до > ");
System.Console.WriteLine();

int[,] firstMatrix = new int[m, n];
CreateArray(firstMatrix);
System.Console.WriteLine($"Первая матрица:");
WriteArray(firstMatrix);
System.Console.WriteLine();

int[,] secondMatrix = new int[n, p];
CreateArray(secondMatrix);
System.Console.WriteLine($"Вторая матрица:");
WriteArray(secondMatrix);
System.Console.WriteLine();

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
System.Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i, k] * secondMartrix[k, j];
      }
      resultMatrix[i, j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  System.Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write($"{array[i, j]}\t");
    }
    System.Console.WriteLine();
  }
}