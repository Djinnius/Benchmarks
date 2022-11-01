using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkPlainVsRecordStruct.Structs;

namespace BenchmarkPlainVsRecordStruct;

[MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class GetHashCodeBenchmarks
{
    static readonly Type _type = typeof(ushort);
    const int Value = 201;

    protected readonly PlainStruct _plainStructKey = new(_type, Value);
    protected readonly EquatableStruct _equatableStructKey = new(_type, Value);
    protected readonly HashStruct _hashStructKey = new(_type, Value);
    protected readonly HashEquatableStruct _hashEquatableStructKey = new(_type, Value);
    protected readonly (Type, int) _valueTupleKey = (_type, Value);
    protected readonly RecordStruct _recordStructKey = new(_type, Value);
    protected readonly HashEquatableRecordStruct _hashEquatableRecordStructKey = new(_type, Value);

    [Benchmark(Baseline = true)]
    public int PlainStruct_GetHashCode() => _plainStructKey.GetHashCode();

    [Benchmark]
    public int EquatableStruct_GetHashCode() => _equatableStructKey.GetHashCode();

    [Benchmark]
    public int HashStruct_GetHashCode() => _hashStructKey.GetHashCode();

    [Benchmark]
    public int HashEquatableStruct_GetHashCode() => _hashEquatableStructKey.GetHashCode();

    [Benchmark]
    public int ValueTuple_GetHashCode() => _valueTupleKey.GetHashCode();

    [Benchmark]
    public int RecordStruct_GetHashCode() => _recordStructKey.GetHashCode();

    [Benchmark]
    public int HashEquatableRecordStruct_GetHashCode() => _hashEquatableRecordStructKey.GetHashCode();
}
