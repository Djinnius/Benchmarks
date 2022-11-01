using System.Text;
using ProtoBuf;

namespace BenchmarkSerialisation.Dtos;

[ProtoContract]
internal sealed class AddressBook
{
    [ProtoMember(1)]
    public List<Person> Persons { get; set; } = new List<Person>();

    public override string ToString()
    {
        var sb = new StringBuilder();

        foreach (var person in Persons)
            sb.AppendLine($"Person {person}");

        return sb.ToString();
    }
}
