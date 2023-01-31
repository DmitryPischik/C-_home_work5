// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

void dotCross(int x1, int x2, int x3, int x4) // Функция находит пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b
{
    double x =  (x3 - x1) / (x2 - x4);
    double y =   x2 * x + x1;

    Console.WriteLine($"({x}, {y})");
}

Console.Write("Введите значение b1 k1 и b2 и k2 через пробел: ");
string input = Console.ReadLine();
string[] parts = input.Split(" ");
int b1 = int.Parse(parts[0] ?? "0");
int k1 = int.Parse(parts[1] ?? "0");
int b2 = int.Parse(parts[2] ?? "0");
int k2 = int.Parse(parts[3] ?? "0");

dotCross(b1, k1, b2, k2);
