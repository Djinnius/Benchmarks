using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkTaskAwaitVsTaskReturn;

//[RPlotExporter]
[MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class TaskBenchmarks
{
    [Benchmark]
    public async Task<int> AwaitTask() => await GetInt();

    [Benchmark]
    public Task<int> ReturnTask() => GetInt();

    private Task<int> GetInt() => Task.FromResult(3);
}
