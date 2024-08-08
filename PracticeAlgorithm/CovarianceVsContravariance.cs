namespace PracticeAlgorithm;

public class CovarianceVsContravariance
{
    //Both are polymorphism extension to the array, delegate and generic.
    //They provide implicit conversion for array, delegate and generic
    //Covariance preserve assignment compatability 
    //Contravariance opposite of covariance functionality
    private static void AssignmentCompatability()
    {
        
            String stringObject = "A String Object";
            Object anObject = stringObject;
            //An Object of a derived class (stringObject) is being assigned to a variable of a base class (anObject).
            
            
            //Array Covariance
            object[] objArray = new String[10];
            //Array Covariance is not safe. Consider the following statement
            objArray[0] = 5;
            //That statement will not report any compile time errors. But at runtime, it causes an ArrayTypeMismatchException exception.
            //It is due to the fact that the objArray variable actually holds a reference of a string Array.
            
            //The Contravariance Delegates reverse the Covariance functionality.
            //It allows a method that has parameter types less derived than what is specified in the delegate.
            Action<string> del2 = SetObject;
            //Delegate Covariance
            // This type of variance is also called method group variance. It allows Delegate instances to
            // return more derived class types than what is specified in the type declaration.
            // In the following example of covariance, a string returning function is being assigned to a delegate which is
            // declared to return object type.
            Func<object> delegateObject = GetString ;
            Func<string> del3 = GetString;
            Func<object> del4 = del3;
            
            //Microsoft introduced implicit type conversion between interface
            //instances that have different type arguments. This means, an interface instance that has method with
            //more derived return types than originally specified ( Covariance)
            //or that has methods with less derived parameter types (Contravariance).
            
            
            
    }
    static void SetObject(object objectParameter) { }
    static string GetString() { return ""; }
    interface ICovariant<out R>
    {
        //covariant
        R GetSomething();
        // The following statement generates a compiler error.
         //void SetSometing(R sampleArg);
        
        //contravariant generic delegate as a method parameter, 
        void DoSomething(Action<R> callback);
    }
    //The Contravariant generic type parameter can be declared using "in" keyword.  
    // 
    // It is also possible to support both covariance and contravariance in the same interface,
    // but for different type parameters, as shown in the following code example. 
    interface IVariant<out R, in A>
    {
        R GetSomething();
        void SetSomething(A sampleArg);
        R GetSetSometings(A sampleArg);
    }

}