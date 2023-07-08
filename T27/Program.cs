// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// =======================
int SumDigit(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    
    return result;
}
// =======================

Console.Write("Введите целое положительное число a: ");
int number = Convert.ToInt32(Console.ReadLine());

int N = SumDigit(number);
Console.WriteLine($"Сумма цифр числа {number} = {N}");
