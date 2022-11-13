// Дополнительно. 
// Дан массив чисел. 
// Напишите функцию, которая ищет заданное число в массиве и показывает нужный индекс в нем. 
// При отсутствии числа возвращать -1.

int[] massive = GetArray(10);
Console.Write("Созданный массив: ");
PrintArray(massive);

Console.Write("Искомое число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Индекс заданного числа в массиве: " + GetIndexNumber(massive, num));

int GetIndexNumber(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return i;
        }
    }
    return -1;
}


int[] GetArray(int length, int minValue = 0, int maxValue = 10)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);
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

