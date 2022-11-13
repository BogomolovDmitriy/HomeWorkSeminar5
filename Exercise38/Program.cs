// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int[] massive = GetArray(10);
Console.Write("Созданный массив: ");
PrintArray(massive);
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " 
                    + DifferenceMinMaxItemOnArray(massive));

int[] GetArray(int length, int minValue = 0, int maxValue = 100)
{
    int[] array = new int[length];
    var rnd = new Random();
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
        Console.Write(item + ", ");
    }
    Console.WriteLine();
}

int DifferenceMinMaxItemOnArray(int[] array)
{
    int max = array[1];
    int min = array[0];

    if (array[0] > array[1])
    {
        max = array[0];
        min = array[1];
    }
    
    for (int i = 2; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        
        else if (array[i] < min)
        {
            min = array[i];
        }

    }
    return (max - min);
}