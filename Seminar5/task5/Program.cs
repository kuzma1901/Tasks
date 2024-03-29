﻿// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] MultValueArray(int[] array)
{
    int len = array.Length;
    int sizeResult = len / 2;
    if (len % 2 == 1) sizeResult++;

    int[] result = new int[sizeResult];

    for (int i = 0; i < sizeResult; i++)
    {
        result[i] = array[i] * array[(array.Length - 1) - i];
    }

    if (len % 2 == 1)
    {
        result[sizeResult - 1] = array[len / 2];
    }

    return result;
}

int[] arr = CreateArrayRndInt(5, 2, 10);
PrintArray(arr);

int[] resultMult = MultValueArray(arr);
PrintArray(resultMult);