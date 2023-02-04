// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int Numbers = 8;

// int[] GenerateArray(int x)
// {
//     int[] arr = new int[x];
//     for (int i = 0; i < x; i++)
//     {
//         arr[i] = new Random().Next(1, 100);
//     }
//     return arr;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         System.Console.Write($"{array[i]} ");
// }

// PrintArray(GenerateArray(Numbers));

// ДРУГОЙ МЕТОД

int InputInt(string message)
{
  System.Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int len)
{
  int[] array = new int[len];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(0, 10);
  }
  return array;
}
void PrintArray(int[] array)
{
  foreach (int item in array)
  {
    System.Console.Write($"{item}\t");
  }
}
int sizeOfArray = InputInt("Введите размер массива");
int[] array = GenerateArray(sizeOfArray);
PrintArray(array);