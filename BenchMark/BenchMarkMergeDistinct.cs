using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace BenchMark;
[MemoryDiagnoser]
public class BenchMarkMergeDistinct
{
    [Benchmark]
    public  List<int> MergeListUsingForeach()
    {
        var l1 = new List<int> {2, 8, 1, 8};
        var l2 = new List<int> {2, 9, 0, 10};
        var set = new HashSet<int>();
        foreach (var l in l2)
        {
            set.Add(l);
        }
        foreach (var l in l1)
        {
            set.Add(l);
        }
        return  set.OrderBy(x => x).ToList();
    }
    [Benchmark]
    public  List<int> MergeListUsingSet()
    {
        var l1 = new List<int> {2, 8, 1, 8};
        var l2 = new List<int> {2, 9, 0, 10};
        var set = new HashSet<int>();
        set.UnionWith(l1);
        set.UnionWith(l2);
        return  set.OrderBy(x => x).ToList();
    }
    [Benchmark]
    public List<int> MergeListIntersect()
    {
        var l1 = new List<int> {2, 8, 1, 8};
        var l2 = new List<int> {2, 9, 0, 10};
        var distinct = l1.Intersect(l2);
        return  distinct.OrderBy(x => x).ToList();
    }
}