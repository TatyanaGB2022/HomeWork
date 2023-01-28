// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// Не использовать строки для расчета.

System.Console.WriteLine();
int Number = new Random().Next(100, 1000);
int NewNumber = 0;

int NumberWithoutSecDig()
{
  NewNumber = Number / 100 * 10 + Number % 10;
  return NewNumber;
}

NumberWithoutSecDig();
System.Console.WriteLine($"Если из числа {Number} удалить вторую цифру, получится число {NewNumber}");