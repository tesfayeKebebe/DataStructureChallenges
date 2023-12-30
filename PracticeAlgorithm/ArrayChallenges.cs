
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
  

}