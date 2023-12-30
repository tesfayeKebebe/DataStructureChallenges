namespace PracticeAlgorithm;

public class ArrayMethods
{
    // The Array.Clear() method allows you to remove the contents of 
    // specific elements in your array and replace it with the array default value.
    //  For example, in a string array the element value cleared is replaced with null, 
    // when you clear a number array element the replacement is done with 0 (zero).
    [Fact]
    public Task Clear()
    {
        string[] pallets = { "B14", "A11", "B12", "A13" };
        Console.WriteLine("");

        Console.WriteLine($"Before: {pallets[0].ToLower()}");
        Array.Clear(pallets, 0, 2);
        if (pallets[0] != null)
        {
            //throw exceptions if you not check null before performing array methods
            Console.WriteLine($"After: {pallets[0].ToLower()}"); 
        }
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
        return Task.CompletedTask;
    }
    [Fact]
    public Task Resize()
    {
        string[] pallets = { "B14", "A11", "B12", "A13" };
        Console.WriteLine("");

        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Array.Resize(ref pallets, 6);
        Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

        pallets[4] = "C01";
        pallets[5] = "C02";

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
        return Task.CompletedTask;
    }
}