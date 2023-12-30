using FluentAssertions;

namespace PracticeAlgorithm;

public class MathematicsChallenge
{
    [Fact]
    public void CheckFactorial()
    {
        var result = Factorial(5);
        result.Should().Be(120);

    }

    [Fact]
    public void CheckFibonacci()
    {
        var result = Fibonacci(13);
        result.Should().BeEquivalentTo(new int[] {0,1, 1, 2, 3, 5, 8, 13});

    }
    private int Factorial(int n)
    {
        var fact = 1;
        for (var i = n; i >= 1; i--)
        {
            fact *= i;
        }
        return fact;
    }

    private int[] Fibonacci(int limit)
    {
        var sequence = new List<int>();
        var a = 0;
        var b = 1;
        while (a<=limit)
        {
            sequence.Add(a);
            var temp = a;
            a = b;
            b = temp + b;
        }
        return sequence.ToArray()  ;
    }
}