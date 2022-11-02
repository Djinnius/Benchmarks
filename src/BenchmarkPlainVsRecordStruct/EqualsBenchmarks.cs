using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkPlainVsRecordStruct.Structs;

namespace BenchmarkPlainVsRecordStruct;

//[RPlotExporter]
[MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class EqualsBenchmarks
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

    static readonly Type _typeOther = typeof(long);
    const int ValueOther = 401;

    protected readonly PlainStruct _plainStructKeyOther = new(_typeOther, ValueOther);
    protected readonly EquatableStruct _equatableStructKeyOther = new(_typeOther, ValueOther);
    protected readonly HashStruct _hashStructKeyOther = new(_typeOther, ValueOther);
    protected readonly HashEquatableStruct _hashEquatableStructKeyOther = new(_typeOther, ValueOther);
    protected readonly (Type, int) _valueTupleKeyOther = (_typeOther, ValueOther);
    protected readonly RecordStruct _recordStructKeyOther = new(_typeOther, ValueOther);
    protected readonly HashEquatableRecordStruct _hashEquatableRecordStructKeyOther = new(_typeOther, ValueOther);


    [Benchmark(Baseline = true)]
    public bool PlainStruct_Equals() => _plainStructKey.Equals(_plainStructKeyOther);

    [Benchmark]
    public bool EquatableStruct_Equals() => _equatableStructKey.Equals(_equatableStructKeyOther);

    [Benchmark]
    public bool HashStruct_Equals() => _hashStructKey.Equals(_hashStructKeyOther);

    [Benchmark]
    public bool HashEquatableStruct_Equals() => _hashEquatableStructKey.Equals(_hashEquatableStructKeyOther);

    [Benchmark]
    public bool ValueTuple_Equals() => _valueTupleKey.Equals(_valueTupleKeyOther);

    [Benchmark]
    public bool RecordStruct_Equals() => _recordStructKey.Equals(_recordStructKeyOther);

    [Benchmark]
    public bool HashEquatableRecordStruct_Equals() => _hashEquatableRecordStructKey.Equals(_hashEquatableRecordStructKeyOther);
}
