// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
  System.Console.WriteLine($"{message} ");
  return Convert.ToInt32(Console.ReadLine());
}
int N = Prompt("Введите число: ");
int i = 1;
while (i <= N)
{
  double result = Math.Pow(i, 3);
  System.Console.WriteLine($"Третья степень числа {i} = " + result);
  i++;
}