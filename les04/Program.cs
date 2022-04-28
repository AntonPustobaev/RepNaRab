//Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

using System;
Console.Clear();
int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ",array));

int a = 0;
int num = 4;

while(a<12)
{
    if (array[a]==num)
    {
        Console.WriteLine($"{num}; -> Есть ");
        return;
    }
    else
    {
      a++;
    }
}
Console.WriteLine($"{num}; -> нет ");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++ )
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}