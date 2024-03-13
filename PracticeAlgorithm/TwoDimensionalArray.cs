using FluentAssertions;
using System.Text;

namespace PracticeAlgorithm;

public class TwoDimensionalArray
{
    [Fact]
    public void TwoDimensionalPrintShouldTaketwoDiamensionalArrayOfSrtingAndReturnSpaceSeparatedString()
    {
        TwoDimensionalPrint(new string[][] { ["a", "b", "c", "d"], ["e", "f"], ["g", "h", "i"] })
            .Should()
            .BeEquivalentTo("a b c d e f g h i");
    }

    private string TwoDimensionalPrint(string[][] str)
    {
        var builder = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            var subArray = str[i];
            for (int j = 0; j < subArray.Length; j++)
            {
                builder.Append(subArray[j]).Append(" ");
            }
        }
        return builder.ToString().Trim();
    }
[Fact]
public void AddTwoDimensionalArrayTakeMasRownAsColumnAndValueAsValuesElementInTwoDimensionalArrayShouldBeReturnTwoDimensionalArray()
{
  var result=  AddTwoDimensionalArray(4,2,"x");
  
// // [
// //   [ 'x', 'x' ],
// //   [ 'x', 'x' ],
// //   [ 'x', 'x' ],
// //   [ 'x', 'x' ]
// // ]
}
    private string[][] AddTwoDimensionalArray(int m, int n, string value)
    {
        var twoDimensionalArr = new string [m][];
          for(int i=0; i<m; i++)
          {
            var subArray = new string[n];
              for(int j=0; j< n; j++)
              {
                subArray[j]=value;
              }
              twoDimensionalArr[i]=subArray;
          }
          return twoDimensionalArr;
    }
    [Fact]
    public void TwoSumPairsTakeArrayAndTargetShouldBeReturnTwoDimensionalArray()
    {
      var result=  TwoSumPairs(new int[] {2, 3, 4, 6, 5}, 8);
    }
    private List<List<int>> TwoSumPairs (int[] arr, int target) 
    {
        var twoDim = new List<List<int>>();
        for(int i=0; i<arr.Length; i++)
        {
            var subArray = new List<int>();
            for(int j=i+1; j<arr.Length; j++)
            {
                if(arr[i] + arr[j]==target)
                {
                    subArray.Add(arr[i]);
                    subArray.Add(arr[j]);
                }
            }
            if(subArray.Count > 0) twoDim.Add(subArray);
        }
        return twoDim;
    }
}

