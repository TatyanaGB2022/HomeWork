//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// мое решение

// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// System.Console.WriteLine(MakeArray(number, count));
// int ReadInt(string message)
// {
//   System.Console.WriteLine(message);
//   return Convert.ToInt32(Console.ReadLine());
// }
// int MakeArray(int a, int b)
// {
//   int result = 0;
//   if (b < 3)
//   {
//     System.Console.WriteLine("В этом числе нет третьей цифры: ");
//   }
//   else
//   {
//     int c = 1;
//     for (int i = b; i > 3; i--)
//     {
//       c = c * 10;
//     }

//     result = (a / c) % 10;
//   }
//   return result;
// }

int InputInt(string massage)
{
  System.Console.Write(massage + " > ");
  string inputValue = Console.ReadLine();
  int result = Convert.ToInt32(inputValue);
  return result;
}

int numIn = InputInt("Введите число: ");

if (numIn / 100 == 0) //проверяем есть ли третье число
{
  Console.WriteLine("Третьей цифры нет");
}
else
{
  while (numIn > 1000) //пока число numIn будет > 1000, мы его будем делить на 10 пока
                       //не достигнем зачения, когда будет в числе присутствовать три знака
  {
    numIn = numIn / 10;// например 12345 /10 откусили 5, 1234/10 откусили 4 до тех пор пока число будет меньше 1000
  }     //от 123 откусываем единицу numIn % 10, то есть 3 и получаем ответ
  System.Console.WriteLine($"Третья цифра: {numIn % 10}");//проверяем третью цифру. Берем остаток 
  //деления нА цЕло numIn % 10 и будет третья цифра
}