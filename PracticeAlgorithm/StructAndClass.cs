namespace PracticeAlgorithm;

public class StructAndClass
{
    // struct is value type, stored on the stack. default value of struct is zero or null. can not inherited by class or struct
    //class is reference type, stored on the heap, default value of class is null. Can support inheritance
    public struct MyStruct: IMyInterface
    {
        public int GetValue()
        {
            return 1;
        }
    }

    private interface IMyInterface
    {
        int GetValue();

    }
}