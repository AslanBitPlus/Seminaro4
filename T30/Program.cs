// Напишите программу, которая выводит массив из 8 элементов
// заполненный нулями и единицами в случайном порядке.

// =======================
void PrintRandomArray()
{
    int[] arrayNums = new int[8];
    for (int i = 0; i < 8; i ++)
    {
        arrayNums[i] = new Random().Next(0, 2);
        Console.Write($"{arrayNums[i]} ");
    }
    
}
// =======================

PrintRandomArray();



