// // Задача 25: 
// 1.Напишите цикл, который принимает на вход два числа (A и B) и
// 2.возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Enter first number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int RaisedToThePower(int num, int num2)
{
    int raised = num;
    for (int i = 1; i < num2; i++)
    {
        raised = raised * num;
    }
    return raised;
}
int result = RaisedToThePower(number, number2);
Console.WriteLine($"The number {number} raised to the power {number2} = {result}");