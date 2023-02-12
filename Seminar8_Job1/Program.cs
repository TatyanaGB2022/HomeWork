// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы 
// каждой строки двумерного массива.

System.Console.Write("Введите количество строк > ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов > ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[rows, columns];

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

for (int i = 0; i < numbers.GetLength(0); i++)
{
  for (int j = 0; j < numbers.GetLength(1) - 1; j++)
  {
    for (int z = 0; z < numbers.GetLength(1) - 1; z++)
    {
      if (numbers[i, z] < numbers[i, z + 1])
      {
        int temp = 0;
        temp = numbers[i, z];
        numbers[i, z] = numbers[i, z + 1];
        numbers[i, z + 1] = temp;
      }
    }
  }
}
System.Console.WriteLine();
System.Console.WriteLine("Массив с упорядоченными значениями:");
PrintArray(numbers);

void PrintArray(int[,] array)
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

FillArray(numbers);
System.Console.WriteLine();
System.Console.WriteLine("Массив до изменения:");
PrintArray(numbers);