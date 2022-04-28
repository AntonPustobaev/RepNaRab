//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

using System;
Console.Clear();

//int[] array = GetArray(4, 100, 1000);


void PrintResult(int[] array)
{
int positive = 0;
for (int i =0; i < array.Length; i++)
{
    
    if (array[i] % 2 == 0) positive++;
}

Console.WriteLine($"{String.Join(" ",array)} -> {positive}");
Console.WriteLine();
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++ )
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

PrintResult(GetArray(4, 100, 1000));