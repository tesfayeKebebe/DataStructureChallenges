using Xunit.Abstractions;

namespace PracticeAlgorithm;

public class PercusQuareFormula
{
    private readonly ITestOutputHelper _testOutputHelper;

    public PercusQuareFormula(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void ToCheckPercusFormulaForTwoProduct()
    {
         var proteinExpected = 16;
         var calciumExpected = 16;
         var maize = Product.GetItems.FirstOrDefault(x => x.Name.Contains("Maize")).Protein;
         var fagulo = Product.GetItems.FirstOrDefault(x => x.Name.Contains("Fagulo")).Protein;
         var calMaize = Product.GetItems.FirstOrDefault(x => x.Name.Contains("Maize")).Calcium;
         var calFagulo = Product.GetItems.FirstOrDefault(x => x.Name.Contains("Fagulo")).Calcium;
         var maizeH = GetHorizontal(fagulo, proteinExpected);
         var faguloH = GetHorizontal(maize, proteinExpected);;
         var total = maizeH + faguloH;
         var maizeKg = GetKg(maizeH,  total);
         var faguloKg = GetKg(faguloH,  total);
         var totalKg = maizeKg + faguloKg;
         var maizeProtein = CalculateProtein(maizeKg , maize);
         var faguloProtein = CalculateProtein(faguloKg , fagulo);
         var totalProtein = maizeProtein + faguloProtein;
         _testOutputHelper.WriteLine("{0} : {1}, protein: {2} ", "Maize", maizeKg, maizeProtein );
         _testOutputHelper.WriteLine("{0} : {1}, protein: {2} ", "Fagulo", faguloKg, faguloProtein );
         _testOutputHelper.WriteLine(" total {0}",  faguloKg );
         Assert.Equal(proteinExpected, totalProtein);
    }
    [Fact]
    public void ToCheckPercusFormulaForMoreThanTwoProduct()
    {
        var expected = 16;
        var firstGroup = Product.GetItems.Where(x=>x.Category==2).GroupBy(x=> x.Category).ToList();
        var groupOneList = (from first in firstGroup
        from item in first
        select new ProductGroup
        {
            Category = item.Category,
            Index = item.Index,
            Name = item.Name,
            Protein = item.Protein,
            AmountToMix = item.Index * item.Protein
        }).ToList();
        var secondGroup =  Product.GetItems.Where(x=>x.Category==3).GroupBy(x=> x.Category).ToList();
        var groupSecondList = (from first in secondGroup
        from item in first
        select new ProductGroup
        {
            Category = item.Category,
            Index = item.Index,
            Name = item.Name,
            Protein = item.Protein,
            AmountToMix = item.Index * item.Protein
        }).ToList();
        var groupOneH = GetHorizontal(groupSecondList.Sum(x=>x.AmountToMix)/groupSecondList.Sum(x=>x.Index), expected);
        var groupTwoH = GetHorizontal(groupOneList.Sum(x=>x.AmountToMix)/groupOneList.Sum(x=>x.Index), expected);;
        var total = groupOneH + groupTwoH;
        var groupOnePercent = GetKg(groupOneH,  total);
        var groupTwoPercent = GetKg(groupTwoH,  total);
        double sum = 0;
        double totalProtein = 0;
        foreach (var item in groupOneList)
        {
            var itemKg = (groupOnePercent * item.Index) / groupOneList.Sum(x => x.Index);
            var itemProtein = CalculateProtein(itemKg, item.Protein);
            totalProtein += itemProtein;
            sum += itemKg;
            _testOutputHelper.WriteLine("{0} : {1}, protein: {2} ", item.Name, itemKg, itemProtein );

        }
        foreach (var item in groupSecondList)
        {
            var itemKg = (groupTwoPercent * item.Index) / groupSecondList.Sum(x => x.Index);
            var itemProtein = CalculateProtein(itemKg, item.Protein);
            sum += itemKg;
            totalProtein += itemProtein;
            _testOutputHelper.WriteLine("{0} : {1}, protein: {2} ", item.Name, itemKg, itemProtein );
        }
        _testOutputHelper.WriteLine("total kg is {0}",sum);
        _testOutputHelper.WriteLine("total protein is {0}",totalProtein);
        
        // var maizeProtein = CalculateProtein(maizeKg , maize);
        // var faguloProtein = CalculateProtein(faguloKg , fagulo);
        // var totalProtein = maizeProtein + faguloProtein;
        // Assert.Equal(expected, totalProtein);
    }

    private static double GetHorizontal(double protein, double expected)
    {
        return Math.Abs(protein - expected);
    }
    private static double GetKg(double horizontal, double total)
    {
        return (horizontal*100)/total;
    }
    private static double CalculateProtein(double kg, double percent)
    {
        return (kg*percent)/100;
    }

}

public record Product
{
    public string Name { get; set; } = string.Empty;
    public double Protein { get; set; }
    public double Calcium { get; set; }
    public double Phosphorus  { get; set; }
    public double CrudeFat { get; set; }
    public double CrudeFiber { get; set; }
    public double Moisture { get; set; }
    public double Energy { get; set; }
    public int Category { get; set; }
    public int Index { get; set; }

    public static List<Product> GetItems = new()
    {
      new Product
      {
          Name = "Maize",
          Protein = 8.8,
          Category=1,
          Index = 1
          
      },
      new Product
      {
          Name = "Fagulo",
          Protein = 38,
          Category=1,
          Index = 1
      },
      
      // the following data is used for more than two data calculations
      new Product
      {
          Name = "Yellow Maize",
          Protein =10,
          Category=2,
          Index=1
          
      },
      new Product
      {
          Name = "Furshka",
          Protein =13,
          Category=2,
          Index = 3
      },
   
      new Product
      {
          Name = "YeLawuze Fagulo",
          Protein = 40,
          Category=3,
          Index = 1
      }
    };
}
public record ProductGroup
{
    public string Name { get; set; } = string.Empty;
    public double Protein { get; set; }
    public int Category { get; set; }
    public int Index { get; set; }
    public double AmountToMix { get; set; }
}