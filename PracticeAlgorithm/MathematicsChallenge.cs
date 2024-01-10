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

    [Theory]
    [InlineData(8, new int[] {0, 1, 1, 2, 3, 5, 8,13})]
    [InlineData(13, new int[] {0, 1, 1, 2, 3, 5, 8,13,21,34,55,89,144})]
    public void CheckFibonacci(int number, int[] expected)
    {
        var result = Fibonacci(number);
        result.Should().BeEquivalentTo(expected);
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(5, true)]
    [InlineData(6, false)]
    public void CheckPrimeNumber(int number, bool expected)
    {
        var result = IsPrime(number);
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(24, 36, 12)]
    [InlineData(40, 8, 8)]
    [InlineData(12, 36, 12)]
    public void CheckGreatestCommonDivisor(int n1, int n2, int expected)
    {
        var result = GreatestCommonDivisor(n1, n2);
        result.Should().Be(expected);
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

    [Theory]
    [InlineData(153, true)]
    [InlineData(370, true)]
    public void CheckArmStrong(int n, bool expected)
    {
        var result = IsArmStrong(n);
        result.Should().Be(expected);
    }
    [Theory]
    [InlineData(1, 200, 12)]
    public void CheckGenerateArmStrong(int n, int n2, int n3)
    {
        var result = GenerateArmStrong(n, n2);
        
      
    }

    /// <summary>
    /// Definition: The Fibonacci sequence is a series of numbers in which each number is the sum of the two preceding ones. It starts with 0 and 1 (or 1 and 1).
    /// </summary>
    /// <param name="limit"></param>
    /// <returns></returns>
    private int[] Fibonacci(int limit)
    {
        var sequence = new List<int>(){0,1};
        for (int i = 2; i < limit; i++)
        {
            var sum = sequence[i - 1] + sequence[i - 2];
            sequence.Add(sum);
        }
        // var a = 0;
        // var b = 1;
        // while (a <= limit)
        // {
        //     sequence.Add(a);
        //     var temp = a;
        //     a = b;
        //     b = temp + b;
        // }

        return sequence.ToArray();
    }

    /// <summary>
    /// Definition: A prime number is a natural number greater than 1 that has no positive divisors other than 1 and itself.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    private bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        for (var i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="n1"></param>
    /// <param name="n2"></param>
    /// <returns></returns>
    private int GreatestCommonDivisor(int n1, int n2)
    {
        while (n2 != 0)
        {
            var temp = n2;
            n2 = n1 % n2;
            n1 = temp;
        }

        return n1;
    }

    /// <summary>
    /// An Armstrong number is a number that is equal to the sum
    /// of its own digits, each raised to the power of the number of digits.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    private bool IsArmStrong(int n)
    {
        var numbersString = n.ToString();
        var digit = numbersString.Length;
        var sum = 0;
        foreach (var num in numbersString)
        {
            var parseNum = int.Parse(num.ToString());
            sum += (int) Math.Pow(parseNum, digit);
        }

        return n == sum;
    }

    private List<int> GenerateArmStrong(int start, int end)
    {
       var armStrongs = new List<int>();
        while (start <= end)
        {
            if (IsArmStrong(start))
            {
                armStrongs.Add(start);
            }
            start++;
        }
        return armStrongs;
    }
}