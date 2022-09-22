﻿//  Напишите программу, которая перевернёт одномерный массив
//  (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1] // 
// [6 7 3 6] -> [6 3 7 6]

int[] GetArray(int size, int leftRange,int rightRange)
{
     int[] arr = new int[size];
     Random rand = new Random();
     for (int i=0; i < size; i++)
     {
        arr[i] = rand.Next(leftRange, rightRange+1);
     }
     return arr;
}

void ReverseArray (int[] array) // метод разворота массива
{
    for (int i = 0; i < array.Length/2; i++)// нужна  не вся длина массива, а деленная на 2,так как нам надо 
    // сделать количество перестановок массива деленое на 2
    {
       int temp = array [i];  // будем переставлять элементы - первый с последний, второй с предпоследним. введем новую переменную
       array [i] = array[array.Length -1 -i];//общее число эл нашего масисва - 1 (тк инлесов меньше) - i, 
       //  тк нам нужен семитричный а не последний
       array [array.Length -1 -i] = temp;
    } 
}
int [] arr = GetArray (5,0,10);// здесь arr
Console.WriteLine($"Исходный массив = {string.Join(",", arr)}");
ReverseArray(arr);// и здесь arr
Console.WriteLine($"Развернутый массив = {string.Join(",", arr)}");
