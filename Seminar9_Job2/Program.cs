// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите число M:");
int numberM = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine());
System.Console.WriteLine();


void GapNumberSum(int numberM, int numberN, int sum)
{
  if (numberM > numberN)
  {
    System.Console.WriteLine($"{sum}");
    return;
  }
  sum = sum + (numberM++);
  GapNumberSum(numberM, numberN, sum);
}

GapNumberSum(numberM, numberN, 0);