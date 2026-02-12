using LeetCode.Logic.Arrays.Easy;
using Xunit;

namespace LeetCode.Tests.Arrays.Easy;

public class RemoveDuplicatesTests
{
    private readonly RemoveDuplicatesSolution _solution;

    public RemoveDuplicatesTests()
    {
        _solution = new RemoveDuplicatesSolution();
    }

    [Theory]
    [InlineData(new int[] { 1, 1, 2 }, 2, new int[] { 1, 2 })]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5, new int[] { 0, 1, 2, 3, 4 })]
    [InlineData(new int[] { 1 }, 1, new int[] { 1 })]
    [InlineData(new int[] { }, 0, new int[] { })]
    public void RemoveDuplicates_ShouldReturnCorrectCountAndArray(int[] nums, int expectedK, int[] expectedNums)
    {
        // Act
        int k = _solution.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(expectedK, k);

        // Vi kollar bara de första k elementen enligt LeetCodes instruktioner
        for (int i = 0; i < k; i++)
        {
            Assert.Equal(expectedNums[i], nums[i]);
        }
    }
}