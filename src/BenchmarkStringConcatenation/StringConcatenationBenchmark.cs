using System.Text;
using AutoBogus;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Bogus;

namespace BenchmarkStringConcatenation;

//[RPlotExporter]
[MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class StringConcatenationBenchmark
{
    private List<string> _items = null!;

    [GlobalSetup]
    public void SetupData()
    {
        Randomizer.Seed = new Random(123);
        _items = AutoFaker.Generate<string>(Size);
    }



    [Params(2, 4, 8, 10, 20, 50, 100/*, 1000, 10_000*/)]
    public int Size { get; set; }



    [Benchmark (Baseline = true)]
    public string Concatenate_ByStringLiteral()
    {
        var str = string.Empty;

        foreach (var item in _items)
        {
            str += item;
        }

        return str;
    }

    [Benchmark]
    public string Concatenate_ByStringInterpolation()
    {
        var str = string.Empty;

        foreach (var item in _items)
        {
            str = $"{str}{item}";
        }

        return str;
    }

    [Benchmark]
    public string Concatenate_ByStringBuilder()
    {
        var sb = new StringBuilder();

        foreach (var item in _items)
        {
            sb.Append(item);
        }

        return sb.ToString();
    }

    [Benchmark]
    public string Concatenate_ByStringFormat()
    {
        var str = string.Empty;

        foreach (var item in _items)
        {
            str = string.Format("{0}{1}", str, item);
        }

        return str;
    }

    [Benchmark]
    public string Concatenate_ByStringConcat()
    {
        return string.Concat(_items);
    }

    [Benchmark]
    public string Concatenate_ByLinqAggregate()
    {
        // uses string interpolation internally here
        return _items.Aggregate((partialPhrase, word) => $"{partialPhrase}{word}");
    }
}
