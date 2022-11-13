// Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] massive = GetArray(6);
PrintArray(massive);

int[] GetArray(int length, int minValue = 100, int maxValue = 999)
{
    var rnd = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}