namespace PracticeAlgorithm;

public class StackOf
{
    [Fact]
    public static void StackImplementation()
    {
        var stack = new System.Collections.Generic.Stack<string>();
         stack.Push("first");
         stack.Push("Second");
         string popedItem = null;
         while ((popedItem = stack.Pop())!=null)
         {
             Console.WriteLine(popedItem);
             if (stack.Count <= 0) break;
         }
    }
}