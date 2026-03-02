using LeetCode.Logic.Arrays.Easy;
using Xunit;

namespace LeetCode.Tests.Arrays.Easy;

public class BestTimeToBuyAndSellStock2Tests
{
    private readonly BestTimeToBuyAndSellStock2Solution _solution;

    public BestTimeToBuyAndSellStock2Tests()
    {
        _solution = new BestTimeToBuyAndSellStock2Solution();
    }

    [Theory]
    [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
    [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
    [InlineData(new int[] { 1 }, 0)]
    [InlineData(new int[] { 1, 2 }, 1)]
    public void MaxProfit_ShouldReturnCorrectProfit(int[] prices, int expectedProfit)
    {
        // Act
        int result = _solution.MaxProfit(prices);

        // Assert
        Assert.Equal(expectedProfit, result);
    }
}
