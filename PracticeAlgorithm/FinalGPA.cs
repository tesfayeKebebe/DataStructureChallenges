using FluentAssertions;
using Xunit.Abstractions;

namespace PracticeAlgorithm;

public class FinalGPA
{
    private readonly ITestOutputHelper _testOutputHelper;

    public FinalGPA(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public  Task CalculateFinalGPA()
    {
        _testOutputHelper.WriteLine("Student: Sofia Johnson");
        _testOutputHelper.WriteLine("Course\t\t\tGrade\tCredit Hours");
        _testOutputHelper.WriteLine("English 101\t\t\t4\t\t3");
        _testOutputHelper.WriteLine("Algebra 101\t\t\t3\t\t3");
        _testOutputHelper.WriteLine("Biology 101\t\t\t3\t\t4");
        _testOutputHelper.WriteLine("Computer Science I\t3\t\t4");
        _testOutputHelper.WriteLine("Psychology 101\t\t4\t\t3\n");
        var totalSumOfCourseWithCreditHour = 4*3+ 3*3 +3*4 +3*4 +4*3;
        var totalSumOfCreditHours= 3+3+4+4+3;
        var gradePointAverage = (decimal)totalSumOfCourseWithCreditHour/totalSumOfCreditHours ;
        var leading = (int)gradePointAverage;
        var firstDigit = (int)(gradePointAverage *10)%10;
        var secondDigit = (int)(gradePointAverage *100)%10;
        var result = $"Final GPA:\t\t\t{leading}.{firstDigit}{secondDigit}";
        result.Should().Be($"Final GPA:\t\t\t3.35");
       return Task.CompletedTask;
    }
    
}