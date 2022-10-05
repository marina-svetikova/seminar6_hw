// //  Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите положительное число А:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число B:");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число С:");
int C = Convert.ToInt32(Console.ReadLine());

if (A<B+C&&B<A+C&&C<A+B)
{
    Console.WriteLine("Может существовать");
}
else
{
    Console.WriteLine("Не может существовать");
}

