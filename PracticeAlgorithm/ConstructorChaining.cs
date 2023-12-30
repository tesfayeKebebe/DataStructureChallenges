namespace PracticeAlgorithm;

public class Person
{
    public string Name { get; set; }
    protected Person(string name)
    {
        Name = name;
    }
    protected Person(string name, int age): this(name)
    {
        
    }
}
//By using constructor chaining, you can avoid duplicating initialization code in multiple constructors.
//In the example, the constructor in Person that takes a name parameter is called by
//both constructors in Person and the constructor in Employee.
//This way, the initialization logic for the name property is centralized in one place.
public class Employee : Person
{
    private  int Salary { get; set; }

    public Employee(string name, int salary, string job) : base(name)
    {
        Salary = salary;
    }

    public Employee(string name, int age) : base(name, age)
    {
    }
}