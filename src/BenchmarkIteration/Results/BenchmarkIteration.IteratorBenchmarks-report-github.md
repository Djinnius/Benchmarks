``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
12th Gen Intel Core i9-12900K, 1 CPU, 24 logical and 16 physical cores
.NET SDK=6.0.402
  [Host]     : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2


```
|           Method |    Size |             Mean |           Error |          StdDev |           Median |    Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|----------------- |-------- |-----------------:|----------------:|----------------:|-----------------:|---------:|--------:|-------:|----------:|------------:|
|              For |      10 |         2.950 ns |       0.0218 ns |       0.0204 ns |         2.947 ns |     1.00 |    0.00 |      - |         - |          NA |
|     ForEach_Span |      10 |         3.127 ns |       0.0156 ns |       0.0145 ns |         3.121 ns |     1.06 |    0.01 |      - |         - |          NA |
|         For_Span |      10 |         3.254 ns |       0.0131 ns |       0.0116 ns |         3.253 ns |     1.10 |    0.01 |      - |         - |          NA |
|          ForEach |      10 |         5.304 ns |       0.0313 ns |       0.0292 ns |         5.316 ns |     1.80 |    0.01 |      - |         - |          NA |
|     ForEach_Linq |      10 |        13.123 ns |       0.0892 ns |       0.0834 ns |        13.163 ns |     4.45 |    0.04 |      - |         - |          NA |
| Parallel_ForEach |      10 |     1,924.519 ns |      33.4075 ns |      31.2494 ns |     1,907.012 ns |   652.48 |   11.20 | 0.1469 |    2296 B |          NA |
|    Parallel_Linq |      10 |    18,579.844 ns |      91.8663 ns |      85.9318 ns |    18,581.715 ns | 6,299.23 |   51.34 | 0.5798 |    9080 B |          NA |
|                  |         |                  |                 |                 |                  |          |         |        |           |             |
|     ForEach_Span |     100 |        27.370 ns |       0.1504 ns |       0.1333 ns |        27.382 ns |     0.67 |    0.00 |      - |         - |          NA |
|         For_Span |     100 |        31.539 ns |       0.0883 ns |       0.0826 ns |        31.543 ns |     0.77 |    0.00 |      - |         - |          NA |
|              For |     100 |        40.865 ns |       0.1208 ns |       0.1008 ns |        40.880 ns |     1.00 |    0.00 |      - |         - |          NA |
|          ForEach |     100 |        52.092 ns |       0.1902 ns |       0.1779 ns |        52.069 ns |     1.27 |    0.01 |      - |         - |          NA |
|     ForEach_Linq |     100 |       128.193 ns |       0.4236 ns |       0.3962 ns |       128.100 ns |     3.14 |    0.01 |      - |         - |          NA |
| Parallel_ForEach |     100 |     6,411.532 ns |      82.0115 ns |      76.7136 ns |     6,375.463 ns |   156.37 |    1.51 | 0.2594 |    4030 B |          NA |
|    Parallel_Linq |     100 |    18,417.781 ns |     100.0008 ns |      93.5408 ns |    18,388.776 ns |   450.97 |    2.47 | 0.5798 |    9080 B |          NA |
|                  |         |                  |                 |                 |                  |          |         |        |           |             |
|     ForEach_Span |    1000 |       210.021 ns |       1.1314 ns |       1.0583 ns |       210.108 ns |     0.67 |    0.00 |      - |         - |          NA |
|         For_Span |    1000 |       212.488 ns |       0.9424 ns |       0.8815 ns |       212.402 ns |     0.68 |    0.00 |      - |         - |          NA |
|              For |    1000 |       312.764 ns |       0.8650 ns |       0.8092 ns |       313.106 ns |     1.00 |    0.00 |      - |         - |          NA |
|          ForEach |    1000 |       416.293 ns |       1.3162 ns |       1.2312 ns |       416.654 ns |     1.33 |    0.00 |      - |         - |          NA |
|     ForEach_Linq |    1000 |     1,227.173 ns |       5.0625 ns |       4.7354 ns |     1,229.088 ns |     3.92 |    0.02 |      - |         - |          NA |
| Parallel_ForEach |    1000 |    14,055.285 ns |     128.7855 ns |     120.4661 ns |    14,071.825 ns |    44.94 |    0.42 | 0.3510 |    5418 B |          NA |
|    Parallel_Linq |    1000 |    18,961.621 ns |      63.5059 ns |      56.2963 ns |    18,956.241 ns |    60.62 |    0.20 | 0.5798 |    9080 B |          NA |
|                  |         |                  |                 |                 |                  |          |         |        |           |             |
|         For_Span |   10000 |     2,031.718 ns |       9.5239 ns |       8.9087 ns |     2,030.445 ns |     0.67 |    0.00 |      - |         - |          NA |
|     ForEach_Span |   10000 |     2,035.692 ns |      13.1655 ns |      12.3150 ns |     2,037.048 ns |     0.67 |    0.01 |      - |         - |          NA |
|              For |   10000 |     3,039.295 ns |      12.8688 ns |      12.0374 ns |     3,039.617 ns |     1.00 |    0.00 |      - |         - |          NA |
|          ForEach |   10000 |     4,074.281 ns |       8.4687 ns |       7.5072 ns |     4,074.698 ns |     1.34 |    0.01 |      - |         - |          NA |
|     ForEach_Linq |   10000 |    12,160.588 ns |      61.3928 ns |      57.4269 ns |    12,173.096 ns |     4.00 |    0.03 |      - |         - |          NA |
|    Parallel_Linq |   10000 |    20,283.114 ns |      91.8103 ns |      85.8794 ns |    20,277.457 ns |     6.67 |    0.04 | 0.5798 |    9080 B |          NA |
| Parallel_ForEach |   10000 |    27,296.803 ns |     128.3040 ns |     120.0156 ns |    27,343.010 ns |     8.98 |    0.05 | 0.3967 |    6509 B |          NA |
|                  |         |                  |                 |                 |                  |          |         |        |           |             |
|         For_Span |  100000 |    20,253.256 ns |      86.8612 ns |      77.0002 ns |    20,246.857 ns |     0.67 |    0.00 |      - |         - |          NA |
|     ForEach_Span |  100000 |    20,307.445 ns |      84.9596 ns |      75.3144 ns |    20,286.664 ns |     0.67 |    0.00 |      - |         - |          NA |
|              For |  100000 |    30,370.951 ns |      91.8717 ns |      85.9368 ns |    30,373.384 ns |     1.00 |    0.00 |      - |         - |          NA |
|          ForEach |  100000 |    40,609.622 ns |     229.0277 ns |     214.2327 ns |    40,640.143 ns |     1.34 |    0.01 |      - |         - |          NA |
| Parallel_ForEach |  100000 |    56,926.118 ns |     487.4980 ns |     432.1542 ns |    56,782.599 ns |     1.87 |    0.02 | 0.3662 |    6445 B |          NA |
|    Parallel_Linq |  100000 |   102,844.347 ns |   2,046.9429 ns |   3,475.8644 ns |   103,063.672 ns |     3.32 |    0.12 | 0.4883 |    9141 B |          NA |
|     ForEach_Linq |  100000 |   121,100.048 ns |     382.8184 ns |     358.0886 ns |   121,127.283 ns |     3.99 |    0.01 |      - |         - |          NA |
|                  |         |                  |                 |                 |                  |          |         |        |           |             |
|     ForEach_Span | 1000000 |   294,415.404 ns |   9,219.5359 ns |  27,184.0096 ns |   303,732.935 ns |     0.94 |    0.11 |      - |         - |          NA |
|              For | 1000000 |   302,833.791 ns |     788.8228 ns |     737.8653 ns |   302,737.866 ns |     1.00 |    0.00 |      - |         - |          NA |
| Parallel_ForEach | 1000000 |   364,568.229 ns |   6,941.9359 ns |   7,128.8571 ns |   365,854.565 ns |     1.20 |    0.02 |      - |    6469 B |          NA |
|         For_Span | 1000000 |   364,928.219 ns |  18,080.2884 ns |  53,310.1383 ns |   383,236.609 ns |     1.21 |    0.20 |      - |         - |          NA |
|          ForEach | 1000000 |   405,841.532 ns |   1,758.6955 ns |   1,645.0849 ns |   405,647.583 ns |     1.34 |    0.01 |      - |         - |          NA |
|     ForEach_Linq | 1000000 | 1,220,224.069 ns |   6,707.0420 ns |   6,273.7712 ns | 1,220,414.746 ns |     4.03 |    0.02 |      - |       1 B |          NA |
|    Parallel_Linq | 1000000 | 1,320,338.946 ns | 220,828.0024 ns | 651,116.3474 ns | 1,445,257.959 ns |     2.02 |    0.08 |      - |    9139 B |          NA |
