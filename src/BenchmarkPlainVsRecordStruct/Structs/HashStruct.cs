namespace BenchmarkPlainVsRecordStruct.Structs;

public readonly struct HashStruct
{
    public HashStruct(Type type, int value)
    {
        Type = type;
        Value = value;
    }

    public Type Type { get; init; }
    public int Value { get; init; }

    public override int GetHashCode() =>
        Type.GetHashCode() * -1521134295 + Value.GetHashCode();
}
