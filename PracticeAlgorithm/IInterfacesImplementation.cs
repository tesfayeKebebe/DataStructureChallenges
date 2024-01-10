namespace PracticeAlgorithm;

public interface IInterfaceImplementation
{
    //does not have constructor
    // public IInterfaceImplementation()
    // {
    //     
    // }
    public virtual int Type()
    {
        return 1;
    }
}

 class MyClassHere : IInterfaceImplementation
{
}
