using LeetCode.Logic.Arrays.Easy;
using Xunit;

namespace LeetCode.Tests.Arrays.Easy;

public class ContainsDuplicateTests
{
    private readonly ContainsDuplicateSolution _solution;

    public ContainsDuplicateTests()
    {
        _solution = new ContainsDuplicateSolution();
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    [InlineData(new int[] { 1 }, false)]
    [InlineData(new int[] { }, false)]
    public void ContainsDuplicate_ShouldReturnCorrectResult(int[] nums, bool expected)
    {
        // Act
        bool result = _solution.ContainsDuplicate(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}
