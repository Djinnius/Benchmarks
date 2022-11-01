namespace BenchmarkPlainVsRecordStruct.Structs;

public readonly struct EquatableStruct : IEquatable<EquatableStruct>
{
    public EquatableStruct(Type type, int value)
    {
        Type = type;
        Value = value;
    }

    public Type Type { get; init; }
    public int Value { get; init; }

    public bool Equals(EquatableStruct other) =>
        Type == other.Type && Value == other.Value;
}
