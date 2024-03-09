/*
 Задача 3: 
 Задайте произвольный массив. Выведете
 его элементы, начиная с конца. Использовать
 рекурсию, не использовать циклы.
*/

int[] FillingArray(int[] array, int i)
{
    if (i < array.Length)
    {
        array[i] = new Random().Next(1, 100);
        FillingArray(array, i + 1);
    }
    return array;
}

string PrintStartArray(int[] array, int i)
{
    if (i == array.Length - 1)
    {
        return $"{array[array.Length - 1]} ";
    }
    return PrintStartArray(array, i + 1) + $"{array[i]} ";
}

string PrintEndArray(int[] array, int i)
{
    if (i == array.Length - 1)
    {
        return $"{array[array.Length - 1]} ";
    }
    return $"{array[i]} " + PrintEndArray(array, i + 1);
}

Console.Clear();
Console.Write("Задайте количество элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int i = 0;
int[] array = new int[n];
FillingArray(array, i);
Console.WriteLine("Начальный массив: ");
Console.WriteLine(PrintStartArray(array, i));
Console.WriteLine("Конечный массив: ");
Console.WriteLine(PrintEndArray(array, i));