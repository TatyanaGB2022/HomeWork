// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//  вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// мое решение

// System.Console.WriteLine("Введите трехзначное число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a > 99 && a < 1000)
// {
//   int result = ((a / 10) % 10);
//   System.Console.WriteLine("Вторая цифра числа равна " + result);
// }
// else
// {
//   System.Console.WriteLine("Число не трехзначное");
// }

int InputInt (string massage)
{
  System.Console.Write(massage + " > ");
  string? InputValue = Console.ReadLine(); //вопрос означает, что InputValue может содержать ссылку в никуда. "?" можно убрать
  int result = Convert.ToInt32(InputValue);
  return result;
}

bool Validate(int number) //функция проверки числа. Попадает число в диапазон или нет
{
  if (number > 99 && number < 1000)
  {
    return true;
  }
  System.Console.WriteLine("Число не трехзначное. ");
  return false;
}
int number = InputInt("Введите трехзначное число.");

if (Validate(number))
{
  int LastRank = ((number / 10) % 10); // трехзначное делим на 10 и из двухзначного вытаскивает единицы
  System.Console.WriteLine($"Вторая цифра числа {number} равна {LastRank}");
}