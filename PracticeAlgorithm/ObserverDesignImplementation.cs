namespace PracticeAlgorithm;




public class Observer 
{
    private string _name;
    private Subject _subject;
    public Observer(string name, Subject subject)
    {
        _name = name;
        _subject = subject;
    }
    public void Update()
    {
       Console.WriteLine($"Observer {_name} received the update. New state {_subject.State}");
    }
}

public class Subject
{
    private readonly List<Observer> _observables = new List<Observer>();
    private int _state;
    public int State
    {
        get => _state;
        set
        {
            _state = value;
            Notify();
        } 
    }
    public void AddObserver(Observer observer)
    {
        _observables.Add(observer);
    }
    public void RemoveObserver(Observer observer)
    {
        _observables.Remove(observer);
    }
    public void Notify()
    {
        foreach (var observer in _observables)
        {
            observer.Update();
        }
    }
}

public class TestObserverDesign
{
    [Fact]
    public void TestObservable()
    {
        //The Observer design pattern is a behavioral pattern that establishes a one-to-many dependency between objects.
        //It defines a subscription mechanism where multiple observers
        //(also known as subscribers or listeners) are notified automatically when the state of a subject (also known as publisher or observable) changes.
        var subject = new Subject();
        var observer1 = new Observer("Observer 1", subject);
        var observer2 = new Observer("Observer 2", subject);
        subject.AddObserver(observer1);
        subject.AddObserver(observer2);
        subject.State = 5;
        //Observer Observer 1 received the update. New state 5
        // Observer Observer 2 received the update. New state 5
        subject.State = 6;
        // Observer Observer 1 received the update. New state 6
        // Observer Observer 2 received the update. New state 6
        subject.State = 7;
        // Observer Observer 1 received the update. New state 7
        // Observer Observer 2 received the update. New state 7
        

    }
    
}
