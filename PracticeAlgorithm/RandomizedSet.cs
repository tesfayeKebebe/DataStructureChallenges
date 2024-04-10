namespace PracticeAlgorithm;

public class RandomizedSet
{
    [Fact]
    public void CheckRandomizedSetMethod()
    {
        var results = new List<Object>();
        var randomizeSet = new RandomizedSet();
        results.Add(randomizeSet.GetRandom());
        results.Add(randomizeSet.Insert(1)); 
        results.Add(randomizeSet.Remove(2));
        results.Add(randomizeSet.Insert(2));
        results.Add(randomizeSet.GetRandom());
        results.Add( randomizeSet.Remove(1));
        results.Add(randomizeSet.GetRandom());
        
    }
    private Dictionary<int, int> dic;
    private List<int> list;
    private Random random;
    public RandomizedSet()
    {
        dic = new Dictionary<int, int>();
        list = new List<int>();
        random = new Random();
    }
    
    public bool Insert(int val) {
        if (dic.ContainsKey(val))
        {
            return false;
        }
        dic.Add(val, list.Count);
        list.Add(val);
        return true;
    }
    
    public bool Remove(int val) {
        if (!dic.ContainsKey(val))
        {
            return false;
        }

        var index = dic[val];
        var lastValue = list[list.Count-1];
        dic[lastValue] = lastValue;
        list[index] = lastValue;
        dic.Remove(val);
        list.RemoveAt(list.Count-1);
        // list[index] = 
        return true;
    }
    
    public int? GetRandom()
    {
        var index = random.Next(list.Count);
        if (list.Count == 0) return null;
        return list[index];
    }
}