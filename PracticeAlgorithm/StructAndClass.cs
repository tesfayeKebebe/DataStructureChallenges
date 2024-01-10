using FluentAssertions;

namespace PracticeAlgorithm;

// struct is value type, stored on the stack. default value of struct is zero or null. can not inherited by class or struct
//class is reference type, stored on the heap, default value of class is null. Can support inheritance
public struct MyStruct : IMyInterface
{
    public MyStruct()
    {
    }

    public int GetValue()
    {
        return 1;
    }
}

public interface IMyInterface
{
    int GetValue();
}

public record MyRecord(int Age): IMyInterface
{
    public int GetValue()
    {
        return Age;
    }
}
public class MyClass: IMyInterface
{
    private readonly int _age;
    public MyClass(int age)
    {
        _age = age;
    }
    public int GetValue()
    {
        return _age;
    }
}

// struct is value type, stored on the stack. default value of struct is zero or null. can not inherited by class or struct
// public struct StructInheritance: MyStruct



public class TestClassStructRecord
{
    [Fact]
    public void Test()
    {
        //Use struct when you want a lightweight value type that represents a small, simple data structure and don't require inheritance or reference semantics.
        IMyInterface instance = new MyStruct();
       var result= instance.GetValue();
       result.Should().Be(1);
       //Use record when you primarily need a data container with immutable properties and value-based equality comparison.
       IMyInterface record = new MyRecord(2);
       var recordResult= record.GetValue();
       recordResult.Should().Be(2);
       //Use class when you need to create objects with behavior and state, support inheritance, or implement complex functionality.
       IMyInterface classInstance = new MyClass(2);
       var classResult = classInstance.GetValue();
       classResult.Should().Be(2);

    }
}
