using BenchmarkSerialisation.Dtos;
using Newtonsoft.Json;
using ProtoBuf;
using SysTxtJson = System.Text.Json;

namespace BenchmarkSerialisation;

/// <summary>
///     Serialisation samples to benchmark:
///         - System.Text.Json
///         - Newtonsoft
///         - Protobuf-Net
/// </summary>
internal sealed class SerialisationSamples
{
    public static string SerialiseWithSystemTextJson(AddressBook addressBook) 
        => SysTxtJson.JsonSerializer.Serialize(addressBook);

    public static string SerialiseWithNewtonsoftJson(AddressBook addressBook) 
        => JsonConvert.SerializeObject(addressBook);

    public static MemoryStream SerialiseWithProtobufNet(AddressBook addressBook)
    {
        MemoryStream stream = new MemoryStream();
        Serializer.Serialize(stream, addressBook);
        return stream;
    }
}
