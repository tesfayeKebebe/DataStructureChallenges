using System.Runtime.CompilerServices;

namespace PracticeAlgorithm;

public class ConstructorsImplementation
{
    private  string data;
    //does not have return type even void
    // public ConstructorsImplementation()
    // {
    //     
    // }
//The main purpose of creating private constructor is to restrict the class from
// being instantiated when it contains every member as static.
//it is used to stop object creation of the class
//it is used to stop a class to be inherited
//It is used in singleton class
    private ConstructorsImplementation(string data)
    {
        this.data = data;
    }
  //access modifier is not allowed for static constructor
  //can not be parametrized constructor
  //one class only has one static constructor
  // Static constructor is a special constructor that gets called before the first
  //     object of the class is created
     static ConstructorsImplementation()
     {
         //can not access non static field
     //   data = "dfdfd";
      }
   
    
}