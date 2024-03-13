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
    [Fact]
    public void CheckArrayRotation2()
    {
        var list = new List<int>() {1, 2, 3, 4, 5, 6, 7};
         RotateArray(list,3);
         list.Should().BeEquivalentTo(new List<int>(){7,6,5,1,2,3,4}); 
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
                if (string.CompareOrdinal(strgs[i] , strgs[j]) <0)
                {
                    (strgs[i], strgs[j]) = (strgs[j], strgs[i]);
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
    private void RotateArray(IList<int> arr, int k)
    {
        if (k > arr.Count)
            k = k% arr.Count;
        for (var i = 0; i < k; i++)
        {
            for (var j = arr.Count - 1; j > 0; j--)
            {
                (arr[j - 1], arr[j]) = (arr[j], arr[j - 1]);
            }
            
        }
    }
    
    public IList<IList<int>> PermuteUnique(int[] nums) {
        List<IList<int>> permution = new List<IList<int>>();

        return permution;
    }
    private void BackTracking( List<List<int>> res, int[] nums, Dictionary<int, bool>  used)
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
        for(int i=0; i<newArr.Length; i++)
        {
            if(i%2==0)
            {
                result.Add(newArr[i].ToLower());
            }
            else{
                 result.Add(newArr[i].ToUpper());
            }
        }
        return string.Join(" ", result);

    }
    [Fact]
    public void CommonElementsShouldReturnCommonElementsOfAnyTypes()
    {
      
        string[] arr1 = new string[]{"a", "c", "d", "b"};
        string[] arr2 = new string []{"b", "a", "y"};
        CommonElements(arr1, arr2).Should().BeEquivalentTo(new string[] {"a", "b"}); 
         int[] arr3 = new int[]{4, 7};
         int[] arr4 = new int []{32, 7, 1, 4};
        CommonElements(arr3, arr4).Should().BeEquivalentTo(new int[] {4,7}); 
    }
    private T[] CommonElements<T> (T[] arr1, T[] arr2)
    {
        var result = new List<T>();
        foreach(var arr in arr1)
        {
            var foundInResult = result.FirstOrDefault(x=>EqualityComparer<T>.Default.Equals(x, arr));
             var foundInArr2 = arr2.FirstOrDefault(x=>EqualityComparer<T>.Default.Equals(x, arr));
           if ((foundInResult == null || EqualityComparer<T>.Default.Equals(foundInResult, default(T))) &&
            (foundInArr2 != null && !EqualityComparer<T>.Default.Equals(foundInArr2, default(T))))
            {
                result.Add(arr);
            }
        }
        return result.ToArray();
    }
    [Theory]
    [InlineData(new int[]  {1, 2, 3, 4}, 2)]
    [InlineData(new int[] { 1, 2, 3, 4, 5}, 2)]
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
         
         int startIndex =0;
         var result = new List<List<int>>();
         while(startIndex < arr.Length)
         {
             int newSize = Math.Min(size, arr.Length - startIndex);
            var destination = new int [newSize];
            Array.Copy(arr, startIndex, destination, 0, newSize);
            result.Add(destination.ToList());
            startIndex+=newSize;
         }

    
    }
}

