//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int Readnumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintFiboTon(int N)
{
    if(N>= 2)
    {
        int[] fibo = new int[N];// массив
        fibo[0] = 0;//первое число массива по условиям 
        fibo[1] = 1;//второе число массива по условиям 
        for (int i = 2; i< fibo.Length; i++) //остальную чатсь массива заполним с помощью цикла
        {
            fibo[i]=fibo[i-1]+fibo[i-2];
        }
        Console.WriteLine(string.Join("", fibo));
    }
    else
    {
        Console.WriteLine("N должно быть больше 2");    }
}
    int number = Readnumber("Введите N");
    PrintFiboTon(number);
