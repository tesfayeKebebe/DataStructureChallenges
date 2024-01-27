
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

    private static int SumOfEvenNumber(IEnumerable<int> nums)
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
  

}