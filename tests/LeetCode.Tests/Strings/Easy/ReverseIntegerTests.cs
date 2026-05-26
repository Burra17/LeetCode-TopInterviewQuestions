using LeetCode.Logic.Strings.Easy;
using Xunit;

namespace LeetCode.Tests.Strings.Easy;

public class ReverseIntegerTests
{
    private readonly ReverseIntegerSolution _solution;

    public ReverseIntegerTests()
    {
        _solution = new ReverseIntegerSolution();
    }

    [Theory]
    [InlineData(123, 321)]
    [InlineData(-123, -321)]
    [InlineData(120, 21)]
    [InlineData(0, 0)]
    [InlineData(7, 7)]
    [InlineData(-7, -7)]
    [InlineData(1000, 1)]
    [InlineData(-1000, -1)]
    [InlineData(1534236469, 0)]
    [InlineData(-2147483648, 0)]
    [InlineData(2147483647, 0)]
    [InlineData(1463847412, 2147483641)]
    [InlineData(-1463847412, -2147483641)]
    public void Reverse_ShouldReturnReversedInteger(int x, int expected)
    {
        // Act
        int result = _solution.Reverse(x);

        // Assert
        Assert.Equal(expected, result);
    }
}
