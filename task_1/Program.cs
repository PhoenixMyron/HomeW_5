// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    arr[i] = new Random().Next(100,1000);
    Console.WriteLine($"{string.Join(", ", arr)}");
}

int ReleaseArray(int[] arr)
{
    int result = 0;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        
    result = arr[i] % 2;
    if ( result == 0)
            count++;
    }
    return count;
}

Console.Write("Введите количество элементов массива:\t");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
PrintArray(arr);
Console.WriteLine($"Результат: {ReleaseArray(arr)}");