namespace PracticeAlgorithm;

public class DelegatePractice
{
    private Action<string, int> Print = ( name,  age) =>
    {
        Console.WriteLine($"{name} {age}");
    };
 [Fact]
    public void Check_Generic_ActionDelegate()
    {
        Action<string, int> actionDelegate = Print;
        actionDelegate("tesfaye", 32);
    }

    [Fact]
    public void CheckHandleButtonClick()
    {
        var btn = new Button();
        //event used for defining event and handle event.
        //event used for notifying other parts of the program.
        btn.Notify += Button_Click;
        btn.HandleEvent();
    }

    private void Button_Click(Object sender, EventArgs args)
    {
     Console.WriteLine("button Clicked"); 
    }

   public class Button
   {
       public event EventHandler? Notify;

       public void HandleEvent()
       {
           Notify?.Invoke(this, EventArgs.Empty);
       }
       
   }

}