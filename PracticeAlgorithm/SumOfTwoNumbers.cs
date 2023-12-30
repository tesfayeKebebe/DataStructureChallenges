using FluentAssertions;

namespace PracticeAlgorithm;

public class SumOfTwoNumbers
{
    // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    //     You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //     You can return the answer in any order.
    //     Example 1:
    // Input: nums = [2,7,11,15], target = 9
    // Output: [0,1]
    // Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    // Example 2:
    // Input: nums = [3,2,4], target = 6
    // Output: [1,2]
    // Example 3:
    // Input: nums = [3,3], target = 6
    // Output: [0,1]
    [Fact]
    public void SumOfTwoNumbersEqualToTarget_ReturnIndices()
    {
        //arrange
        var nums = new int[] { 3,2,4};
        const int target = 6;
        var map = new Dictionary<int, int>();
        var indixes = new int[2];
        //act
        for (var i = 0; i <= nums.Length - 1; i++)
        {
            var complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                indixes = new int[] {map[complement], i};
            }
            map[nums[i]] = i;
        }
        var equals = new int[] {1, 2}.SequenceEqual(indixes);
        equals.Should().Be(true);
        
    }
}