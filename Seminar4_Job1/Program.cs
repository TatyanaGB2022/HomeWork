// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B. Не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int count = 1;

for (int i = 1; i <= number2; i++)
{
  count = count * number1;
}
System.Console.WriteLine($"{number1} в степени {number2} равно: " + count);
