namespace PracticeAlgorithm;

public class ReadonlyConstantImplementation
{
    public readonly string Test;
    //const can be initialized during declaration. can not be changed afterward
    public const string ConstField="dddd";
//readonly can be set only in the constructor
    public ReadonlyConstantImplementation(string test)
    {
        Test = test;
    }

    // public void SetReadlyValue(string test)
    // {
    //     _test = test;
    // }
}