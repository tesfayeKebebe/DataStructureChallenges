using FluentAssertions;

namespace PracticeAlgorithm.LeetCode;

public class ProductExceptSelf
{
    //Given an integer array nums, return an array answer such that
    //answer[i] is equal to the product of all the elements of nums except nums[i].
    // The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
    // You must write an algorithm that runs in O(n) time and without using the division operation.
    [Theory]
    [InlineData(new int[] {1, 2, 3, 4}, new int[] {24, 12, 8, 6})]
    public void CheckProductExceptSelf(int[] nums, int[] expected)
    {
        var n = nums.Length;
        var result = new int[n];
        var pref = new int[n];
        var suf = new int[n];
        pref[0] = 1;
        suf[n - 1] = 1;
        for (var i = 1; i < n; i++)
        {
            pref[i] = pref[i - 1] * nums[i - 1];
        }
        for (var i = n - 2; i >= 0; i--)
        {
            suf[i] = suf[i + 1] * nums[i + 1];
        }
        for (var i = 0; i < n; i++)
        {
            result[i] = suf[i] * pref[i];
        }

        result.Should().BeEquivalentTo(expected);
    }
}