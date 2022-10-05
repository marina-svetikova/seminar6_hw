// // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string Readnumber(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();// без конвертирования, тк здесь string
}

string number = Readnumber("Введите число. Для завершения напишите stop");
int count =0;
while (number != "stop")
{
int i = Convert.ToInt32(number);// конвертирую нашу переменную из строки в число
     if (i>0)
    {
      count ++;
      Console.WriteLine("Введите число. Для завершения напишите stop");
      number = Console.ReadLine();
    }
   else
    {
       Console.WriteLine("Введите число. Для завершения напишите stop");
      number = Console.ReadLine();
    }
}
Console.WriteLine($"Введено {count} больше 0");

