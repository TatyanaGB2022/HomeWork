// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет 

System.Console.WriteLine("Введите число дня недели: ");
string volue = Console.ReadLine();
int dayOfWeek = Convert.ToInt32(volue);

if (dayOfWeek >= 1 && dayOfWeek <= 5)
{
  System.Console.WriteLine("Ответ: Будний день.");
}
if (dayOfWeek == 6 || dayOfWeek == 7)
{
  System.Console.WriteLine("Ответ: Выходной день.");
}
if (dayOfWeek > 7)
{
  System.Console.WriteLine("Ошибка: В неделе всего 7 дней");
}