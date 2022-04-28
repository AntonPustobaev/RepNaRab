//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


using System;
Console.Clear();
int size = 10;
int[] array = GetArray(size);

int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-99, 99);
    }
    return res;
}

void PrintArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        System.Console.Write(arr[i] + " ");
        if (i % 2 > 0) sum = sum + arr[i];
    }
    System.Console.Write($" -> {sum} ");
    System.Console.WriteLine();
}

PrintArray(GetArray(size));