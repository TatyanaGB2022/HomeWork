// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
// каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int InputInt(string message)
{
  System.Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}

int row = 3;
int col = 4;
int[,] numbers = new int[row, col];
FillArray2D(numbers);
PrintArray2D(numbers);

double[] averegeSumm = new double[numbers.GetLength(1)];

for (int i = 0; i < numbers.GetLength(1); i++)
{
  double result = 0.0;
  for (int j = 0; j < numbers.GetLength(0); j++)
  {
    result += numbers[j, i];
  }
  averegeSumm[i] = result / numbers.GetLength(0);
}
PrintArray(averegeSumm);

void FillArray2D(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void PrintArray2D(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
  }
  System.Console.WriteLine();
}

void PrintArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    System.Console.Write($"{array[i]}\t");
  }
  System.Console.WriteLine();
}
