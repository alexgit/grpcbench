``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.18363.2158 (1909/November2019Update/19H2)
Intel Core i5-8365U CPU 1.60GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 5.0.15 (5.0.1522.11506), X64 RyuJIT
  Job-DXQZHB : .NET 5.0.15 (5.0.1522.11506), X64 RyuJIT

IterationCount=20  LaunchCount=1  WarmupCount=5  

```
|                          Method |       Mean |     Error |    StdDev | Ratio | RatioSD |
|-------------------------------- |-----------:|----------:|----------:|------:|--------:|
|                      IsEntitled |   801.2 μs |  64.02 μs |  73.73 μs |  1.00 |    0.00 |
| IsEntitled_Simulate_1ms_Of_Work | 2,690.7 μs | 335.60 μs | 386.48 μs |  3.38 |    0.53 |
