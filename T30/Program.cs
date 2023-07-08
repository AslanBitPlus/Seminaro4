// Напишите программу, которая выводит массив из 8 элементов
// заполненный нулями и единицами в случайном порядке.

// =======================
void PrintRandomArray(int num)
{
    int[] arrayNums = new int[num];
    for (int i = 0; i < arrayNums.Length; i ++)
    {
        arrayNums[i] = new Random().Next(0, 2);
        // Console.Write($" arr[{i}]={arrayNums[i]} ");
        Console.Write($"{arrayNums[i]} ");
    }
    
}
// =======================
Console.Write("Введите размерность массива :");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    PrintRandomArray(number);
}




