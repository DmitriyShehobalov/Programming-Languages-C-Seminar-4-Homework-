// // Задача 29: 
// 1. Напишите программу, которая задаёт массив из 8 элементов и 
// 2. выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void FillArray(int[] arr)
{
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1,100);
    }
}
void PrintArray(int[] arr)
{
  Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
       if(i != arr.Length-1) Console.Write($"{arr[i]}, ");
       else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
int[]array = new int[8];
FillArray(array);
PrintArray(array);