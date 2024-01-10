namespace PracticeAlgorithm;

public class SealedVsStaticClass
{
   [Fact]
   public void TestDifferenceBetweenSealedAndStatic()
   {
      //we instantiate sealed class 
      var sealedClass = new MySealedClass();
      sealedClass.GetValue();
      //can not create instance of static class but if we want to access static class member
      //we can use class name directly without instantiating the class
      //all member of static class is marked with static keyword
      // var staticClass = new MyStaticClass();
      MyStaticClass.GetValue();
    }
   public sealed class MySealedClass
   {
      public MySealedClass()
      {
         
      }

      public void GetValue()
      {
         
      }
      
      
   }
   public static class MyStaticClass
   {
      //we can not define access modifier for static constructor and we cannot pass parameter to static constructor
      static MyStaticClass()
      {
         
      }

      public static void GetValue()
      {
         
      }
   }
}