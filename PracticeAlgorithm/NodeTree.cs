namespace PracticeAlgorithm;

public class NodeTree
{
    public int  Key { get; set; }
    public string Value { get; set; } = string.Empty;
    public NodeTree? Left { get; set; } 
    public NodeTree? Right { get; set; } 

    public NodeTree(int key, string value)
    {
        this.Key = key;
        this.Value = value;
    }
      
 // public  BinaryTree(int value=0, BinaryTree left=null, BinaryTree right=null)
 // {
 //        value = value;
 //        left = left;
 //        right =right;
 //    }
 //
 // public int MaximumDepth(BinaryTree node)
 // {
 //     if (node == null)
 //     {
 //         return 0;
 //     }
 //
 //     var left = MaximumDepth(node.left);
 //     var right = MaximumDepth(node.right);
 //     return Math.Max(left, right) + 1;
 // }
}