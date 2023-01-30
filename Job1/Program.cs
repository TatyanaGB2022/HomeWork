// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

//моё решение
// System.Console.WriteLine("Введите число 1: ");
// string number1 = Console.ReadLine();
// int a = Convert.ToInt32(number1);
// System.Console.WriteLine("Введите число 2: ");
// string number2 = Console.ReadLine();
// int b = Convert.ToInt32(number2);
// System.Console.WriteLine(a > b ? "Первое число больше второго" : "Второе число больше первого");

// можно решить короче
int InputInt(string message) //введи целое число
{
  System.Console.WriteLine(message);
  string valueString1 = Console.ReadLine();
  int value1 = Convert.ToInt32(valueString1);// переведите число в int
  return value1;
}
int value1 = InputInt("Введите первое число"); //Запросить у пользователя первое число и сохранить его в переменную1
int value2 = InputInt("Введите второе число");//Запросить у пользователя второе число и сохранить его в переменную1
if (value1 > value2)
{ // сравнить значения двух переменных
  System.Console.WriteLine($"Max = {value1}, Min = {value2}");// если первое значение больше, то вывести Мах=переменная 1,
  // Min= переменная 2
}
else // иначе вывести Мах=переменная 2, Min= переменная 1
{
  System.Console.WriteLine($"Max = {value2}, Min = {value1}");
}