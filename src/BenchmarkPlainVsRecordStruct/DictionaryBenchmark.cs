using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkPlainVsRecordStruct.Structs;

namespace BenchmarkPlainVsRecordStruct;

[MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class DictionaryBenchmarks
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

    static readonly (Type Type, int Value)[] _keys = new (Type Type, int Value)[]
    {
        (typeof(byte), 101),
        (typeof(sbyte), 102),
        (typeof(ushort), 201),
        (typeof(short), 202),
        (typeof(uint), 301),
        (typeof(int), 302),
        (typeof(ulong), 401),
        (typeof(long), 402),
    };

    readonly Dictionary<PlainStruct, long> _plainKeyDictionary =
       _keys.ToDictionary(k => new PlainStruct(k.Type, k.Value), k => k.Value * 1L);

    readonly Dictionary<EquatableStruct, long> _equatableKeyDictionary =
        _keys.ToDictionary(k => new EquatableStruct(k.Type, k.Value), k => k.Value * 1L);

    readonly Dictionary<HashStruct, long> _hashKeyDictionary =
        _keys.ToDictionary(k => new HashStruct(k.Type, k.Value), k => k.Value * 1L);

    readonly Dictionary<HashEquatableStruct, long> _hashEquatableKeyDictionary =
        _keys.ToDictionary(k => new HashEquatableStruct(k.Type, k.Value), k => k.Value * 1L);

    readonly Dictionary<(Type, int), long> _valueTupleToValue =
        _keys.ToDictionary(k => k, k => k.Value * 1L);

    readonly Dictionary<RecordStruct, long> _recordKeyDictionary =
        _keys.ToDictionary(k => new RecordStruct(k.Type, k.Value), k => k.Value * 1L);

    readonly Dictionary<HashEquatableRecordStruct, long> _customRecordKeyDictionary =
        _keys.ToDictionary(k => new HashEquatableRecordStruct(k.Type, k.Value), k => k.Value * 1L);


    [Benchmark(Baseline = true)]
    public long PlainStruct_DictionaryGet() => _plainKeyDictionary[_plainStructKey];

    [Benchmark]
    public long EquatableStruct_DictionaryGet() => _equatableKeyDictionary[_equatableStructKey];

    [Benchmark]
    public long HashStruct_DictionaryGet() => _hashKeyDictionary[_hashStructKey];

    [Benchmark]
    public long HashEquatableStruct_DictionaryGet() => _hashEquatableKeyDictionary[_hashEquatableStructKey];

    [Benchmark]
    public long ValueTuple_DictionaryGet() => _valueTupleToValue[_valueTupleKey];

    [Benchmark]
    public long RecordStruct_DictionaryGet() => _recordKeyDictionary[_recordStructKey];

    [Benchmark]
    public long HashEquatableRecordStruct_DictionaryGet() => _customRecordKeyDictionary[_hashEquatableRecordStructKey];
}
