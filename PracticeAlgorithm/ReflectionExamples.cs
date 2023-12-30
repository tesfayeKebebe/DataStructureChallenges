using System.Reflection;

namespace PracticeAlgorithm;

public class ReflectionExamples
{
    /// <summary>
    /// Reflection is the ability of dotnet run time, which inspect the meta data of assembly, module and types
    /// </summary>
    [Fact]
    public void ExploreReflection()
    {
        Type type = typeof(string);
        Console.WriteLine($"Type Name: {type.Name}");
        
        MethodInfo[] methods = type.GetMethods();
        Console.WriteLine("Methods:");
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine($"- {method.Name}");
        }
  

    }
}