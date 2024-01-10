using FluentAssertions;

namespace PracticeAlgorithm;

public class IncrementAndDecrement
{
    [Fact]
    public void CheckIncrementAndDecrement()
    {
        var x = 4;
        //Post increment:assign and then increment the x by one. 
        var y = x++;
        y.Should().Be(4);
        x.Should().Be(5);
        Console.WriteLine(x+y);
        
        //pre-Increment
        var i = 4;
        var j = ++i;
        i.Should().Be(5);
        j.Should().Be(5);
        Console.WriteLine(x+y);
    }
}