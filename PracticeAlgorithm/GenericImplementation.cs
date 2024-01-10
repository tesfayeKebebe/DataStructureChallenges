using FluentAssertions;
using Xunit.Sdk;

namespace PracticeAlgorithm;

public class GenericImplementation<T>
{
    public bool CompareValues(T value1, T value2)
    {
        return value1 != null && value1.Equals(value2);
    }
}

public class TestGeneric
{
    //generic allows us class and method type independent or type safe
    [Theory]
    [InlineData(1,2,false)]
    [InlineData(1,1,true)]
    [InlineData("tesfaye","Tesfaye",false)]
    [InlineData("Tesfaye","Tesfaye",true)]
    public void CheckGeneric<T>(T value1, T value2, bool expected)
    {
        var generic = new GenericImplementation<T>();
       var result= generic.CompareValues(value1, value2);
       result.Should().Be(expected);
    }
}