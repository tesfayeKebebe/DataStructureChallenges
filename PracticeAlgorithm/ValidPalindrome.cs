using FluentAssertions;

namespace PracticeAlgorithm;


public class ValidPalindrome
{
/// <summary>
/// SOLUTION
/// To solve this problem, we'll use a two-pointer approach. We'll have two pointers, one starting from the beginning and one from the end.
/// We'll move these pointers inwards, skipping non-alphanumeric characters and comparing the valid characters we find. We'll ignore case by converting characters to lowercase when comparing.
/// If at any point the characters don't match, it's not a palindrome.
/// The time complexity of this solution is O(n), where n is the length of the string.
/// </summary>
    [Fact]
    public static void CheckValidPalindromeShouldReturnTrueIfPalindromeElseReturnFalse()
    {
        var result = CheckValidPalindrome("A man, a plan, a canal: Panama");
        result.Should().Be(true);
        var result2 = CheckValidPalindrome("race a car");
        result2.Should().Be(false);
    }
    private static bool CheckValidPalindrome(string s)
    {
        var start = 0;
        var end = s.Length - 1;
        while (start<end)
        {
            if (!char.IsLetterOrDigit(s[start]))
            {
                start++;
            }
            else if (!char.IsLetterOrDigit(s[end]))
            {
                end--;
            }
            else if (char.ToLower(s[start]) != char.ToLower(s[end]))
            {
                return false;
            }
            else
            {
                start++;
                end--;
            }
           

        }
        

        return true;
    }
}