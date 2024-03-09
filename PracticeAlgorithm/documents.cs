namespace PracticeAlgorithm;

using System;
using System.Collections.Generic;

public class DocumentStore
{
    [Fact]
    public void FixBug()
    {
     DocumentStore documentStore = new DocumentStore(Convert.ToInt32(2));
        documentStore.AddDocument("item");
        Console.WriteLine(documentStore);
    }
    private readonly List<string> documents = new List<string>();
    private readonly int capacity ;

    public DocumentStore(int capacity)
    {
           if (capacity <= 0)
        throw new ArgumentException("Capacity must be greater than zero.");
        this.capacity = capacity;
    }

    public int Capacity { get { return capacity; } }

    public IEnumerable<string> Documents { get { return documents; } }

    public void AddDocument(string document)
    {
        if (documents.Count > capacity)
            throw new InvalidOperationException();

        documents.Add(document);
    }

    public override string ToString()
    {
        return $"Document store: (documents.Count)/(capacity)";
    }
}



