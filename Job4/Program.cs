// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

//мое решение

// System.Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int startNumber = 1;

// while (startNumber <= a)
// {
//   if (startNumber % 2 == 0)
//     System.Console.Write(startNumber + ", ");
//   startNumber = startNumber + 1;
// }

//функция, определяющая четность числа
bool isOrder(int Number)
{
  int remainder = Number % 2;
  return remainder == 0;
}

System.Console.WriteLine("Введите последнее число: ");
string valueString = Console.ReadLine();
int N = Convert.ToInt32(valueString);
string Numbers = "";
int count = 2; //начинаем с 2, потому что оно первое четное число
string separator = "";
while (count <= N)
{
  if (count > 2)
  {
    separator = ", ";
  }
  Numbers = Numbers + separator + count;
  count += 2; //добавляем не 1, а 2 - будем идти по четным
}

System.Console.WriteLine($"Четные числа {Numbers}");
