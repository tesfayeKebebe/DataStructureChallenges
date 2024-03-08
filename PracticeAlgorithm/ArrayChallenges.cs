using System;

using FluentAssertions;

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
        var result = SortString(new List<string>() {"abc","bca", "aba"});
        result.Should().BeEquivalentTo(new List<string>() {"aba","abc", "bca"});
    }
    [Fact]
    public void CheckArrayRotation()
    {
      var nums=  new int[] { 1,2,3,4,5,6};
      var k= 3;
        RotateArrayToRight(nums, k);
        nums.Should().BeEquivalentTo(new int[] { 4,5, 6, 1, 2, 3 });
    }
    [Fact]
    public void EvaluateReversePolishNotation()
    {
        var arr = new string[] { "2", "1", "+", "3", "*" };
       var result= ReversePolish(arr);
        result.Should().Be(9);
        var arr2 = new string[] { "4", "13", "5", "/", "+" };
        var result2 = ReversePolish(arr2);
        result2.Should().Be(6);
    }
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Merge_ShouldBe_RemoveAndOrderData(List<int> l1, List<int>l2, List<int>list)
    {
        var result = MergeListUsingSet(l1, l2);
        result.Should().BeEquivalentTo(list);
    }
    private  IEnumerable<int> MergeListUsingSet(IEnumerable<int> l1, IEnumerable<int> l2)
    {
        var set = new HashSet<int>();
        set.UnionWith(l1);
        set.UnionWith(l2);
        return  set.OrderBy(x => x).ToList();
    }

    public static IEnumerable<object[]> GetTestData()
    {
       yield return new object[]
       {
           new List<int> {2, 8, 1, 8}, new List<int> {2, 9, 0, 10}, new List<int> {0, 1, 2, 8, 9, 10},
       };
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
                    var temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
         
        }
        return nums;
    }
    private List<string> SortString(List<string> strgs)
    {
        for (int i = 0; i < strgs.Count; i++)
        {
            for (int j = 0; j < strgs.Count; j++)
            {
                if (String.CompareOrdinal(strgs[i] , strgs[j]) <0)
                {
                    var temp = strgs[i];
                    strgs[i] = strgs[j];
                    strgs[j] = temp;
                }
            }
         
        }
        return strgs;
    }
      private void RotateArrayToRight(int[] nums, int k)
    {
           if(nums.Count()<k)
        {
            k%=nums.Count();
        }
        //divide array into two parts 
        //rotate the first part
        //rotate the second part
        //rotate the whole array

        int a = nums.Length -k;
        Reverse(nums, 0, a-1);
        Reverse(nums, a, nums.Length-1);
        Reverse(nums, 0, nums.Length-1);
    }
     private void Reverse(int[] nums, int left, int right)
    {
        while (left<right)
        {
            var temp = nums[left];
            nums[left] = nums[right];
            nums[right]= temp;
            left++;
            right--;
        }
    }
        ///  Naive Approach
       ///that this problem can be solved by using a stack.We can loop through each element
       //in the given array.When it is a number, push it to the stack.When it is an operator,
       //pop two numbers from the stack, do the calculation, and push back the result.
    private int ReversePolish(string[] arr)
    {
        
        var stack = new Stack<int>();
        foreach(var item in arr)
        {
            if(item=="+" || item=="/" || item=="*" || item=="-")
            {
                switch (item)
                {
                    case "+":
                        {
                            var num1 = stack.Pop();
                            var num2 = stack.Pop();
                            stack.Push(num1+num2);
                        }
                        break;
                    case "/":
                        {
                            var num1 = stack.Pop();
                            var num2 = stack.Pop();
                            stack.Push(num2/num1);
                        }
                      
                        break;
                    case "*":
                        {
                            var num1 = stack.Pop();
                            var num2 = stack.Pop();
                            stack.Push(num1*num2);
                        }
                        break;
                    case "-":
                        {
                            var num1 = stack.Pop();
                            var num2 = stack.Pop();
                            stack.Push(num2-num1);
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
private string BeepVowels (string str)
{
      var strToLower = str.ToLower().ToCharArray();
     string newString ="";
     char[] vowels = new char [] {'a', 'e', 'i', 'o', 'u'};
    foreach(char c in strToLower)
    {
        int index = Array.IndexOf(vowels, c);
        if(index >-1)
        {
            newString+='*'.ToString();
        }
        else
        {
            newString+=c.ToString();  
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
     string acronomy ="";
    foreach(string c in str.ToUpper().Split(" "))
    {
        acronomy += c.Substring(0,1);
    }
  return acronomy;
}
[Fact]
public void TestName()
{
    WordCount("open the window please", new string [] {"please", "open", "sorry"}).Should().Be(2);
    WordCount("drive to the cinema", new string [] {"the", "driver"}).Should().Be(1);
    WordCount("can I have that can", new string [] {"can", "I"}).Should().Be(3);
}
private int WordCount(string str, string[] arr)
{
    var words = str.Split(" ");
    int count =0;
    foreach(string x in words)
    {
        int index = Array.IndexOf(arr, x);
        if(index >-1)count++;
    }
    return count;
}

}

  

