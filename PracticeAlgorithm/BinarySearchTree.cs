using System.IO.Enumeration;
using FluentAssertions;

namespace PracticeAlgorithm;

public class BinarySearchTree
{
    [Fact]
    private void CheckInsertionAndMaximumValueOfBinaryTree()
    {
        BinarySearchTree searchTree = new BinarySearchTree();
        searchTree.Insert(7, "s");
        searchTree.Insert(23, "ts");
        searchTree.Insert(15, "f");
        searchTree.Insert(1, "o");
        searchTree.Insert(10, "t");
        searchTree.Insert(6, "sx");
      var item=  searchTree.MaximumDepth(searchTree.Root);
      item.Should().Be(4);
      var find = searchTree.Search(1);
    }
    private NodeTree? Root { get; set; }
    private void Insert(int key, string value)
    {
        Root = InsertItem(Root, key, value);
    }

    private NodeTree InsertItem(NodeTree? node, int key, string value)
    {
        var newNode = new NodeTree(key, value);
        if (node == null)
        {
            node = newNode;
            return node;
        }

        if (key < node.Key)
        {
            node.Left = InsertItem(node.Left, key, value);
        }
        else
        {
            node.Right = InsertItem(node.Right, key, value);
        }

        return node;
    }

    public int MaximumDepth(NodeTree? node)
    {
        if (node == null)
        {
            return 0;
        }
        var left = MaximumDepth(node.Left);
        var right = MaximumDepth(node.Right);
        return Math.Max(left, right) + 1;
    }

    public NodeTree? Search(int key)
    {
        var node = Find(Root, key);
        return node;
    }

    public NodeTree? Find(NodeTree? node, int key)
    {
        if (node == null || node.Key == key) return node;
        if (key < node.Key) return Find(node.Left, key);
        return key > node.Key ? Find(node.Right, key) : null;
    }
}