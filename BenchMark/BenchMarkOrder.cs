using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
namespace BenchMark;
[MemoryDiagnoser]
public class BenchMarkOrder
{
    [Benchmark]
    public List<int> OrderNumberUsingLinq()
    {
        var num= new List<int>() { 2, 3, 5, 8, 4, 20, 10 };
        return num.OrderBy(x=>x).ToList();
    }
      [Benchmark]
    public List<int> OrderNumberUsingForLoop()
    {
        var num= new List<int>() { 2, 3, 5, 8, 4, 20, 10 };
        for (int i=0; i<num.Count-1; i++)
        {
            for(int j=0; j<num.Count-1; j++)
            {
                if(num[i]<num[j])
                {
                    var temp = num[i];
                    num[i]=num[j];
                    num[j]=temp;

                }
              
            }
        }
        return num;

    }

}
