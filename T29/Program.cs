// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// =======================
void PrintRndArray(int num)
{
    int[] arrayNums = new int[num];
    for (int i = 0; i < arrayNums.Length; i ++)
    {
        arrayNums[i] = new Random().Next(100);
        // Console.Write($" arr[{i}]={arrayNums[i]} ");
        Console.Write($"{arrayNums[i]} ");
    }
    
}
// =======================
Console.Write("Введите размерность массива :");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    PrintRndArray(number);
}
else 
    Console.Write("Ошибка ввода");