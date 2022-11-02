using AutoBogus;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkSerialisation.Dtos;
using Bogus;

namespace BenchmarkSerialisation;

[MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class SerialisationBenchmarks
{
    AddressBook _addressBook = null!;

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

        _addressBook = new AddressBook { Persons = personFaker.Generate(Size) };
    }

    [Params(10, 100, 1_000, 10_000)]
    public int Size { get; set; }

    [Benchmark]
    public string SystemTextJsonSerialise()
    {
        return SerialisationSamples.SerialiseWithSystemTextJson(_addressBook);
    }

    [Benchmark(Baseline = true)]
    public string NewtonsoftJsonSerialise() 
        => SerialisationSamples.SerialiseWithNewtonsoftJson(_addressBook);

    [Benchmark]
    public void ProtobufNetSerialise()
    {
        var stream = SerialisationSamples.SerialiseWithProtobufNet(_addressBook);
        stream.Dispose();
    }
}
