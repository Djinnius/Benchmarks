using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkIteration;

//[RPlotExporter]
[MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class IteratorBenchmarks
{
    private static readonly Random _random = new Random(12345);
    private List<int> _items = null!;

    [GlobalSetup]
    public void SetupData()
    {
        _items = Enumerable.Range(0, Size).Select(x => _random.Next()).ToList();
    }

    [Params(100, 100_000, 1_000_000)]
    public int Size { get; set; }

    [Benchmark(Baseline = true)]
    public void For()
    {
        for (int i = 0; i < _items.Count; i++)
        {
            // Not used but still retained during complilation
            var item = _items[i];
        }
    }

    [Benchmark]
    public void ForEach()
    {
        foreach (var item in _items)
        {
        }
    }

    [Benchmark]
    public void ForEach_Linq()
    {
        _items.ForEach(item => { });
    }

    [Benchmark]
    public void Parallel_ForEach()
    {
        Parallel.ForEach(_items, item => { });
    }

    [Benchmark]
    public void Parallel_Linq()
    {
        _items.AsParallel().ForAll(item => { });
    }

    [Benchmark]
    public void ForEach_Span()
    {
        foreach (var item in CollectionsMarshal.AsSpan(_items))
        {
        }
    }

    [Benchmark]
    public void For_Span()
    {
        var asSpan = CollectionsMarshal.AsSpan(_items);

        for (int i = 0; i < _items.Count; i++)
        {
            // Not used but still retained during complilation
            var item = asSpan[i];
        }
    }
}
