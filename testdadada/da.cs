using System;
using System.Collections.Generic;

class Program
{
    public static (double sumOddIndices, double productNegative, List<string> errors) ProcessArray(double[] arr)
    {
        double sumOddIndices = 0;  // Сумма элементов с нечётными индексами
        double productNegative = 1; // Произведение отрицательных элементов
        List<string> errors = new List<string>(); // Список ошибок

        if (arr == null || arr.Length == 0)
        {
            errors.Add("Массив пустой или равен null.");
            return (0, 0, errors);
        }

        bool hasNegative = false; // Флаг для проверки наличия отрицательных элементов

        for (int i = 0; i < arr.Length; i++)
        {
            // Сумма элементов с нечётными индексами
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

        // Если отрицательных элементов не было, возвращаем 0 как произведение
        if (!hasNegative)
        {
            productNegative = 0;
        }

        return (sumOddIndices, productNegative, errors);
    }

    public static void Main(string[] args)
    {
        // Пример массива
        double[] arr = { 1.5, -2.3, 4.1, -5.6, 7.0, -8.9 };

        var result = ProcessArray(arr);

        // Вывод результатов
        Console.WriteLine($"Сумма элементов с нечётными индексами: {result.sumOddIndices}");
        Console.WriteLine($"Произведение отрицательных элементов: {result.productNegative}");

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
