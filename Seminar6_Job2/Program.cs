// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// System.Console.Write("Введите координату точки k1 > ");
// var k1 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Введите координату точки b1 > ");
// var b1 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Введите координату точки k2 > ");
// var k2 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Введите координату точки b2 > ");
// var b2 = Convert.ToDouble(Console.ReadLine());

// var x = -(b1 - b2) / (k1 - k2);
// var y = k1 * x + b1;

// x = Math.Round(x, 3);
// y = Math.Round(y, 3);

// System.Console.WriteLine($"Пересечение в точке: ({x};{y})");

int InputInt(string message)
{
  System.Console.WriteLine($"{message}");
  return int.Parse(Console.ReadLine());
}

(double, double) IntersectionPoint(double b1, double k1, double b2, double k2)
{
  double x = (b2 - b1) / (k1 - k2);
  double y = k1 * x + b1;
  return (x, y);
}

bool CheckParallel(double k1, double k2)
{
  if (k1 == k2)
  {
    System.Console.WriteLine("Прямые параллельны или совпадают");
    return false;
  }
  return true;
}

int b1 = InputInt("Введите b1: ");
int k1 = InputInt("Введите k1: ");
int b2 = InputInt("Введите b2: ");
int k2 = InputInt("Введите k2: ");

if(CheckParallel(k1, k2))
{
(double x, double y) = IntersectionPoint(b1, k1, b2, k2);
System.Console.WriteLine($"Пересечение в точке: ({x};{y})");
}

