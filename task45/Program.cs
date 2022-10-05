// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


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

int [] arr = GetArray (5,0,10);// здесь arr
int [] copiedArray = new int [arr.Length]; // что бы работать с массивом под него нужно обязательно выделять память с определенным количеством элементов
for (int i=0; i<arr.Length; i++)
{
    copiedArray[i]=arr[i];// поэлементное копирование массива
}

Console.WriteLine($"Исходный массив = {string.Join(",", arr)}");
Console.WriteLine($"Скопированный массив = {string.Join(",", copiedArray)}");
