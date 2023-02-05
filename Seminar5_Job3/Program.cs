// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементам массива.
// [3 7 22 2 78] -> 76

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

double[] FillSourceArray(int size)
{
  double[] array = new double[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().NextDouble() * 100;
  }
  return array;
}


int len = InputInt("Введите длину массива ");
int[] array = GenerateArray(len);
PrintArray(array);

double difference = array.Max() - array.Min();
System.Console.WriteLine($"Минимальное значение массива {array.Min()}, максимальное значение массива {array.Max()}");
System.Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");

