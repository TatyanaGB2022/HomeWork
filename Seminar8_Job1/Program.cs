// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы 
// каждой строки двумерного массива.

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

Console.Write("введите количество строк > ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов > ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[rows, columns];
FillArray(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения:");
PrintArray(numbers);

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
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями:");
PrintArray(numbers);


void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
  }
}