// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// мое решение

// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 2 == 0)
// {
//   System.Console.WriteLine(number + " - Четное число");
// }
// else
// {
//   System.Console.WriteLine(number + " - Нечетное число");
// }

System.Console.WriteLine("Введите число: ");
string valueString = Console.ReadLine();
int number = Convert.ToInt32(valueString);
int remainder = number %2;
string NumberType = "нечетное";
if(remainder ==0)
{
  NumberType = "четное";
}
System.Console.WriteLine($"Число {NumberType}");