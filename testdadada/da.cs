using System;
using System.Collections.Generic;

class Program
{
    {
        double sumOddIndices = 0;  // Сумма элементов с нечётными индексами
        double productNegative = 1; // Произведение отрицательных элементов
        List<string> errors = new List<string>(); // Список ошибок


        bool hasNegative = false; // Флаг для проверки наличия отрицательных элементов

        for (int i = 0; i < arr.Length; i++)
        {
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

        // Если есть ошибки, выводим их
        if (result.errors.Count > 0)
        {
            Console.WriteLine("Ошибки:");
            foreach (var error in result.errors)
            {
                Console.WriteLine(error);
            }
        }
    }
}
