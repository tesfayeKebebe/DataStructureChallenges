using FluentAssertions;

namespace PracticeAlgorithm;

public class OutKeyWordAndRef
{
    //out keyword is a method used  that parameter to return the value
    private void CheckOutKeyWord(out int k)
    {
        k = 5;
    }
    [Fact]
    public void CheckOutValue()
    {
         CheckOutKeyWord(out int k);
         k.Should().Be(5);

    }
}