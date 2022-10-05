// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double Readnumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}
double b1 = Readnumber("Введите координату b1");
double k1 = Readnumber("Введите координату k1");
double b2 = Readnumber("Введите координату b2");
double k2 = Readnumber("Введите координату k2");
double x = (b2-b1)/(k1-k2);
double y = k1*((b2-b1)/(k1-k2)) + b1;
Console.WriteLine($"Введите точки пересечения x:{x}; y:{y}");

