namespace PracticeAlgorithm;

public class StackChallenges
{
    [Fact]
    public void TestStack()
    {
        MyStack stacks = new();
        stacks.Push(5);
        stacks.Push(3);
        stacks.Push(2);
        var peeked = stacks.Peak();
        var popped = stacks.Pop();
        var peeked2 = stacks.Peak();
        var popped2 = stacks.Pop();
        var peeked3 = stacks.Peak();
        var popped3 = stacks.Pop();
    }

}
public class MyStack
{
    private List<int> Stacks { get; set; } = new();
    private int Top { get; set; } = -1;
    public void Push(int item)
    {
        Stacks.Add(item);
        Top++;
    }
    public int Pop()
    {
        if (Top == -1)
        {
            return -1;
        }
        var topData = Stacks[Top];
         Stacks.RemoveAt(Top);
         Top--;
         return topData;
    }
    public int Peak()
    {
        if (Top == -1)
        {
            return -1;
        }
        var topData = Stacks[Top];
        return topData;
    }
}