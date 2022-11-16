``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
12th Gen Intel Core i9-12900K, 1 CPU, 24 logical and 16 physical cores
.NET SDK=6.0.402
  [Host]     : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2


```
|                    Method |      Mean |    Error |    StdDev |    Median | Ratio | RatioSD |   Gen0 |   Gen1 | Allocated | Alloc Ratio |
|-------------------------- |----------:|---------:|----------:|----------:|------:|--------:|-------:|-------:|----------:|------------:|
|            MapsterCodeGen |  44.27 ns | 0.934 ns |  1.339 ns |  44.03 ns |  0.52 |    0.11 | 0.0265 | 0.0001 |     416 B |        0.85 |
|                 ManualMap |  92.44 ns | 3.964 ns | 11.689 ns |  96.13 ns |  1.00 |    0.00 | 0.0311 |      - |     488 B |        1.00 |
| MapsterAdaptWithoutConfig |  93.42 ns | 2.181 ns |  6.430 ns |  95.91 ns |  1.03 |    0.19 | 0.0265 | 0.0001 |     416 B |        0.85 |
|    MapsterAdaptWithConfig | 116.60 ns | 3.147 ns |  9.280 ns | 119.32 ns |  1.28 |    0.20 | 0.0265 |      - |     416 B |        0.85 |
|        MapsterAdaptToType | 128.85 ns | 3.582 ns | 10.560 ns | 132.51 ns |  1.41 |    0.20 | 0.0290 |      - |     456 B |        0.93 |
|                AutoMapper | 145.27 ns | 4.298 ns | 12.673 ns | 150.58 ns |  1.61 |    0.30 | 0.0269 |      - |     424 B |        0.87 |
|             ExpressMapper | 252.51 ns | 9.039 ns | 26.650 ns | 258.75 ns |  2.77 |    0.45 | 0.0372 |      - |     584 B |        1.20 |
