// Напишите программу, которая принимает на вход число А
// и выдает сумму чисел от 1 до А.

// =======================
int Summa(int num)
{
    int result = 0;
    for (int i = 1; i <= num; i ++)
    {
        // Console.WriteLine($"{count, 3}   {count * count * count, 9}");
        result = result + i;
    }
    return result;
}
// =======================

Console.WriteLine("Введите целое положительное число:");
Console.Write("N = ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) 
{
    int N = Summa(number);
    Console.WriteLine($"Сумма от 1 до {number} = {N}");
}
else Console.WriteLine("Ошибка ввода");