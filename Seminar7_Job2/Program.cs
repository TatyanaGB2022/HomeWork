// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 1 -> 1

System.Console.Write("Введите строку > ");
int position1 = Convert.ToInt32(Console.ReadLine()) - 1;
System.Console.Write("Введите столбец > ");
int position2 = Convert.ToInt32(Console.ReadLine()) - 1;
System.Console.WriteLine();
int columns = 3;
int rows = 4;

Random random = new Random();
int[,] array = new int[columns, rows];
System.Console.WriteLine("Сгенерирован массив: ");

for (int i = 0; i < array.GetLength(0); i++)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    array[i, j] = random.Next(1, 10);
    System.Console.Write($"{0} ", array[i, j]);
  }
  System.Console.WriteLine();
}
System.Console.WriteLine();

if (position1 < 0 | position1 > array.GetLength(0) - 1 | position2 < 0 | position2 > array.GetLength(1) - 1)
{
  System.Console.WriteLine("Нет такого элемента в массиве ");
}
else
{
  System.Console.WriteLine("Значение элемента массива = {0}", array[position1, position2]);
}
System.Console.ReadLine();