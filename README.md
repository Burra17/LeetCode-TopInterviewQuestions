# LeetCode - Top Interview Questions

Solutions to [LeetCode's Top Interview Questions](https://leetcode.com/explore/interview/card/top-interview-questions-easy/) collection, implemented in C# (.NET 10).

## Project Structure

```
src/LeetCode.Logic/          # Solutions organized by category and difficulty
    Arrays/
    Strings/
    Linked List/
    Trees/
    Sorting and Searching/
    Dynamic Programming/
    Design/
    Math/
    Others/

tests/LeetCode.Tests/        # xUnit test project mirroring the same structure
```

Each category contains `Easy/`, `Medium/`, and `Hard/` folders.

## Solved Problems

### Arrays - Easy

| Problem | Solution | Tests |
|---------|----------|-------|
| [Remove Duplicates from Sorted Array](https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/727/) | [RemoveDuplicatesSolution.cs](src/LeetCode.Logic/Arrays/Easy/RemoveDuplicatesSolution.cs) | [Tests](tests/LeetCode.Tests/Arrays/Easy/RemoveDuplicatesTests.cs) |
| [Best Time to Buy and Sell Stock II](https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/564/) | [BestTimeToBuyAndSellStock2Solution.cs](src/LeetCode.Logic/Arrays/Easy/BestTimeToBuyAndSellStock2Solution.cs) | [Tests](tests/LeetCode.Tests/Arrays/Easy/BestTimeToBuyAndSellStock2Tests.cs) |
| [Rotate Array](https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/646/) | [RotateArray.cs](src/LeetCode.Logic/Arrays/Easy/RotateArray.cs) | [Tests](tests/LeetCode.Tests/Arrays/Easy/RotateArrayTests.cs) |

## Running

```bash
# Run all tests
dotnet test

# Run a specific test class
dotnet test --filter "RotateArrayTests"
```
