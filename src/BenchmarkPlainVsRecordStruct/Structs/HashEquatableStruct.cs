namespace BenchmarkPlainVsRecordStruct.Structs;
public readonly struct HashEquatableStruct : IEquatable<HashEquatableStruct>
{
    public HashEquatableStruct(Type type, int value)
    {
        Type = type;
        Value = value;
    }

    public Type Type { get; init; }
    public int Value { get; init; }

    public bool Equals(HashEquatableStruct other) =>
        Type == other.Type && Value == other.Value;

    public override int GetHashCode() =>
        Type.GetHashCode() * -1521134295 + Value.GetHashCode();
}
