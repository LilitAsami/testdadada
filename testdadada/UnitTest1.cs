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
        Assert.Equal(-114.632, result.productNegative, 3); // Произведение отрицательных элементов
        Assert.Empty(result.errors); // Ошибок быть не должно
    }

    [Fact]
    {
        // Arrange

        // Act
        var result = Program.ProcessArray(arr);

        // Assert
    }

    [Fact]
    {
        // Arrange

        // Act
        var result = Program.ProcessArray(arr);

        // Assert
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
    }

    [Fact]
    public void Test_OnlyNegativeNumbers()
    {
        // Arrange
        double[] arr = { -1.5, -2.5, -3.5, -4.5 };

        // Act
        var result = Program.ProcessArray(arr);

        // Assert
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
