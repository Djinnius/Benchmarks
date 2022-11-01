namespace BenchmarkPlainVsRecordStruct.Structs;

public readonly record struct HashEquatableRecordStruct(Type Type, int Value) : IEquatable<HashEquatableRecordStruct>
{
    public bool Equals(HashEquatableRecordStruct other) =>
        Type == other.Type && Value == other.Value;

    public override int GetHashCode() =>
        Type.GetHashCode() * -1521134295 + Value.GetHashCode();
}
