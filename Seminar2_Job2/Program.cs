//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
System.Console.WriteLine(MakeArray(number, count));
int ReadInt(string message)
{
  System.Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
  int result = 0;
  if (b < 3)
  {
    System.Console.WriteLine("В этом числе нет третьей цифры: ");
  }
  else
  {
    int c = 1;
    for (int i = b; i > 3; i--)
    {
      c = c * 10;
    }

    result = (a / c) % 10;
  }
  return result;
}
