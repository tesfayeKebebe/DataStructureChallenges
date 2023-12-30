using FluentAssertions;

namespace PracticeAlgorithm;

public class ListOutput
{
    [Fact]
    private static void Output()
    {
        var people = new List<Person>
        {
            new Person
            {
                Age = 10,
                Name = "tesfaye"
            },
            new Person
            {
                Age = 10,
                Name = "Kebebe"
            },
        };

     var getPeople = people.Where((_) => true);//it return all elements of collection because the condition always evaluate to true.
     getPeople.Should().HaveCount(2);
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}