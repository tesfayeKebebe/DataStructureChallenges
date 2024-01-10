using FluentAssertions;

namespace PracticeAlgorithm;

public class DelegatePractice
{
    private Action<string, int> Print = ( name,  age) =>
    {
        Console.WriteLine($"{name} {age}");
    };

    private Func<string, int> StringLength = (string str) => str.Length;
 [Fact]
    public void Check_Delegate()
    {
        //action generic delegate but does not return value 
        Action<string, int> actionDelegate = Print;
        actionDelegate("tesfaye", 32);
        //func is generic delegate that return value
        var funcResult = StringLength("hello");
        funcResult.Should().Be(5);
        
        //check generic func
        var filter = new ListFilter<int>();
        var numbers = new List<int> {1, 2, 5, 8, 10};
        var even=filter.FilterList(numbers, x => x % 2 == 0);
        var odd=filter.FilterList(numbers, x => x % 2 != 0);
        even.Should().BeEquivalentTo(new List<int>() {2, 8, 10});
        odd.Should().BeEquivalentTo(new List<int>() {1, 5});
        
        
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
   public class ListFilter<T>
   {
       public List<T> FilterList(List<T> list, Func<T, bool> predicate)
       {
          var filteredList = new List<T>();
           foreach (var item in list)
           {
               if (predicate(item))
               {
                   filteredList.Add(item);
               }
               
           }
           return filteredList;
       }
       
   }

}