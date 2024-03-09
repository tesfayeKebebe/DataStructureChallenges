```

BenchmarkDotNet v0.13.11, Windows 10 (10.0.19045.3930/22H2/2022Update)
Intel Core i3-6006U CPU 2.00GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method                  | Mean     | Error    | StdDev   | Gen0   | Allocated |
|------------------------ |---------:|---------:|---------:|-------:|----------:|
| OrderNumberUsingLinq    | 411.6 ns | 17.61 ns | 51.08 ns | 0.3567 |     560 B |
| OrderNumberUsingForLoop | 189.3 ns |  3.29 ns |  3.38 ns | 0.0815 |     128 B |
