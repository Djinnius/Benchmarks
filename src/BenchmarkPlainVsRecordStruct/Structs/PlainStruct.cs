namespace BenchmarkPlainVsRecordStruct.Structs;

public readonly struct PlainStruct
{
    public PlainStruct(Type type, int value)
    {
        Type = type;
        Value = value;
    }

    public Type Type { get; init; }
    public int Value { get; init; }
}

