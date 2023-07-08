// Напишите программу, которая принимает на вход число
// и выдает количество цифр в числе.

// =======================
int CountDigit(int num)
{
    int result = 0;
    while (num != 0)
    {
        num = num / 10;
        result += 1; 
    }
    return result == 0 ? 1 : result;
}
// =======================

Console.WriteLine("Введите целое число:");
Console.Write("N = ");
int number = Convert.ToInt32(Console.ReadLine());

int N = CountDigit(number);
Console.WriteLine($"Количество цифр в числе {number} = {N}");
