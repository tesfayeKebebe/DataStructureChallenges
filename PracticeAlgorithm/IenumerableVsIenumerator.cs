namespace PracticeAlgorithm;

public class IenumerableVsIenumerator
{
     static List<int> lists = new List<int>()
    {
        1, 2, 4
    };
    //IEnumerable used when we want to iterate over collection
    //used in memory collection
     IEnumerable<int> enumerable = lists;
//IQueryable is inherit IEnumerable what IEnumerable does IQueryable also does
      IQueryable<int> iQuaryable =(IQueryable<int>) lists;
   
     //IEnumerable uses internally IEnumerator  to iterate item over the collection
     //IEnumerable simplifies the use of IEnumerator
     //get the result from database
   [Fact]
    public void LoopingUsingForeach()
    {
        foreach (var item in enumerable)
        {
            Console.WriteLine(item);
        }
    }
    [Fact]
    public void LoopingUsingEnumerator()
    {
        var testEnumerator = enumerable.GetEnumerator();
        while (testEnumerator.MoveNext())
        {
            Console.WriteLine(testEnumerator.Current);
        }
    }

}