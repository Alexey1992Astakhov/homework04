//Напишите программу, которая задаёт массив из 8 элементов и выводит отсортированный по модулю массив.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

 int[] arr = { -54, 7, -41, 2, 4, -2, 89, 33, };
 
int temp;
for (int i = 0; i < arr.Length - 1; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (Math.Abs(arr[i]) > Math.Abs(arr[j]))
        {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
 
Console.WriteLine("Вывод отсортированного массива");
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
    Console.Write(arr[i] + ", ");
    Console.Write("\b\b]");