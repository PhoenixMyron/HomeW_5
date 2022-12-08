// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    arr[i] = new Random().Next(-100,101);
    Console.WriteLine($"{string.Join(", ", arr)}");
}

int ReleaseArray(int[] arr)
{
    int result = 0;
    int count = 0;
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    result = arr[i] % 2;
    if ( result != 0)
     {
        summ += arr[i];
     }
    }
  return summ;
}

Console.Write("Введите количество элементов массива:\t");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
PrintArray(arr);
Console.WriteLine($"Результат: {ReleaseArray(arr)}");