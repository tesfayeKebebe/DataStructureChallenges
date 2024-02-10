namespace PracticeAlgorithm;
/// <summary>
/// polymorphism is a concept of object-oriented programming which objects of different classes
/// treated as object of base class
/// </summary>
public class PolymorphismImplementation
{
    [Fact]
    public void Evaluate_Polymorphism()
    {
        var cbe = new CbeBirr();
        PaymentMethod paymentM1 = cbe ;
        paymentM1.PayIn(5);//call base class method. Pay In base class 5
        paymentM1.PayOut(5);  //call Cbe birr class pay out method. Because of override and virtual keys. Pay out 5 through Cbe Birr if PayOut is overriden in cbeBirr class
        //PaymentMethod baseObject = new PaymentMethod();
       // CbeBirr cbeBirr = (CbeBirr)baseObjec; invalid exception
       //PaymentMethod baseObject = cbeBir; //Valid: Implicit upcasting 
       PaymentMethod baseObject = new CbeBirr();
       CbeBirr cbeBir = (CbeBirr)baseObject;
       cbeBir.PayIn(5);// Call Cbe birr method
       cbeBir.PayOut(5);// Call Cbe birr method
      
        
        var instances = new List<PaymentMethod>
        {
            new CbeBirr(),
            new TeleBirr()
        };
        var amount = 100M;
        foreach (var method in instances)
        {
            method.PayIn(amount);
            method.PayOut(amount);
        }
    }
    public   class  PaymentMethod
    {
        public  void PayIn(decimal amout)
        {
            Console.WriteLine($"Pay In base class {amout}");
        }

        public virtual  void PayOut(decimal amout)
        {
            Console.WriteLine($"Pay out base class {amout}");
        }
    }
    public class TeleBirr: PaymentMethod
    {
        public new void PayIn(decimal amount)
        {
           Console.WriteLine($"Pay in {amount} TeleBirr");
        }

        public override void PayOut(decimal amount)
        {
            Console.WriteLine($"Pay out {amount} through TeleBirr");
        }
    }
    public class CbeBirr: PaymentMethod
    {
        public new void PayIn(decimal amount)
        {
           Console.WriteLine($"Pay In {amount} Cbe Birr");
        }

        public override void PayOut(decimal amount)
        {
            Console.WriteLine($"Pay out {amount} through Cbe Birr");

        }
    }
}