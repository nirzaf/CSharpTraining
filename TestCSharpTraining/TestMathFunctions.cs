using CSharpTraining;

namespace TestCSharpTraining;

public class TestMathFunctions
{
    [Fact]
    public void add_two_positive_integers_returns_correct_sum()
    {
        int result = MathFunctions.Add(4, 5);
        Assert.Equal(9, result);
    }

    [Fact]
    public void add_two_negative_integers_returns_correct_sum()
    {
        int result = MathFunctions.Add(-4, -5);
        Assert.Equal(-9, result);
    }

    [Fact]
    public void add_one_positive_and_one_negative_integer_returns_correct_sum()
    {
        int result = MathFunctions.Add(4, -5);
        Assert.Equal(-1, result);
    }

    [Fact]
    public void add_two_negative_integers_returns_wrong_sum()
    {
         // Arrange
        int expected = -1000;

        // Act
        int result = MathFunctions.Add(-4, -5);

        // Assert
        Assert.NotEqual(expected, result);
    }

    [Fact]
    public void subtract_two_positive_integers_returns_correct_difference()
    {
         int result = MathFunctions.Subtract(4, 5);
        Assert.Equal(-1, result);
    }

    [Fact]
    public void subtract_two_negative_integers_returns_correct_difference()
    {
        int result = MathFunctions.Subtract(-4, -5);
        Assert.Equal(1, result);
    }

    [Fact]
    public void subtract_one_positive_and_one_negative_integer_returns_correct_difference()
    {
        int result = MathFunctions.Subtract(4, -5);
        Assert.Equal(9, result);
    }

    [Fact]
    public void subtract_two_negative_integers_returns_wrong_difference()
    {
        // Arrange
        int expected = -1000;

        // Act
        int result = MathFunctions.Subtract(-4, -5);

        // Assert
        Assert.NotEqual(expected, result);
    }
    
}