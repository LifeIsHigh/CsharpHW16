// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Write("Enter the length of the array --> ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[Length];

void DifferenceMaxMin(int[] Array)
{
    for (int i = 0; i < Length; i++)
    {
        Array[i] = new Random().Next(0, 100);
        Console.Write($"{Array[i]} ");
    }
    int Max = Array[0];
    int Min = Array[1];
    for (int i = 0; i < Length; i++)
    {
        if (Max < Array[i])
        {
            Max = Array[i];
        }
        else if (Min > Array[i])
        {
            Min = Array[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Max = {Max}, Min = {Min}");
    Console.WriteLine($"Result Diff Max and Min = {Max - Min}");
}
DifferenceMaxMin(Array);