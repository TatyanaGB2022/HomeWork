// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int InputInt(string message)
{
  System.Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}

int row = InputInt("Введите количество строк: ");
int col = InputInt("Введите количество столбцов: ");
System.Console.WriteLine();
double[,] numbers = new double[row, col];
FillArray2D(numbers);
PrintArray2D(numbers);

void FillArray2D(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(-99, 99) / 10.0;
    }
  }
}

void PrintArray2D(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write($"{array[i, j]}\t");
    }
    System.Console.WriteLine();
  }
  System.Console.WriteLine();
}

