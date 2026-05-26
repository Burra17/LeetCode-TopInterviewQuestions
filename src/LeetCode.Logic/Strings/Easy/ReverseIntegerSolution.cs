namespace LeetCode.Logic.Strings.Easy
{
    public class ReverseIntegerSolution
    {
        // https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/880/

        public int Reverse(int x)
        {
            int reversed = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                // Check for overflow before multiplying by 10
                if (reversed > int.MaxValue / 10 || (reversed == int.MaxValue / 10 && pop > 7))
                    return 0; // Overflow case for positive numbers

                if (reversed < int.MinValue / 10 || (reversed == int.MinValue / 10 && pop < -8))
                    return 0; // Overflow case for negative numbers

                reversed = reversed * 10 + pop;
            }
            return reversed;
        }
    }
}
