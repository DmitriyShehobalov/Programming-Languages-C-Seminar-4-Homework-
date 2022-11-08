// // Задача 27: 
// 1.Напишите программу, которая принимает на вход число и 
// 2. выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNum(int num)
{
    int sum = 0;
    
    while (num>0)
    {
       int result = num % 10;
        num = num / 10;
        sum = sum + result;
    }
    return sum;
}
int result = SumNum(number);
Console.WriteLine($"Sum of the number {number} = {result}");
