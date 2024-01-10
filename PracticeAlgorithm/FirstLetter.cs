using System.Text;
using FluentAssertions;

namespace PracticeAlgorithm;
public class FirstLetter
{

    [Fact]
    public void FirstLetter_ShouldBeInUpperCase()
    {
        string words = "ABCD  efgh iJkl";
        var splitedWord = words.Split(" ");
        var builder = new StringBuilder();
        foreach (var word in splitedWord)
        {
            if (word != "")
            {
                builder.Append(char.ToUpperInvariant(word[0])).Append(word[1..]).Append(' ');
            }
            else
            {
                builder.Append(' ');
            }
       
        }
        var result = builder.ToString().Trim();
        result.Should().Be("ABCD  Efgh IJkl");

    }
}