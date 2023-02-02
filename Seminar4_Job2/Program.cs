// Задача 2: Напишите программу, которая принимает на вход число и
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.Write("Введите число > ");
int number = Convert.ToInt32(Console.ReadLine());

int Prompt(int number)
{
  int count = 0;
  int result = 0;

  while (number > 0)
  {
    count = number % 10;
    result = result + count;
    number = number / 10;
  }
  return result;
}
int prompt = Prompt(number);
System.Console.WriteLine("Сумма цифр в числе " + prompt);
