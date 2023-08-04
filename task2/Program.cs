// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetInfo (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
double num = GetInfo("введите значение b1: ");
double num2 = GetInfo("введите число k1: ");
double num3 = GetInfo("введите значение b2: ");
double num4 = GetInfo("введите число k2: ");

double x = (-num3 + num)/(-num2 + num4);
double y = num4 * x + num3;

Console.WriteLine($"две прямые пересекутся в точке c координатами X: {x}, Y: {y}");
