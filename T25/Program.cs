// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// =======================
double Degree(int a, int b)
{
    double result = 1;
     if (b > 0)
    {
        for (int i = 1; i <= b; i ++)
            {
                result = result * a; 
            }
    }
    else if (b < 0)
    {
        b = -1 * b;
        for (int i = 1; i <= b; i ++)
            {
                result = result * a; 
            }
        result = 1 / result;        
    }
    
    
    return result;
}
// =======================

Console.Write("Введите целое число a: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число b: ");
int numB = Convert.ToInt32(Console.ReadLine());

double N = Degree(numA, numB);
Console.WriteLine($"{numA} в степени {numB} = {N}");
