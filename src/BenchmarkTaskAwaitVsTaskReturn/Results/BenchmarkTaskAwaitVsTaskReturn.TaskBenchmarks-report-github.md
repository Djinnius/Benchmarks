``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
12th Gen Intel Core i9-12900K, 1 CPU, 24 logical and 16 physical cores
.NET SDK=6.0.402
  [Host]     : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2


```
|     Method |     Mean |     Error |    StdDev | Allocated |
|----------- |---------:|----------:|----------:|----------:|
| ReturnTask | 1.208 ns | 0.0148 ns | 0.0138 ns |         - |
|  AwaitTask | 6.915 ns | 0.1213 ns | 0.1134 ns |         - |
