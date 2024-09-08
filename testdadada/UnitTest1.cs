using System;
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
        Assert.Equal(-16.8, result.sumOddIndices, 1); // Сумма элементов с нечётными индексами
        Assert.Equal(-114.632, result.productNegative, 3); // Произведение отрицательных элементов
    }

    // Тест для массива без отрицательных чисел
    [Fact]
    public void Test_NoNegativeNumbers()
    {
        // Arrange
        double[] arr = { 1.0, 2.0, 3.0, 4.0, 5.0 };

        // Act
        var result = Program.ProcessArray(arr);

        // Assert
        Assert.Equal(6.0, result.sumOddIndices); // Сумма элементов с нечётными индексами
        Assert.Equal(1, result.productNegative);  // Произведение должно быть 1, т.к. отрицательных нет
    }

    // Тест для пустого массива
    [Fact]
    public void Test_EmptyArray()
    {
        // Arrange
        double[] arr = { };

        // Act
        var result = Program.ProcessArray(arr);

        // Assert
        Assert.Equal(0, result.sumOddIndices); // Сумма = 0
        Assert.Equal(1, result.productNegative);  // Произведение = 1, так как нет отрицательных элементов
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
        Assert.Equal(0, result.sumOddIndices); // Нет нечётных индексов
        Assert.Equal(-5.0, result.productNegative); // Произведение = -5, так как один отрицательный элемент
    }

    // Тест для массива, состоящего только из отрицательных чисел
    [Fact]
    public void Test_OnlyNegativeNumbers()
    {
        // Arrange
        double[] arr = { -1.5, -2.5, -3.5, -4.5 };

        // Act
        var result = Program.ProcessArray(arr);

        // Assert
        Assert.Equal(-7.0, result.sumOddIndices); // Сумма элементов с нечётными индексами (-2.5 + -4.5)
        Assert.Equal(59.0625, result.productNegative, 3); // Произведение всех отрицательных элементов
    }
}
