using AutoBogus;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkSerialisation.Dtos;
using Bogus;
using ProtoBuf;
using ProtoBuf.Meta;

namespace BenchmarkSerialisation;

[MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class SerialisationBenchmarks
{
    AddressBook _addressBook_10 = null!;
    AddressBook _addressBook_100 = null!;
    AddressBook _addressBook_1_000 = null!;
    AddressBook _addressBook_10_000 = null!;

    [GlobalSetup]
    public void SetupData()
    {
        Randomizer.Seed = new Random(123);

        var phoneFaker = new AutoFaker<Phone>()
            .RuleFor(x => x.Number, f => f.Person.Phone);

        var personFaker = new AutoFaker<Dtos.Person>()
            .RuleFor(x => x.ID, f => f.Random.Int(1, 9999999))
            .RuleFor(x => x.Name, f => f.Person.FullName)
            .RuleFor(x => x.Email, f => f.Person.Email)
            .RuleFor(x => x.Age, f => f.Random.Int(10, 90))
            .RuleFor(x => x.Phones, f => phoneFaker.Generate(3));

        _addressBook_10 = new AddressBook { Persons = personFaker.Generate(10) };
        _addressBook_100 = new AddressBook { Persons = personFaker.Generate(100) };
        _addressBook_1_000 = new AddressBook { Persons = personFaker.Generate(1_000) };
        _addressBook_10_000 = new AddressBook { Persons = personFaker.Generate(10_000) };
    }

    [Benchmark]
    [Arguments(10)]
    [Arguments(100)]
    [Arguments(1_000)]
    [Arguments(10_000)]
    public string SystemTextJsonSerialise(int count)
    {
        switch (count)
        {
            case 10:
                return SerialisationSamples.SerialiseWithSystemTextJson(_addressBook_10);
            case 100:
                return SerialisationSamples.SerialiseWithSystemTextJson(_addressBook_100);
            case 1_000:
                return SerialisationSamples.SerialiseWithSystemTextJson(_addressBook_1_000);
            case 10_000:
                return SerialisationSamples.SerialiseWithSystemTextJson(_addressBook_10_000);
            default:
                return string.Empty;
        }
    }

    [Benchmark(Baseline = true)]
    [Arguments(10)]
    [Arguments(100)]
    [Arguments(1_000)]
    [Arguments(10_000)]
    public string NewtonsoftJsonSerialise(int count)
    {
        switch (count)
        {
            case 10:
                return SerialisationSamples.SerialiseWithNewtonsoftJson(_addressBook_10);
            case 100:
                return SerialisationSamples.SerialiseWithNewtonsoftJson(_addressBook_100);
            case 1_000:
                return SerialisationSamples.SerialiseWithNewtonsoftJson(_addressBook_1_000);
            case 10_000:
                return SerialisationSamples.SerialiseWithNewtonsoftJson(_addressBook_10_000);
            default:
                return string.Empty;
        }
    }

    [Benchmark]
    [Arguments(10)]
    [Arguments(100)]
    [Arguments(1_000)]
    [Arguments(10_000)]
    public void ProtobufNetSerialise(int count)
    {
        MemoryStream stream;

        switch (count)
        {
            case 10:
                stream = SerialisationSamples.SerialiseWithProtobufNet(_addressBook_10);
                stream.Dispose();
                return;
            case 100:
                stream = SerialisationSamples.SerialiseWithProtobufNet(_addressBook_100);
                stream.Dispose();
                return;
            case 1_000:
                stream = SerialisationSamples.SerialiseWithProtobufNet(_addressBook_1_000);
                stream.Dispose();
                return;
            case 10_000:
                stream = SerialisationSamples.SerialiseWithProtobufNet(_addressBook_10_000);
                stream.Dispose();
                return;
            default:
                return;
        }
    }
}
