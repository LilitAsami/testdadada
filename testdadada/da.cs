using System;

class Program
{
    public static (double sumOddIndices, double productNegative) ProcessArray(double[] arr)
    {
        double sumOddIndices = 0;  // Сумма элементов с нечётными индексами
        double productNegative = 1; // Произведение отрицательных элементов

        bool hasNegative = false;

        for (int i = 0; i < arr.Length; i++)
        {
            // Сумма  элементов с нечётными индексами
            if (i % 2 != 0)
            {
                sumOddIndices += arr[i];
            }
            // Произведение отрицательных элементов
            if (arr[i] < 0)
            {
                productNegative *= arr[i];
                hasNegative = true;
            }
        }
        return (sumOddIndices, productNegative);
    }

    public static void Main(string[] args)
    {
        // Пример массива
        double[] arr = { 1.5, -2.3, 4.1, -5.6, 7.0, -8.9 };

        var result = ProcessArray(arr);

        // Вывод результатов
        Console.WriteLine($"Сумма элементов с нечётными индексами: {result.sumOddIndices}");
        Console.WriteLine($"Произведение отрицательных элементов: {result.productNegative}");
        Console.ReadLine();

    }
}