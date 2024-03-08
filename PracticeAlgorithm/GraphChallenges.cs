using FluentAssertions;

namespace PracticeAlgorithm;

public class GraphChallenges
{
    [Fact]
    public void Check_GraphChallenges()
    {
        var dic = new Dictionary<char, List<char>>()
        {
            {'a', new List<char>(){'b','c'}} ,
            {'b', new List<char>(){'d'}},
            {'c', new List<char>(){'e'}},
            {'d', new List<char>(){'f'}},
            {'e',new List<char>()},
            {'f',new List<char>()}
        };
        var result = PrintGraph(dic, 'a');
        result.Should().BeEquivalentTo(new List<char>() {'a', 'c', 'e', 'b', 'd', 'f'});
        var bft = BreadthFirstTransverse(dic, 'a');
        bft.Should().BeEquivalentTo(new List<char>() {'a', 'b', 'c', 'd', 'e', 'f'});
    }
    private List<char> PrintGraph(Dictionary<char, List<char>> graph, char src)
    {
        var result = new List<char>();
        var stack = new Stack<char>();
        stack.Push(src);
        while (stack.Count > 0)
        {
            var current = stack.Pop();
            result.Add(current);
            foreach (var neighbour in graph[current])
            {
                stack.Push(neighbour);
            }
        }
        return result;
    }

    private List<char> BreadthFirstTransverse(Dictionary<char, List<char>> graph, char src)
    {
        var result = new List<char>();
        var queue = new Queue<char>();
        queue.Enqueue(src);
        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            result.Add(current);
            foreach (var neighbour in graph[current])
            {
              queue.Enqueue(neighbour);
            }
        }
        return result;
    }
    
}