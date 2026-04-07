using LeetCode.Logic.Arrays.Easy;
using Xunit;

namespace LeetCode.Tests.Arrays.Easy;

public class RotateArrayTests
{
    private readonly RotateArraySolution _solution;

    public RotateArrayTests()
    {
        _solution = new RotateArraySolution();
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
    [InlineData(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
    [InlineData(new int[] { 1, 2 }, 1, new int[] { 2, 1 })]
    [InlineData(new int[] { 1, 2, 3 }, 4, new int[] { 3, 1, 2 })]
    [InlineData(new int[] { 1 }, 0, new int[] { 1 })]
    public void Rotate_ShouldRotateArrayByKSteps(int[] nums, int k, int[] expected)
    {
        // Act
        _solution.Rotate(nums, k);

        // Assert
        Assert.Equal(expected, nums);
    }
}
