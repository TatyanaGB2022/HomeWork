// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

System.Console.Write("Введите размер массива > ");
int massLength = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[massLength, massLength];
FillArray(numbers);
PrintArray(numbers);
int minsumm = Int32.MaxValue;
int indexRows = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
  int summ = 0;
  for (int j = 0; j < numbers.GetLength(1); j++)
  {
    summ = summ + numbers[i, j];
  }
  if (summ < minsumm)
  {
    minsumm = summ;
    indexRows++;
  }
}
System.Console.WriteLine();
System.Console.WriteLine("Строка с наименьшей суммой элементов > " + (indexRows));
System.Console.WriteLine("Сумма элементов в ней равна > " + (minsumm));

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0, 10);
    }
  }
}

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