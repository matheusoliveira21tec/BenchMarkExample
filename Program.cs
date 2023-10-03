// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using BenchMarkExample.Console;

Console.WriteLine("Hello, World!");
BenchmarkRunner.Run<ComparacaoStringBenchMark>();
