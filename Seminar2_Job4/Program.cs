// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// Не использовать строки для расчета.

//мое решение

// System.Console.WriteLine();
// int Number = new Random().Next(100, 1000);
// int NewNumber = 0;

// int NumberWithoutSecDig()
// {
//   NewNumber = Number / 100 * 10 + Number % 10;
//   return NewNumber;
// }

// NumberWithoutSecDig();
// System.Console.WriteLine($"Если из числа {Number} удалить вторую цифру, получится число {NewNumber}");

int RandomInt()
{
  Random rnd = new Random(); // rnd сокращенно Random
  return rnd.Next(100, 1000); //вернем 100 включительно, 1000 исключительно
}
int number = RandomInt();
int rank1 = number % 10;
int rank2 = number / 100;
int result = rank2 * 10 + rank1;
System.Console.WriteLine($"Изначальное число {number}, результат {result}");