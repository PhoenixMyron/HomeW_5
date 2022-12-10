// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    arr[i] = Math.Round((new Random().Next(10, 1000) + new Random().NextDouble()),2) ;
    Console.WriteLine($"{string.Join(", ", arr)}");
}

void ReleaseArray(double[] arr)
{

    for (int i = 1; i < arr.Length; i++)
    {
        int k = i;
        double x = arr[i];
		while (k > 0 && arr[k - 1] > x)
		{
			arr[k] = arr[k - 1];
			k--;
		}
        arr[k] = x;
    }
    Console.WriteLine($"{string.Join(", ", arr)}");
}

Console.Write("Введите количество элементов массива:\t");
int n = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[n];
PrintArray(arr);
ReleaseArray(arr);