// Напишите программу, которая принимает на вход число N
// и выдает произведение чисел от 1 до N.

// =======================
int Faktorial(int num)
{
    int result = 1;
    for (int i =1; i <= num; i ++)
    {
        result = result * i;
    }
    return result;
}
// =======================

Console.WriteLine("Введите целое число:");
Console.Write("N = ");
int number = Convert.ToInt32(Console.ReadLine());

int N = Faktorial(number);
Console.WriteLine($"Факториал числа {number} = {N}");
