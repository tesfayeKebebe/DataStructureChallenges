using System.Diagnostics;
using FluentAssertions;

namespace PracticeAlgorithm;

public class AsyncAwait
{
    [Fact]
    public async Task CheckAsyncMethod()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        await GetMethod1();
        stopwatch.Stop();
        var elapsedMillisecond = stopwatch.ElapsedMilliseconds;
        elapsedMillisecond.Should().BeGreaterThan(1500);

    }
    private async Task GetMethod1()
    {
        await Task.Delay(500);
        await GetMethod2();
    }
    private async Task<int> GetMethod2()
    {
        await Task.Delay(1000);
        return 1000;
    }
}