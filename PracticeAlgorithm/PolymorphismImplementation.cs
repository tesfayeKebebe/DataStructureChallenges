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
    public abstract class  PaymentMethod
    {
        public virtual void PayIn(decimal amout)
        {
            Console.WriteLine($"Pay In base class {amout}");
        }
        public abstract void PayOut(decimal amout);
    }
    public class TeleBirr: PaymentMethod
    {
        public override void PayIn(decimal amount)
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
        public override void PayIn(decimal amount)
        {
           Console.WriteLine($"Pay In {amount} Cbe Birr");
        }

        public override void PayOut(decimal amount)
        {
            Console.WriteLine($"Pay out {amount} through Cbe Birr");

        }
    }
}