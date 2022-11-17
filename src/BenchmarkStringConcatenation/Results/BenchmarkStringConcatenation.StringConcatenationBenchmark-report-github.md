``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
12th Gen Intel Core i9-12900K, 1 CPU, 24 logical and 16 physical cores
.NET SDK=6.0.402
  [Host]     : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2


```
|                            Method | Size |        Mean |      Error |     StdDev |      Median | Ratio | RatioSD |   Gen0 |   Gen1 | Allocated | Alloc Ratio |
|---------------------------------- |----- |------------:|-----------:|-----------:|------------:|------:|--------:|-------:|-------:|----------:|------------:|
|       Concatenate_ByStringLiteral |    2 |    16.99 ns |   0.506 ns |   1.493 ns |    17.61 ns |  1.00 |    0.00 | 0.0036 |      - |      56 B |        1.00 |
| Concatenate_ByStringInterpolation |    2 |    17.15 ns |   0.427 ns |   1.258 ns |    17.56 ns |  1.02 |    0.13 | 0.0036 |      - |      56 B |        1.00 |
|       Concatenate_ByStringBuilder |    2 |    31.90 ns |   1.029 ns |   3.033 ns |    32.98 ns |  1.89 |    0.24 | 0.0102 |      - |     160 B |        2.86 |
|        Concatenate_ByStringConcat |    2 |    44.67 ns |   1.602 ns |   4.723 ns |    47.20 ns |  2.65 |    0.39 | 0.0061 |      - |      96 B |        1.71 |
|        Concatenate_ByStringFormat |    2 |    99.43 ns |   5.396 ns |  15.911 ns |   105.78 ns |  5.90 |    1.11 | 0.0056 |      - |      88 B |        1.57 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|       Concatenate_ByStringLiteral |    4 |    42.48 ns |   1.526 ns |   4.501 ns |    43.31 ns |  1.00 |    0.00 | 0.0143 |      - |     224 B |        1.00 |
| Concatenate_ByStringInterpolation |    4 |    44.07 ns |   1.329 ns |   3.918 ns |    45.50 ns |  1.05 |    0.18 | 0.0143 |      - |     224 B |        1.00 |
|        Concatenate_ByStringConcat |    4 |    69.72 ns |   1.854 ns |   5.466 ns |    71.38 ns |  1.66 |    0.27 | 0.0086 |      - |     136 B |        0.61 |
|       Concatenate_ByStringBuilder |    4 |    92.49 ns |   4.465 ns |  13.166 ns |    98.79 ns |  2.21 |    0.46 | 0.0280 |      - |     440 B |        1.96 |
|        Concatenate_ByStringFormat |    4 |   209.93 ns |  10.646 ns |  31.390 ns |   223.85 ns |  5.03 |    1.13 | 0.0162 |      - |     256 B |        1.14 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|       Concatenate_ByStringLiteral |    6 |    78.72 ns |   2.903 ns |   8.561 ns |    82.59 ns |  1.00 |    0.00 | 0.0331 |      - |     520 B |        1.00 |
| Concatenate_ByStringInterpolation |    6 |    79.56 ns |   2.189 ns |   6.455 ns |    81.62 ns |  1.03 |    0.18 | 0.0331 |      - |     520 B |        1.00 |
|        Concatenate_ByStringConcat |    6 |    87.31 ns |   3.895 ns |  11.486 ns |    91.36 ns |  1.12 |    0.20 | 0.0126 |      - |     200 B |        0.38 |
|       Concatenate_ByStringBuilder |    6 |   134.82 ns |   6.061 ns |  17.872 ns |   141.70 ns |  1.74 |    0.34 | 0.0448 |      - |     704 B |        1.35 |
|        Concatenate_ByStringFormat |    6 |   318.10 ns |  12.908 ns |  38.059 ns |   327.09 ns |  4.10 |    0.73 | 0.0350 |      - |     552 B |        1.06 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|        Concatenate_ByStringConcat |    8 |   106.76 ns |   5.450 ns |  16.070 ns |   113.20 ns |  0.96 |    0.22 | 0.0148 |      - |     232 B |        0.26 |
|       Concatenate_ByStringLiteral |    8 |   113.44 ns |   5.651 ns |  16.663 ns |   119.28 ns |  1.00 |    0.00 | 0.0560 |      - |     880 B |        1.00 |
| Concatenate_ByStringInterpolation |    8 |   119.60 ns |   4.092 ns |  12.064 ns |   123.76 ns |  1.08 |    0.22 | 0.0560 |      - |     880 B |        1.00 |
|       Concatenate_ByStringBuilder |    8 |   150.46 ns |   4.556 ns |  13.432 ns |   154.34 ns |  1.36 |    0.28 | 0.0468 |      - |     736 B |        0.84 |
|        Concatenate_ByStringFormat |    8 |   442.79 ns |  23.216 ns |  68.453 ns |   471.05 ns |  4.01 |    0.97 | 0.0577 |      - |     912 B |        1.04 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|        Concatenate_ByStringConcat |   10 |   131.81 ns |   4.721 ns |  13.921 ns |   136.05 ns |  0.85 |    0.14 | 0.0168 |      - |     264 B |        0.20 |
|       Concatenate_ByStringLiteral |   10 |   157.48 ns |   5.496 ns |  16.204 ns |   160.26 ns |  1.00 |    0.00 | 0.0836 |      - |    1312 B |        1.00 |
|       Concatenate_ByStringBuilder |   10 |   162.32 ns |   5.983 ns |  17.640 ns |   167.74 ns |  1.04 |    0.18 | 0.0489 |      - |     768 B |        0.59 |
| Concatenate_ByStringInterpolation |   10 |   162.89 ns |   4.664 ns |  13.751 ns |   165.99 ns |  1.05 |    0.15 | 0.0836 |      - |    1312 B |        1.00 |
|        Concatenate_ByStringFormat |   10 |   591.82 ns |  19.297 ns |  56.897 ns |   607.65 ns |  3.80 |    0.58 | 0.0854 |      - |    1344 B |        1.02 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|        Concatenate_ByStringConcat |   12 |   163.04 ns |   3.303 ns |   7.654 ns |   165.18 ns |  0.77 |    0.13 | 0.0254 |      - |     400 B |        0.21 |
|       Concatenate_ByStringLiteral |   12 |   218.22 ns |   9.184 ns |  27.078 ns |   228.06 ns |  1.00 |    0.00 | 0.1233 |      - |    1936 B |        1.00 |
|       Concatenate_ByStringBuilder |   12 |   220.26 ns |   8.476 ns |  24.991 ns |   232.57 ns |  1.02 |    0.17 | 0.0784 |      - |    1232 B |        0.64 |
| Concatenate_ByStringInterpolation |   12 |   223.18 ns |   7.601 ns |  22.411 ns |   230.19 ns |  1.04 |    0.17 | 0.1233 |      - |    1936 B |        1.00 |
|        Concatenate_ByStringFormat |   12 |   733.80 ns |  24.654 ns |  72.694 ns |   756.59 ns |  3.42 |    0.60 | 0.1254 |      - |    1968 B |        1.02 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|        Concatenate_ByStringConcat |   14 |   184.99 ns |   7.716 ns |  22.750 ns |   195.61 ns |  0.65 |    0.11 | 0.0269 |      - |     424 B |        0.16 |
|       Concatenate_ByStringBuilder |   14 |   235.19 ns |   5.402 ns |  15.929 ns |   240.79 ns |  0.83 |    0.09 | 0.0799 |      - |    1256 B |        0.47 |
| Concatenate_ByStringInterpolation |   14 |   285.98 ns |   9.057 ns |  26.705 ns |   294.00 ns |  1.01 |    0.14 | 0.1719 |      - |    2696 B |        1.00 |
|       Concatenate_ByStringLiteral |   14 |   286.18 ns |   8.186 ns |  24.136 ns |   293.52 ns |  1.00 |    0.00 | 0.1719 |      - |    2696 B |        1.00 |
|        Concatenate_ByStringFormat |   14 |   873.91 ns |  42.699 ns | 125.898 ns |   922.58 ns |  3.08 |    0.53 | 0.1736 |      - |    2728 B |        1.01 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|        Concatenate_ByStringConcat |   16 |   189.66 ns |   8.234 ns |  24.279 ns |   197.62 ns |  0.54 |    0.09 | 0.0284 |      - |     448 B |        0.13 |
|       Concatenate_ByStringBuilder |   16 |   228.65 ns |  10.584 ns |  31.207 ns |   241.08 ns |  0.65 |    0.11 | 0.0815 | 0.0002 |    1280 B |        0.37 |
| Concatenate_ByStringInterpolation |   16 |   329.57 ns |  13.770 ns |  40.602 ns |   340.44 ns |  0.94 |    0.14 | 0.2234 |      - |    3504 B |        1.00 |
|       Concatenate_ByStringLiteral |   16 |   354.48 ns |   9.675 ns |  28.526 ns |   362.78 ns |  1.00 |    0.00 | 0.2234 |      - |    3504 B |        1.00 |
|        Concatenate_ByStringFormat |   16 |   991.34 ns |  52.332 ns | 154.303 ns | 1,057.73 ns |  2.82 |    0.52 | 0.2251 |      - |    3536 B |        1.01 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|        Concatenate_ByStringConcat |   18 |   233.44 ns |   6.957 ns |  20.514 ns |   240.30 ns |  0.60 |    0.12 | 0.0305 |      - |     480 B |        0.11 |
|       Concatenate_ByStringBuilder |   18 |   242.20 ns |   9.124 ns |  26.903 ns |   249.34 ns |  0.62 |    0.13 | 0.0834 |      - |    1312 B |        0.30 |
|       Concatenate_ByStringLiteral |   18 |   400.07 ns |  18.570 ns |  54.755 ns |   414.23 ns |  1.00 |    0.00 | 0.2785 | 0.0005 |    4368 B |        1.00 |
| Concatenate_ByStringInterpolation |   18 |   404.76 ns |  18.472 ns |  54.466 ns |   422.28 ns |  1.03 |    0.20 | 0.2785 |      - |    4368 B |        1.00 |
|        Concatenate_ByStringFormat |   18 | 1,249.92 ns |  34.803 ns | 102.617 ns | 1,272.88 ns |  3.19 |    0.56 | 0.2804 |      - |    4400 B |        1.01 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|        Concatenate_ByStringConcat |   20 |   260.43 ns |   6.264 ns |  17.460 ns |   264.94 ns |  0.51 |    0.05 | 0.0336 |      - |     528 B |        0.10 |
|       Concatenate_ByStringBuilder |   20 |   277.36 ns |   5.579 ns |  13.579 ns |   276.54 ns |  0.55 |    0.05 | 0.0865 |      - |    1360 B |        0.26 |
| Concatenate_ByStringInterpolation |   20 |   517.26 ns |  16.405 ns |  47.332 ns |   531.27 ns |  1.01 |    0.12 | 0.3390 |      - |    5320 B |        1.00 |
|       Concatenate_ByStringLiteral |   20 |   517.44 ns |  13.909 ns |  40.574 ns |   522.69 ns |  1.00 |    0.00 | 0.3390 |      - |    5320 B |        1.00 |
|        Concatenate_ByStringFormat |   20 | 1,484.62 ns |  29.263 ns |  53.508 ns | 1,485.85 ns |  2.99 |    0.35 | 0.3405 | 0.0010 |    5352 B |        1.01 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|        Concatenate_ByStringConcat |   22 |   284.59 ns |   9.797 ns |  28.886 ns |   293.06 ns |  0.53 |    0.09 | 0.0346 |      - |     544 B |        0.09 |
|       Concatenate_ByStringBuilder |   22 |   286.31 ns |   5.769 ns |  13.140 ns |   291.69 ns |  0.54 |    0.08 | 0.0877 |      - |    1376 B |        0.22 |
|       Concatenate_ByStringLiteral |   22 |   546.25 ns |  21.436 ns |  63.206 ns |   557.84 ns |  1.00 |    0.00 | 0.4029 |      - |    6320 B |        1.00 |
| Concatenate_ByStringInterpolation |   22 |   567.24 ns |  15.571 ns |  45.912 ns |   570.71 ns |  1.05 |    0.15 | 0.4029 |      - |    6320 B |        1.00 |
|        Concatenate_ByStringFormat |   22 | 1,511.28 ns |  53.827 ns | 158.709 ns | 1,535.11 ns |  2.80 |    0.43 | 0.4044 |      - |    6352 B |        1.01 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|       Concatenate_ByStringBuilder |   24 |   327.77 ns |   9.703 ns |  28.609 ns |   334.48 ns |  0.54 |    0.09 | 0.1299 |      - |    2040 B |        0.27 |
|        Concatenate_ByStringConcat |   24 |   328.56 ns |   8.518 ns |  25.116 ns |   335.13 ns |  0.54 |    0.09 | 0.0396 |      - |     624 B |        0.08 |
|       Concatenate_ByStringLiteral |   24 |   621.99 ns |  28.580 ns |  84.268 ns |   635.48 ns |  1.00 |    0.00 | 0.4745 | 0.0014 |    7448 B |        1.00 |
| Concatenate_ByStringInterpolation |   24 |   648.91 ns |  22.155 ns |  65.324 ns |   659.25 ns |  1.06 |    0.18 | 0.4745 |      - |    7448 B |        1.00 |
|        Concatenate_ByStringFormat |   24 | 1,719.77 ns |  83.456 ns | 246.073 ns | 1,761.72 ns |  2.83 |    0.61 | 0.4768 |      - |    7480 B |        1.00 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|       Concatenate_ByStringBuilder |   26 |   346.14 ns |   8.039 ns |  23.704 ns |   348.37 ns |  0.49 |    0.07 | 0.1340 |      - |    2104 B |        0.24 |
|        Concatenate_ByStringConcat |   26 |   349.40 ns |   8.776 ns |  25.876 ns |   353.89 ns |  0.49 |    0.07 | 0.0439 |      - |     688 B |        0.08 |
|       Concatenate_ByStringLiteral |   26 |   716.05 ns |  26.677 ns |  78.656 ns |   732.03 ns |  1.00 |    0.00 | 0.5536 |      - |    8688 B |        1.00 |
| Concatenate_ByStringInterpolation |   26 |   726.69 ns |  35.472 ns | 104.590 ns |   754.14 ns |  1.03 |    0.18 | 0.5531 |      - |    8688 B |        1.00 |
|        Concatenate_ByStringFormat |   26 | 1,947.13 ns |  98.162 ns | 289.432 ns | 1,997.76 ns |  2.76 |    0.54 | 0.5550 |      - |    8720 B |        1.00 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|       Concatenate_ByStringBuilder |   28 |   352.17 ns |  16.295 ns |  48.045 ns |   374.63 ns |  0.42 |    0.07 | 0.1364 |      - |    2144 B |        0.21 |
|        Concatenate_ByStringConcat |   28 |   378.68 ns |  14.673 ns |  43.264 ns |   398.01 ns |  0.45 |    0.07 | 0.0463 |      - |     728 B |        0.07 |
| Concatenate_ByStringInterpolation |   28 |   842.70 ns |  30.076 ns |  88.680 ns |   865.85 ns |  1.01 |    0.17 | 0.6409 |      - |   10056 B |        1.00 |
|       Concatenate_ByStringLiteral |   28 |   844.91 ns |  36.335 ns | 107.134 ns |   882.65 ns |  1.00 |    0.00 | 0.6409 | 0.0019 |   10056 B |        1.00 |
|        Concatenate_ByStringFormat |   28 | 2,333.82 ns |  89.953 ns | 265.230 ns | 2,393.49 ns |  2.80 |    0.49 | 0.6428 |      - |   10088 B |        1.00 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|       Concatenate_ByStringBuilder |   30 |   374.89 ns |  12.058 ns |  35.552 ns |   395.03 ns |  0.40 |    0.07 | 0.1392 |      - |    2184 B |        0.19 |
|        Concatenate_ByStringConcat |   30 |   380.81 ns |  13.841 ns |  40.810 ns |   385.97 ns |  0.41 |    0.06 | 0.0486 |      - |     768 B |        0.07 |
|       Concatenate_ByStringLiteral |   30 |   943.77 ns |  38.175 ns | 112.561 ns |   976.22 ns |  1.00 |    0.00 | 0.7315 | 0.0029 |   11480 B |        1.00 |
| Concatenate_ByStringInterpolation |   30 |   969.67 ns |  27.181 ns |  80.143 ns |   980.98 ns |  1.04 |    0.16 | 0.7315 |      - |   11480 B |        1.00 |
|        Concatenate_ByStringFormat |   30 | 2,550.17 ns |  82.244 ns | 242.498 ns | 2,624.70 ns |  2.76 |    0.55 | 0.7324 |      - |   11512 B |        1.00 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|       Concatenate_ByStringBuilder |   32 |   396.62 ns |   9.779 ns |  28.834 ns |   409.87 ns |  0.37 |    0.04 | 0.1402 | 0.0010 |    2200 B |        0.17 |
|        Concatenate_ByStringConcat |   32 |   411.93 ns |  13.553 ns |  39.960 ns |   423.41 ns |  0.39 |    0.05 | 0.0496 |      - |     784 B |        0.06 |
| Concatenate_ByStringInterpolation |   32 | 1,075.01 ns |  33.772 ns |  99.579 ns | 1,105.38 ns |  1.01 |    0.14 | 0.8268 |      - |   12968 B |        1.00 |
|       Concatenate_ByStringLiteral |   32 | 1,075.17 ns |  31.992 ns |  94.330 ns | 1,098.36 ns |  1.00 |    0.00 | 0.8268 | 0.0038 |   12968 B |        1.00 |
|        Concatenate_ByStringFormat |   32 | 3,063.42 ns |  60.965 ns | 106.775 ns | 3,094.00 ns |  2.96 |    0.29 | 0.8278 | 0.0038 |   13000 B |        1.00 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|       Concatenate_ByStringBuilder |   34 |   393.32 ns |  14.264 ns |  42.058 ns |   415.14 ns |  0.33 |    0.04 | 0.1421 | 0.0010 |    2232 B |        0.15 |
|        Concatenate_ByStringConcat |   34 |   438.30 ns |  11.552 ns |  34.061 ns |   449.54 ns |  0.37 |    0.04 | 0.0520 |      - |     816 B |        0.06 |
|       Concatenate_ByStringLiteral |   34 | 1,202.74 ns |  38.729 ns | 114.192 ns | 1,243.98 ns |  1.00 |    0.00 | 0.9251 | 0.0038 |   14512 B |        1.00 |
| Concatenate_ByStringInterpolation |   34 | 1,215.32 ns |  31.023 ns |  91.473 ns | 1,241.43 ns |  1.02 |    0.10 | 0.9251 |      - |   14512 B |        1.00 |
|        Concatenate_ByStringFormat |   34 | 3,022.40 ns | 112.471 ns | 331.624 ns | 3,116.12 ns |  2.54 |    0.41 | 0.9270 | 0.0038 |   14544 B |        1.00 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|       Concatenate_ByStringBuilder |   36 |   413.55 ns |  15.963 ns |  46.816 ns |   433.83 ns |  0.31 |    0.04 | 0.1450 |      - |    2280 B |        0.14 |
|        Concatenate_ByStringConcat |   36 |   460.61 ns |  14.801 ns |  43.642 ns |   479.78 ns |  0.34 |    0.04 | 0.0548 |      - |     864 B |        0.05 |
|       Concatenate_ByStringLiteral |   36 | 1,340.52 ns |  26.782 ns |  75.099 ns | 1,367.93 ns |  1.00 |    0.00 | 1.0290 | 0.0048 |   16152 B |        1.00 |
| Concatenate_ByStringInterpolation |   36 | 1,372.72 ns |  26.717 ns |  27.436 ns | 1,378.62 ns |  1.03 |    0.06 | 1.0290 | 0.0048 |   16152 B |        1.00 |
|        Concatenate_ByStringFormat |   36 | 3,335.66 ns | 130.969 ns | 386.164 ns | 3,515.62 ns |  2.51 |    0.32 | 1.0300 | 0.0038 |   16184 B |        1.00 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|       Concatenate_ByStringBuilder |   38 |   427.75 ns |  10.902 ns |  32.144 ns |   439.27 ns |  0.30 |    0.03 | 0.1488 | 0.0010 |    2336 B |        0.13 |
|        Concatenate_ByStringConcat |   38 |   479.25 ns |  12.178 ns |  35.908 ns |   492.41 ns |  0.33 |    0.04 | 0.0587 |      - |     920 B |        0.05 |
|       Concatenate_ByStringLiteral |   38 | 1,451.22 ns |  35.358 ns | 104.255 ns | 1,483.23 ns |  1.00 |    0.00 | 1.1415 | 0.0057 |   17904 B |        1.00 |
| Concatenate_ByStringInterpolation |   38 | 1,508.91 ns |  29.386 ns |  45.750 ns | 1,521.37 ns |  1.04 |    0.07 | 1.1415 | 0.0057 |   17904 B |        1.00 |
|        Concatenate_ByStringFormat |   38 | 3,591.57 ns | 160.263 ns | 472.539 ns | 3,765.70 ns |  2.49 |    0.41 | 1.1406 | 0.0038 |   17936 B |        1.00 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|       Concatenate_ByStringBuilder |   40 |   443.37 ns |  13.177 ns |  38.853 ns |   456.84 ns |  0.29 |    0.05 | 0.1540 |      - |    2416 B |        0.12 |
|        Concatenate_ByStringConcat |   40 |   501.05 ns |  13.928 ns |  41.067 ns |   513.15 ns |  0.32 |    0.05 | 0.0634 |      - |    1000 B |        0.05 |
| Concatenate_ByStringInterpolation |   40 | 1,576.71 ns |  38.975 ns | 114.920 ns | 1,612.68 ns |  1.02 |    0.21 | 1.2608 | 0.0067 |   19784 B |        1.00 |
|       Concatenate_ByStringLiteral |   40 | 1,585.81 ns |  70.084 ns | 206.646 ns | 1,671.61 ns |  1.00 |    0.00 | 1.2608 | 0.0057 |   19784 B |        1.00 |
|        Concatenate_ByStringFormat |   40 | 3,936.00 ns | 138.493 ns | 408.351 ns | 4,056.75 ns |  2.53 |    0.46 | 1.2627 | 0.0038 |   19816 B |        1.00 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|       Concatenate_ByStringBuilder |   42 |   446.25 ns |  16.111 ns |  47.503 ns |   461.26 ns |  0.27 |    0.04 | 0.1559 |      - |    2448 B |        0.11 |
|        Concatenate_ByStringConcat |   42 |   530.45 ns |  10.638 ns |  29.830 ns |   540.99 ns |  0.32 |    0.05 | 0.0653 |      - |    1032 B |        0.05 |
|       Concatenate_ByStringLiteral |   42 | 1,701.13 ns |  74.868 ns | 220.751 ns | 1,779.59 ns |  1.00 |    0.00 | 1.3866 | 0.0076 |   21760 B |        1.00 |
| Concatenate_ByStringInterpolation |   42 | 1,738.44 ns |  69.256 ns | 204.204 ns | 1,824.92 ns |  1.03 |    0.12 | 1.3866 | 0.0076 |   21760 B |        1.00 |
|        Concatenate_ByStringFormat |   42 | 4,076.56 ns | 158.511 ns | 467.372 ns | 4,241.60 ns |  2.45 |    0.53 | 1.3885 | 0.0076 |   21792 B |        1.00 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|       Concatenate_ByStringBuilder |   44 |   541.63 ns |  13.495 ns |  39.789 ns |   555.32 ns |  0.30 |    0.06 | 0.2294 | 0.0029 |    3600 B |        0.15 |
|        Concatenate_ByStringConcat |   44 |   587.04 ns |  14.983 ns |  44.178 ns |   599.00 ns |  0.33 |    0.06 | 0.0691 |      - |    1088 B |        0.05 |
|       Concatenate_ByStringLiteral |   44 | 1,829.68 ns |  82.530 ns | 243.343 ns | 1,915.08 ns |  1.00 |    0.00 | 1.5182 | 0.0095 |   23824 B |        1.00 |
| Concatenate_ByStringInterpolation |   44 | 1,875.68 ns |  75.479 ns | 222.550 ns | 1,978.42 ns |  1.04 |    0.13 | 1.5182 | 0.0095 |   23824 B |        1.00 |
|        Concatenate_ByStringFormat |   44 | 4,708.57 ns | 136.793 ns | 403.336 ns | 4,852.91 ns |  2.63 |    0.47 | 1.5182 | 0.0076 |   23856 B |        1.00 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|       Concatenate_ByStringBuilder |   46 |   539.42 ns |  17.970 ns |  52.986 ns |   551.10 ns |  0.25 |    0.03 | 0.2308 |      - |    3624 B |        0.14 |
|        Concatenate_ByStringConcat |   46 |   604.74 ns |  12.530 ns |  36.944 ns |   621.61 ns |  0.28 |    0.02 | 0.0706 |      - |    1112 B |        0.04 |
| Concatenate_ByStringInterpolation |   46 | 2,088.17 ns |  48.047 ns | 141.667 ns | 2,123.31 ns |  0.98 |    0.09 | 1.6537 | 0.0095 |   25952 B |        1.00 |
|       Concatenate_ByStringLiteral |   46 | 2,136.93 ns |  42.568 ns | 122.136 ns | 2,192.04 ns |  1.00 |    0.00 | 1.6537 | 0.0095 |   25952 B |        1.00 |
|        Concatenate_ByStringFormat |   46 | 4,891.37 ns | 139.380 ns | 410.964 ns | 4,998.53 ns |  2.30 |    0.25 | 1.6556 | 0.0076 |   25984 B |        1.00 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|       Concatenate_ByStringBuilder |   48 |   569.07 ns |  14.931 ns |  44.023 ns |   584.71 ns |  0.26 |    0.03 | 0.2327 | 0.0029 |    3656 B |        0.13 |
|        Concatenate_ByStringConcat |   48 |   645.07 ns |  12.726 ns |  23.588 ns |   654.73 ns |  0.31 |    0.06 | 0.0725 |      - |    1144 B |        0.04 |
|       Concatenate_ByStringLiteral |   48 | 2,204.70 ns |  76.299 ns | 224.969 ns | 2,276.00 ns |  1.00 |    0.00 | 1.7929 | 0.0114 |   28144 B |        1.00 |
| Concatenate_ByStringInterpolation |   48 | 2,238.81 ns |  68.071 ns | 200.708 ns | 2,318.99 ns |  1.02 |    0.11 | 1.7929 | 0.0114 |   28144 B |        1.00 |
|        Concatenate_ByStringFormat |   48 | 5,266.70 ns | 139.652 ns | 411.766 ns | 5,429.29 ns |  2.41 |    0.33 | 1.7929 | 0.0114 |   28176 B |        1.00 |
|                                   |      |             |            |            |             |       |         |        |        |           |             |
|       Concatenate_ByStringBuilder |   50 |   578.34 ns |  15.060 ns |  44.405 ns |   593.92 ns |  0.24 |    0.02 | 0.2365 | 0.0029 |    3712 B |        0.12 |
|        Concatenate_ByStringConcat |   50 |   661.31 ns |  13.252 ns |  38.022 ns |   674.09 ns |  0.28 |    0.03 | 0.0763 |      - |    1200 B |        0.04 |
|       Concatenate_ByStringLiteral |   50 | 2,417.88 ns |  57.082 ns | 168.308 ns | 2,468.57 ns |  1.00 |    0.00 | 1.9398 | 0.0134 |   30424 B |        1.00 |
| Concatenate_ByStringInterpolation |   50 | 2,446.81 ns |  58.589 ns | 172.750 ns | 2,505.04 ns |  1.02 |    0.10 | 1.9398 | 0.0134 |   30424 B |        1.00 |
|        Concatenate_ByStringFormat |   50 | 5,612.27 ns | 138.094 ns | 407.172 ns | 5,768.98 ns |  2.33 |    0.22 | 1.9417 | 0.0114 |   30456 B |        1.00 |
