// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int InputInt(string message)
{
  System.Console.WriteLine($"{message}");
  return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int len)
{
  int[] array = new int[len];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(1, 100);
  }
  return array;
}

void PrintArray(int[] array)
{
  foreach (int item in array)
  {
    System.Console.Write($"{item}\t");
  }
  System.Console.WriteLine();
}

int SumNegativNumbers(int[] array)
{
  int sum = 0;
  for (int i = 1; i < array.Length; i+=2)
  {
    sum += array[i];
  }
  return sum;
}

int len = InputInt("Введите длину массива ");
int[] array = GenerateArray(len);
PrintArray(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {SumNegativNumbers(array)}");