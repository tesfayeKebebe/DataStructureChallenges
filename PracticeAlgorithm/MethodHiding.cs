namespace PracticeAlgorithm;

public class MethodHiding
{
    public class BaseClass
    {
        public virtual void GetBaseClass()
        {
            Console.WriteLine("BaseClass");
        }
        
    }
    public class SubClass: BaseClass
    {
        //Method hiding is a concept in object-oriented programming where a subclass defines
        //a method with the same name as a method in its superclass using new keyword
        public new void GetBaseClass()
        {
            Console.WriteLine("SubClass");
        }
    }
    
}