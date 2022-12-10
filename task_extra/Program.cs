void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    int x = new Random().Next(1, 32); 
    while (array.Contains(x))
    x = new Random().Next(1, 32); 
    array[i] = x;
    }
}
int Four(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 == 0)
    {
        even = array[i];
    Console.Write($"{string.Join(", ", even)} ");
    }
    }
    return even;
}
int Three(int[] array)
{
    int unEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 != 0)
    {
        unEven = array[i];
    Console.Write($"{string.Join(", ", unEven)} ");
    }
    }
    return unEven;
}


Console.Clear();
Console.Write("Введите кол-во дней: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
int count = 0;
int count2 = 0;
int a = 0;
Console.WriteLine($"Дни: [{string.Join(", ", array)}]");
Four(array); 
Console.WriteLine();
Three(array);
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
if ( array[i] % 2 == 0)
{
   count++;
}

else
{
    count2++;
}
int[] arr2 = new int[count];
int[] arr3 = new int[count2];
if ( arr2.Length > arr3.Length)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}





