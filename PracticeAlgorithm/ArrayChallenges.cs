using System;
using FluentAssertions;
using System.Collections.Generic;
namespace PracticeAlgorithm;

public class ArrayChallenges
{
    [Fact]
    public void MethodCaller()
    {
        var sum = SumOfEvenNumber(new int[] {2, 8, 1, 4, 3});
        sum.Should().Be(14);
    }

    [Fact]
    public void CheckSortNumber()
    {
        var result = SortNumber(new List<int>() {5, 8, 4, 1});
        result.Should().BeEquivalentTo(new List<int>() {1, 4, 5, 8});
    }

    [Fact]
    public void CheckSortString()
    {
        var result = SortString(new List<string>() {"abc", "bca", "aba"});
        result.Should().BeEquivalentTo(new List<string>() {"aba", "abc", "bca"});
    }

    [Fact]
    public void CheckArrayRotation()
    {
        var nums = new int[] {1, 2, 3, 4, 5, 6};
        var k = 3;
        RotateArrayToRight(nums, k);
        nums.Should().BeEquivalentTo(new int[] {4, 5, 6, 1, 2, 3});
    }

    [Fact]
    public void EvaluateReversePolishNotation()
    {
        var arr = new string[] {"2", "1", "+", "3", "*"};
        var result = ReversePolish(arr);
        result.Should().Be(9);
        var arr2 = new string[] {"4", "13", "5", "/", "+"};
        var result2 = ReversePolish(arr2);
        result2.Should().Be(6);
    }

    [Fact]
    public void CheckArrayRotation2()
    {
        var list = new List<int>() {1, 2, 3, 4, 5, 6, 7};
        RotateArray(list, 3);
        list.Should().BeEquivalentTo(new List<int>() {7, 6, 5, 1, 2, 3, 4});
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Merge_ShouldBe_RemoveAndOrderData(List<int> l1, List<int> l2, List<int> list)
    {
        var result = MergeListUsingSet(l1, l2);
        result.Should().BeEquivalentTo(list);
    }

    private IEnumerable<int> MergeListUsingSet(IEnumerable<int> l1, IEnumerable<int> l2)
    {
        var set = new HashSet<int>();
        set.UnionWith(l1);
        set.UnionWith(l2);
        return set.OrderBy(x => x).ToList();
    }

    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[]
        {
            new List<int> {2, 8, 1, 8}, new List<int> {2, 9, 0, 10}, new List<int> {0, 1, 2, 8, 9, 10},
        };
    }
    [Theory]
    [InlineData(new int[]{1,2,3,0,0,0}, 3, new int[]{2,5,6}, 3)]
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var merged = new int[m+n];
        var newNum1s= new int [m];
        var newNum2s= new int [n];
        for(int i =0; i<m; i++)
        {
            newNum1s[i]= nums1[i];
        }
        for(int i =0; i<n; i++)
        {
            newNum2s[i]= nums2[i];
        }
        
        merged= newNum1s.Concat(newNum2s).ToArray();
        Array.Sort(merged);
    }
    [Theory]
    [InlineData(new int[]{3,2,2,3}, 3)]
    public int RemoveElement(int[] nums, int val) {
        int index =0;
        for(int i =0; i<nums.Length; i++)
        {
            if(nums[i]!=val)
            {
                nums[index]=nums[i];
                index++;
            }
        }
        return index;
    }
    [Theory]
    [InlineData(new int[]{3,2,2,3})]
    public int RemoveDuplicates(int[] nums) {
        List<int> expectedNums = new List<int>();
        foreach(var num in nums)
        {
            if(!expectedNums.Contains(num))
            {
                expectedNums.Add(num) ;
            }
        }
        nums = expectedNums.ToArray();
        return nums.Length;
     
    }
    private static int SumOfEvenNumber(int[] nums)
    {
        return nums.Where(num => num % 2 == 0).Sum();
    }

    private List<int> SortNumber(List<int> nums)
    {
        for (int i = 0; i < nums.Count; i++)
        {
            for (int j = 0; j < nums.Count; j++)
            {
                if (nums[i] < nums[j])
                {
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                }
            }
        }

        return nums;
    }

    private IEnumerable<string> SortString(IList<string> strgs)
    {
        for (var i = 0; i < strgs.Count; i++)
        {
            for (var j = 0; j < strgs.Count; j++)
            {
                if (string.CompareOrdinal(strgs[i], strgs[j]) < 0)
                {
                    (strgs[i], strgs[j]) = (strgs[j], strgs[i]);
                }
            }
        }

        return strgs;
    }

    private void RotateArrayToRight(int[] nums, int k)
    {
        if (nums.Count() < k)
        {
            k %= nums.Count();
        }
        //divide array into two parts 
        //rotate the first part
        //rotate the second part
        //rotate the whole array

        int a = nums.Length - k;
        Reverse(nums, 0, a - 1);
        Reverse(nums, a, nums.Length - 1);
        Reverse(nums, 0, nums.Length - 1);
    }

    private void Reverse(int[] nums, int left, int right)
    {
        while (left < right)
        {
            (nums[left], nums[right]) = (nums[right], nums[left]);
            left++;
            right--;
        }
    }
    [Theory]
    [MemberData(nameof(GetRotateTestData))]
    public void Rotate(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = i + 1; j < matrix.Length; j++)
            {
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            }
        }

        foreach (var row in matrix)
        {
            Array.Reverse(row);
        }
        
    }
    public static IEnumerable<object[]> GetRotateTestData()
    {
        yield return new object[] 
        { 
            new int[][] 
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            }
        };
    }
    ///  Naive Approach
    ///that this problem can be solved by using a stack.We can loop through each element
    //in the given array.When it is a number, push it to the stack.When it is an operator,
    //pop two numbers from the stack, do the calculation, and push back the result.
    private int ReversePolish(string[] arr)
    {
        var stack = new Stack<int>();
        foreach (var item in arr)
        {
            if (item == "+" || item == "/" || item == "*" || item == "-")
            {
                switch (item)
                {
                    case "+":
                    {
                        var num1 = stack.Pop();
                        var num2 = stack.Pop();
                        stack.Push(num1 + num2);
                    }
                        break;
                    case "/":
                    {
                        var num1 = stack.Pop();
                        var num2 = stack.Pop();
                        stack.Push(num2 / num1);
                    }

                        break;
                    case "*":
                    {
                        var num1 = stack.Pop();
                        var num2 = stack.Pop();
                        stack.Push(num1 * num2);
                    }
                        break;
                    case "-":
                    {
                        var num1 = stack.Pop();
                        var num2 = stack.Pop();
                        stack.Push(num2 - num1);
                    }
                        break;
                }
            }
            else
            {
                stack.Push(Convert.ToInt32(item));
            }
        }

        return stack.Pop();
    }

    [Fact]
    public void BeepVowelsShouldReturnVowelsReplacedByAstrix()
    {
        BeepVowels("skateboard").Should().Be("sk*t*b**rd");
        BeepVowels("slipper").Should().Be("sl*pp*r");
        BeepVowels("brisk morning").Should().Be("br*sk m*rn*ng");
    }

    private string BeepVowels(string str)
    {
        var strToLower = str.ToLower().ToCharArray();
        string newString = "";
        char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u'};
        foreach (char c in strToLower)
        {
            int index = Array.IndexOf(vowels, c);
            if (index > -1)
            {
                newString += '*'.ToString();
            }
            else
            {
                newString += c.ToString();
            }
        }

        return newString;
    }

    [Fact]
    public void CreateAcronomyShouldBeReturnAcronomyOfTheSentence()
    {
        CreateAcronomy("New York").Should().Be("NY");
        CreateAcronomy("same stuff different day").Should().Be("SSDD");
        CreateAcronomy("Laugh out loud").Should().Be("LOL");
        CreateAcronomy("don't over think stuff").Should().Be("DOTS");
    }

    private string CreateAcronomy(string str)
    {
        string acronomy = "";
        foreach (string c in str.ToUpper().Split(" "))
        {
            acronomy += c.Substring(0, 1);
        }

        return acronomy;
    }

    [Fact]
    public void TestName()
    {
        WordCount("open the window please", new string[] {"please", "open", "sorry"}).Should().Be(2);
        WordCount("drive to the cinema", new string[] {"the", "driver"}).Should().Be(1);
        WordCount("can I have that can", new string[] {"can", "I"}).Should().Be(3);
    }

    private int WordCount(string str, string[] arr)
    {
        var words = str.Split(" ");
        int count = 0;
        foreach (string x in words)
        {
            int index = Array.IndexOf(arr, x);
            if (index > -1) count++;
        }

        return count;
    }

    private void RotateArray(IList<int> arr, int k)
    {
        if (k > arr.Count)
            k = k % arr.Count;
        for (var i = 0; i < k; i++)
        {
            for (var j = arr.Count - 1; j > 0; j--)
            {
                (arr[j - 1], arr[j]) = (arr[j], arr[j - 1]);
            }
        }
    }

    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        List<IList<int>> permution = new List<IList<int>>();

        return permution;
    }

    private void BackTracking(List<List<int>> res, int[] nums, Dictionary<int, bool> used)
    {
    }

    [Fact]
    public void AlternatingCapsShouldBeAlteringTheSentenceStartingByLoweringTheWordIfNumberIsEven()
    {
        AlternatingCaps("take them to school").Should().Be("take THEM to SCHOOL");
        AlternatingCaps("What did ThEy EAT before?").Should().Be("what DID they EAT before?");
    }

    private string AlternatingCaps(string str)
    {
        var newArr = str.Split(" ");
        var result = new List<string>();
        for (int i = 0; i < newArr.Length; i++)
        {
            if (i % 2 == 0)
            {
                result.Add(newArr[i].ToLower());
            }
            else
            {
                result.Add(newArr[i].ToUpper());
            }
        }

        return string.Join(" ", result);
    }

    [Fact]
    public void CommonElementsShouldReturnCommonElementsOfAnyTypes()
    {
        string[] arr1 = new string[] {"a", "c", "d", "b"};
        string[] arr2 = new string[] {"b", "a", "y"};
        CommonElements(arr1, arr2).Should().BeEquivalentTo(new string[] {"a", "b"});
        int[] arr3 = new int[] {4, 7};
        int[] arr4 = new int[] {32, 7, 1, 4};
        CommonElements(arr3, arr4).Should().BeEquivalentTo(new int[] {4, 7});
    }

    private T[] CommonElements<T>(T[] arr1, T[] arr2)
    {
        var result = new List<T>();
        foreach (var arr in arr1)
        {
            var foundInResult = result.FirstOrDefault(x => EqualityComparer<T>.Default.Equals(x, arr));
            var foundInArr2 = arr2.FirstOrDefault(x => EqualityComparer<T>.Default.Equals(x, arr));
            if ((foundInResult == null || EqualityComparer<T>.Default.Equals(foundInResult, default(T))) &&
                (foundInArr2 != null && !EqualityComparer<T>.Default.Equals(foundInArr2, default(T))))
            {
                result.Add(arr);
            }
        }

        return result.ToArray();
    }

    [Theory]
    [InlineData(new int[] {1, 2, 3, 4}, 2)]
    [InlineData(new int[] {1, 2, 3, 4, 5}, 2)]
    public void ArrayChunk(int[] arr, int size)
    {
        //   var newArr = arr.ToList();
        //   var twoDList =new List<List<int>>();
        //   int startIndex = 0;
        //   while(startIndex<newArr.Count)
        //   {
        //   var destArray = newArr.ToList().GetRange(startIndex, Math.Min(size, newArr.Count-startIndex));
        //   twoDList.Add(destArray);
        //   startIndex +=size;
        //   }
        //   var lastArray = twoDList.ToArray();
        //Or

        int startIndex = 0;
        var result = new List<List<int>>();
        while (startIndex < arr.Length)
        {
            int newSize = Math.Min(size, arr.Length - startIndex);
            var destination = new int [newSize];
            Array.Copy(arr, startIndex, destination, 0, newSize);
            result.Add(destination.ToList());
            startIndex += newSize;
        }
    }
        [Theory]
        [InlineData("abcdefg",3,new string[]{"abc","de", "fg"})]
        [InlineData("abcdefg",6, new string[]{"ab","c","d","e","f", "g"})]
    public void StringChunks(string s, int chunk, string[] result)
    {
        var length = s.Length;
        var chunkSize = length / chunk;
        var remainder = length % chunk;
        var startIndex = 0;
        var newStr = new string[chunk];
        for (var i = 0; i < chunk; i++)
        {
            var chuckSizeLength = chunkSize;
            if (i < remainder)
            {
                chuckSizeLength++;
            }
            newStr[i] = s.Substring(startIndex, chuckSizeLength);
            startIndex += chuckSizeLength;
        }

        newStr.Should().BeEquivalentTo(result);

    }
    
    [Theory]
    [InlineData(new int[]{7,1,5,3,6,4}, 7)]
    public void CalculateMaxProfitShouldBeEqualToResult(int[] prices, int result) {
        var b=0;
        var profit =0;
        for(var s =1; s<prices.Length; s++ )
        {
            var currentProfit = prices[s] - prices[b];
            if(currentProfit > 0)
            {
                profit += currentProfit;
            } 
            b++;
        }
        profit.Should().Be(result);
    }
    [Theory]
    [InlineData(new int[]{1,2,3,4,5,6,7}, 3)]
    public void RotateToRightByK(int[] nums, int k) {
        //find reminder of k divided by nums.length because k
        //is more than nums.length we don't need to iterate huge iterations.
        // first of all reverse entire the array.
        // reverse the array from 0th index to k-1 index.
        // reverse the array from kth index to array.length-1 index.
        k%=nums.Length;
        ReverseNums(nums, 0, nums.Length-1);
        ReverseNums(nums, 0, k-1);
        ReverseNums(nums, k, nums.Length-1);
    }
    private void ReverseNums(int[] nums, int l, int r)
    {
        while(l<=r)
        {
            var temp = nums[l];
            nums[l]= nums[r];
            nums[r]=temp;
            l++;
            r--;
        }
    }
}