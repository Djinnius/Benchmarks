using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkSealedClasses;

//[RPlotExporter]
//[MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class SealedClassBenchmarks
{
    private readonly BaseClass _baseClass = new();
    private readonly OpenClass _openClass = new();
    private readonly SealedClass _sealedClass = new();

    [Benchmark]
    public void OpenVoid() => _openClass.ExampleVoidMethod();

    [Benchmark]
    public void SealedVoid() => _sealedClass.ExampleVoidMethod();


    [Benchmark]
    public int OpenInt() => _openClass.ExampleIntMethod() + 1337;

    [Benchmark]
    public int SealedInt() => _sealedClass.ExampleIntMethod() + 1337;


    [Benchmark]
    public bool OpenIsCheck() => _openClass is OpenClass;

    [Benchmark]
    public bool SealedIsCheck() => _sealedClass is SealedClass;
}

public class BaseClass
{
    public virtual void ExampleVoidMethod() { }
    public virtual int ExampleIntMethod() => 1;
}

public class OpenClass : BaseClass
{
    public override void ExampleVoidMethod() { }
    public override int ExampleIntMethod() => 2;
}

public sealed class SealedClass : BaseClass
{
    public override void ExampleVoidMethod() { }
    public override int ExampleIntMethod() => 2;
}
