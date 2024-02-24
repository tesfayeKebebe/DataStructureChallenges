using FluentAssertions;

namespace PracticeAlgorithm;

public class Node
{
    public int Value { get; set; }
    public Node? Left { get; set; }
    public Node? Right { get; set; }

    public Node(int value)
    {
        this.Value = value;
    }
}

public class BinaryTreeChallenges
{
    [Fact]
    public void CheckDepthTransversal()
    {
        var a1 = new Node(3);
        var b1 = new Node(11);
        var c1 = new Node(4);
        var d1 = new Node(4);
        var e1 = new Node(-2);
        var f1 = new Node(1);
        a1.Left = b1;
        a1.Right = c1;
        b1.Left = d1;
        b1.Right = e1;
        c1.Right = f1; 
//                3
//             /    \
//            11     4
//           /  \     \
//          4   -2     1

     var result=   DepthTransversal(a1);
     result.Should().BeEquivalentTo(new List<int>(){3,11,4,-2,4,1});
     //sum
     var sum = RecursiveSum(a1);
     sum.Should().Be(21);
     var target = TargetValue(a1, -2);
     target.Should().Be(true);
     var target1 = TargetValue(a1, 2);
     target1.Should().Be(false);
     var target2 = TargetValue(null, 2);
     target1.Should().Be(false);
     var min = MinValue(a1);
     min.Should().Be(-2);
     var max = MaxValue(a1);
     max.Should().Be(11);
    }

    private List<int> DepthTransversal(Node? root)
    {
        if (root == null) return  new List<int>();
        var list = new List<int>();
        var stack = new Stack<Node>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            var current = stack.Pop();
                list.Add(current.Value);
            if(current.Right!=null)stack.Push(current.Right);
            if(current.Left!=null)stack.Push(current.Left);
           
        }
        return list;



    }
    private int RecursiveSum(Node? root)
    {
        if (root == null) return 0;
        // var sum = 0;
        // var stack = new Stack<Node>();
        // stack.Push(root);
        // while (stack.Count >0)
        // {
        //     var current = stack.Pop();
        //     sum += current.Value;
        //     if(current.Right!=null) stack.Push(current.Right);
        //     if(current.Left!=null) stack.Push(current.Left);
        //
        // }
        return root.Value + RecursiveSum(root.Left) + RecursiveSum(root.Right);
    }
    private bool TargetValue(Node? root, int k)
    {
        if (root == null) return false;
        var stack = new Stack<Node>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            var current = stack.Pop();
            if (current.Value == k) return true;
            if(current.Right!=null) stack.Push(current.Right);
            if(current.Left!=null) stack.Push(current.Left);
        }
        return false;
    }

    private int MaxValue(Node? root)
    {
        if (root == null) return 0;
        // var stack = new Stack<Node>();
        // stack.Push(root);
        // var max = root.Value;
        // while (stack.Count > 0)
        // {
        //     var current = stack.Pop();
        //     if (current.Value > max) max = current.Value;
        //     if(current.Left!=null) stack.Push(current.Left);
        //     if(current.Right!=null) stack.Push(current.Right);
        // }
        //return max;
        return  new int[] {root.Value,MaxValue(root.Left), MaxValue(root.Right)}.Max();
    }
    private int MinValue(Node? root)
    {
        if (root == null) return 0;
        var stack = new Stack<Node>();
        stack.Push(root);
        var min = root.Value;
        while (stack.Count > 0)
        {
            var current = stack.Pop();
            if (current.Value < min) min = current.Value;
            if(current.Left!=null) stack.Push(current.Left);
            if(current.Right!=null) stack.Push(current.Right);
        }
        return min;
    }
    
    
    
}
