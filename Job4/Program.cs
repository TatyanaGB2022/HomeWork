// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int startNumber = 1;

while (startNumber <= a)
{
  if (startNumber % 2 == 0)
    System.Console.Write(startNumber + ", ");
  startNumber = startNumber + 1;
}