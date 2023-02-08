// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.Write("Введите колличество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
  System.Console.Write($"Введите число {i + 1}: ");
  int x = Convert.ToInt32(Console.ReadLine());
  if (x > 0)
    count++;
}
System.Console.WriteLine($"Количество положительных чисел: {count}");