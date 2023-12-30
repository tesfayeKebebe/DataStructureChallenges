using FluentAssertions;

namespace PracticeAlgorithm;
public class FirstLetter
{

    [Fact]
    public void FirstLetter_ShouldBeInUpperCase()
    {
        string words = "ABCD  efgh iJkl";
        var splitedWord = words.Split(" ");
        for (int i =0; i<splitedWord.Length; i++)
        {
            var letters = splitedWord[i].ToCharArray();
            if (letters.Length > 0)
            {
                letters[0]= Char.ToUpper(letters[0]);
            }

            splitedWord[i] = new string(letters);
        }

        var joinWord = string.Join(" ", splitedWord);
        joinWord.Should().Be("ABCD  Efgh IJkl");

    }
}