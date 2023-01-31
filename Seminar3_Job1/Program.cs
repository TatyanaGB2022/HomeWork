// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int InputInt(string message)

{
  System.Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}

int IsPalindrome(int len)
{
  int pal = 0;
  while (len > 0)
  {
    pal = pal * 10 + len % 10;
    len = len / 10;
  }
  return pal;
}
int number = InputInt("Введите число: ");
int palindrom = IsPalindrome(number);
if (number == palindrom)
{
  System.Console.WriteLine("Является палиндромом");
}
else
{
  System.Console.Write("Не является палиндромом");
}