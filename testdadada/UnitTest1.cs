using System;
using System.Collections.Generic;
using Xunit;

public class ArrayProcessingTests
{
    // Тест для обычного случая с положительными и отрицательными числами
    [Fact]
    public void Test_NormalCase()
    {
        // Arrange
        double[] arr = { 1.5, -2.3, 4.1, -5.6, 7.0, -8.9 };

        // Act
        var result = Program.ProcessArray(arr);

        // Assert
        Assert.Equal(-16.8, result.sumOddIndices, 1); // Сумма нечётных индексов
        Assert.Equal(-114.632, result.productNegative, 3); // Произведение отрицательных элементов
        Assert.Empty(result.errors); // Ошибок быть не должно
    }

    // Тест для случая с пустым массивом
    [Fact]
    public void Test_EmptyArray()
    {
        // Arrange
        double[] arr = { };

        // Act
        var result = Program.ProcessArray(arr);

        // Assert
        Assert.Equal(0, result.sumOddIndices);
        Assert.Equal(0, result.productNegative);
        Assert.Single(result.errors); // Одна ошибка "Массив пустой или равен null."
        Assert.Equal("Массив пустой или равен null.", result.errors[0]);
    }

    // Тест для массива с положительными числами (отрицательных нет)
    [Fact]
    public void Test_NoNegativeNumbers()
    {
        // Arrange
        double[] arr = { 1.0, 2.0, 3.0, 4.0, 5.0 };

        // Act
        var result = Program.ProcessArray(arr);

        // Assert
        Assert.Equal(6.0, result.sumOddIndices); // Сумма элементов с нечётными индексами
        Assert.Equal(0, result.productNegative);  // Произведение должно быть 0, т.к. отрицательных нет
        Assert.Empty(result.errors); // Ошибок быть не должно
    }

    // Тест для массива с одним элементом
    [Fact]
    public void Test_SingleElementArray()
    {
        // Arrange
        double[] arr = { -5.0 };

        // Act
        var result = Program.ProcessArray(arr);

        // Assert
        Assert.Equal(0, result.sumOddIndices); // Нет нечётных индексов, сумма = 0
        Assert.Equal(-5.0, result.productNegative); // Произведение = -5, так как один элемент
        Assert.Empty(result.errors); // Ошибок быть не должно
    }

    // Тест для массива, состоящего только из положительных и отрицательных дробных чисел
    [Fact]
    public void Test_OnlyNegativeNumbers()
    {
        // Arrange
        double[] arr = { -1.5, -2.5, -3.5, -4.5 };

        // Act
        var result = Program.ProcessArray(arr);

        // Assert
        Assert.Equal(-7.0, result.sumOddIndices); // Сумма нечётных индексов (-2.5 + -4.5)
        Assert.Equal(59.0625, result.productNegative, 3); // Произведение всех отрицательных элементов
        Assert.Empty(result.errors); // Ошибок быть не должно
    }

    // Тест для null массива
    [Fact]
    public void Test_NullArray()
    {
        // Arrange
        double[] arr = null;

        // Act
        var result = Program.ProcessArray(arr);

        // Assert
        Assert.Equal(0, result.sumOddIndices);
        Assert.Equal(0, result.productNegative);
        Assert.Single(result.errors); // Одна ошибка "Массив пустой или равен null."
        Assert.Equal("Массив пустой или равен null.", result.errors[0]);
    }
}
