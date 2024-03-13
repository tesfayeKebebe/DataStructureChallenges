using System.Runtime.InteropServices;
using System.Text;
using FluentAssertions;

namespace PracticeAlgorithm;

public class StringChallenges
{
    private static string TitleCase(string str)
    {
        var formatStr = str.ToLower();
        var arrStr = formatStr.Split(" ");
        var newStr = new StringBuilder();
        foreach (var t in arrStr)
        {
            newStr.Append(char.ToUpperInvariant(t[0])).Append(t[1..]).Append(' ');
        }

        return newStr.ToString().Trim();
    }

    [Fact]
    public void CheckTitleCase()
    {
        var tittles = TitleCase("I'm a little tea pot");
        tittles.Should().Be("I'm A Little Tea Pot");
    }

    [Fact]
    public void TestRemoveFalsyValues()
    {
        var results = RemoveFalsyValues(new List<object> { 7, "ate", "", false, 9 });
        results.Should().BeEquivalentTo(new List<object> { 7, "ate", 9 });
    }

    private static IEnumerable<object> RemoveFalsyValues(IReadOnlyList<object> arr)
    {
        var result = new List<object>();
        for (var i = 0; i < arr.Count; i++)
        {
            if (!CheckFalsy(arr[i]))
            {
                result.Add(arr[i]);
            }
        }

        return result;
    }

    private static bool CheckFalsy(object? item)
    {
        return item is null or bool and false or string and "" or int and 0 or double and double.NaN;
    }
    [Fact]
    public void CheckAnagram()
    {
        var anagram = IsAnagram("listen", "silent");
        anagram.Should().Be(true);
    }
    [Fact]
    public void Reverse_ShouldBe_ReverseGivenString()
    {
        var result = Reverse("Tesfaye");
        result.Should().Be("eyafseT");
    }

    [Theory]
    [InlineData("}][}}(}][))][](){()}()({}([][]))[](){)[](}]}]}))}(())(([[)", "NO")]
    [InlineData("[](){()}", "YES")]
    public void IsBalance_ShouldBe_ChartersMustBeBalanced(string input, string expected)
    {
        var result = IsBalanced(input);
        result.Should().Be(expected);
    }

    [Fact]
    public void CheckSubstring()
    {
        var result = GetSubstring("wxyz");

    }

    [Fact]
    public void RemoveCapitalShouldRemoveCapitalLetterFromString()
    {
        // Given
        var s1 = "fOrEver";
        // When
        var result1 = RemoveCapital(s1);
        // Then
        result1.Should().Be("frver");
    }
    [Fact]
    public void EndsWithlyShouldReturnTrueWhenStringEndsWithlyElseItShouldReturnFalse()
    {
        EndsWithly("pretty").Should().Be(false);
        EndsWithly("timidly").Should().Be(true);
        EndsWithly("gallantly").Should().Be(true);
    }
    public void CheckLongestPalindrome()
    {
        var result = LongestPalindrome("abacdfgdcaba");
    }
    private static bool IsAnagram(string s1, string s2)
    {
        if (s2.Length != s1.Length)
        {
            return false;
        }

        var chars = new Dictionary<char, int>();
        foreach (var letter in s1.ToLower().Where(letter => char.IsLetter(letter)))
        {
            if (!chars.ContainsKey(letter))
            {
                chars[letter] = 1;
            }
            else
            {
                chars[letter]++;
            }
        }

        foreach (var letter in s2.ToLower().Where(letter => char.IsLetter(letter)))
        {
            if (!chars.ContainsKey(letter))
            {
                return false;
            }

            chars[letter]--;
        }

        return chars.Values.All(x => x == 0);
    }
    private static string Reverse(string s)
    {
        var start = 0;
        var end = s.Length - 1;
        var stringArray = s.ToCharArray();
        while (start <= end)
        {
            // var temp = stringArray[start];
            // stringArray[start] = stringArray[end];
            // stringArray[end] = temp;
            (stringArray[start], stringArray[end]) = (stringArray[end], stringArray[start]);
            start++;
            end--;
        }

        return new string(stringArray);
    }
    private static string IsBalanced(string s)
    {
        var stacks = new Stack<char>();
        foreach (var c in s)
        {
            switch (c)
            {
                case '{':
                case '[':
                case '(':
                    stacks.Push(c);
                    break;
                case '}':
                case ']':
                case ')':
                    {
                        if (stacks.Count == 0)
                        {
                            return "NO";
                        }
                        var top = stacks.Pop();
                        if ((c == '}' && top != '{') || (c == ']' && top != '[') || (c == ')' && top != '('))
                        {
                            return "NO";
                        }

                        break;
                    }
            }
        }


        return stacks.Count == 0 ? "YES" : "NO";


    }

    private static List<string> GetSubstring(string str)
    {
        var strList = new List<string>();
        for (var i = 0; i < str.Length; i++)
        {
            for (var j = i + 1; j <= str.Length; j++)
            {
                var sub = str.Substring(i, j - i);
                if (sub != "")
                    strList.Add(sub);
            }
        }
        return strList;
    }
    private string RemoveCapital(string str)
    {
        var newStr = "";
        var strArr = str.ToCharArray();
        foreach (var c in strArr)
        {
            if (c != char.ToUpperInvariant(c))
            {
                newStr += c.ToString();
            }
        }
        return newStr;
    }
    private bool EndsWithly(string str)
    {
        if (str.Length < 2) return false;
        var sub = str.Substring(str.Length - 2);
        return sub == "ly" ? true : false;
    }
    private string? LongestPalindrome(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return null;
        }
        if (s.Length == 1)
        {
            return s;
        }
        var longest = s.Substring(0, 1);
        for (var i = 0; i < s.Length; i++)
        {
            var tem = HelperForLongestPalindrome(s, i, i);
            if (tem.Length > longest.Length)
            {
                longest = tem;
            }
            var tem2 = HelperForLongestPalindrome(s, i, i + 1);
            if (tem2.Length > longest.Length)
            {
                longest = tem2;
            }

        }
        return longest;

    }
    private string HelperForLongestPalindrome(string s, int begin, int end)
    {
        while (begin >= 0 && end <= s.Length - 1 && s[begin] == s[end])
        {
            begin--;
            end++;
        }
        return s.Substring(begin + 1, end - begin - 1);
    }
    [Fact]
    public void RemoveVowelsTakesstringAsArguamentAndShouldReturnOnlyConsonents()
    {
        RemoveVowels("jello").Should().Be("jll");
        RemoveVowels("sensitivity").Should().Be("snstvty");
        RemoveVowels("cellar door").Should().Be("cllr dr");
    }
    private string RemoveVowels(string str)
    {
        var chars = str.ToLower().ToCharArray();
        var builder = new StringBuilder();
        var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        foreach (var c in chars)
        {
            if (!vowels.Contains(c))
            {
                builder.Append(c);
            }
        }
        return builder.ToString();
    }
    [Fact]
    public void ShortLongWordsAcceptSringAsArguamentAndShouldReturnStringWithRemovedVowelsOfStringLengthGreatherthanFourLength()
    {
        ShortLongWords("they are very noble people").Should().Be("they are very nbl ppl");
        ShortLongWords("stick with it").Should().Be("stck with it");
        ShortLongWords("ballerina, you must have seen her").Should().Be("bllrn, you must have seen her");

    }
    private string ShortLongWords(string str)
    {
        string word = "";
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        foreach (string s in str.Split(" "))
        {
            if (s.Length > 4)
            {
                string newWOrd = "";
                foreach (char c in s.ToLower().ToCharArray())
                {
                    if (!vowels.Contains(c))
                    {
                        newWOrd += c;
                    }
                }
                word += newWOrd + " ";
            }
            else
            {
                word += s + " ";
            }

        }
        return word.Trim();
    }

}