// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] massive = GetArray(7);
Console.Write("Созданный массив: ");
PrintArray(massive);
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " 
                    + DifferenceMinMaxItemOnArray(massive));

double[] GetArray(int length, int maxValue = 100)
{
    double[] array = new double[length];
    // var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * maxValue;
    }
    return array;
}

void PrintArray(double[] array)
{
    foreach (var item in array)
    {
        Console.Write(item + ", ");
    }
    Console.WriteLine();
}

double DifferenceMinMaxItemOnArray(double[] array)
{
    double max = array[1];
    double min = array[0];

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