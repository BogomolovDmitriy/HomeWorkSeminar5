// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

//Трактую задачу так:позиция в массиве первая (нечетная) - индекс в массиве = 0 
//                   позиция в массиве вторая (четная) - индекс в массиве = 1 и т.д.
//Если трактовка не верна, то в 38 строке будет так:
//for (int i = 2; i < array.Length; i += 2)

int[] massive = GetArray(6);
Console.Write("Созданный массив: ");
PrintArray(massive);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + SumItemsOnOddIndex(massive));

int[] GetArray(int length, int minValue = 0, int maxValue = 10)
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

int SumItemsOnOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}
