using System.Collections.Specialized;

namespace PracticeAlgorithm;

public class DictionaryVsNameValueCollection
{
    [Fact]
    public static void DictionaryImplementation()
    {
        var dictionary = new Dictionary<int, Person>();
        dictionary.Add(1, new Person{Id = 1, Name = "tesfaye"});
        dictionary.TryAdd(2, new Person{Id = 2, Name = "Kebebe"});//adding item and return true
        dictionary.TryAdd(2, new Person{Id = 2, Name = "Kebebe"});//not adding item and return false
        dictionary.TryGetValue(3, out Person person);
            Console.WriteLine(person);
        
        // dictionary.Add(1, new Person{Id = 2, Name = "Kebebe"});
        foreach (var item in dictionary)
        {
            Console.WriteLine("value is {0}", item.Value.Name);
            
        }

    }
    [Fact]
    public static void NameValueCollectionImplementation()
    {
        var nameValueCollection = new NameValueCollection();
        nameValueCollection.Add("1", "Tesfaye");
        nameValueCollection.Add("2", "Kebebe");//adding item 
        nameValueCollection.Add("2",  "Kebebe");//adding item 
        // dictionary.Add(1, new Person{Id = 2, Name = "Kebebe"});
        foreach (var item in nameValueCollection.AllKeys)
        {
            Console.WriteLine("value is {0}", nameValueCollection[item]);
        }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}