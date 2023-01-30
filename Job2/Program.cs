// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22
// мое решение
// System.Console.WriteLine("Введите число 1: ");
// int Number1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число 2: ");
// int Number2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число 3: ");
// int Number3 = Convert.ToInt32(Console.ReadLine());

// if (Number1 > Number2)
// {
//   if (Number1 > Number3)
//   {
//     Console.WriteLine("Максимальное число: " + Number1);
//   }
//   else
//   {
//     Console.WriteLine("Максимальное число: " + Number3);
//   }
// }
// else if (Number2 > Number3)
// {
//   Console.WriteLine("Максимальное число: " + Number2);
// }
// else
// {
//   Console.WriteLine("Максимальное число: " + Number3);
// }

// еще одно решение

System.Console.WriteLine("Введите первое число");
string valueString1 = Console.ReadLine();
System.Console.WriteLine("Введите второе число");
string valueString2 = Console.ReadLine();
System.Console.WriteLine("Введите третье число");
string valueString3 = Console.ReadLine();
int value1 = Convert.ToInt32(valueString1);
int value2 = Convert.ToInt32(valueString2);
int value3 = Convert.ToInt32(valueString3);
int Max = value1;
if (value2 > Max)
{
  Max = value2;
}
if (value3 > Max)
{
  Max = value3;
}

System.Console.WriteLine($"Max = {Max}");