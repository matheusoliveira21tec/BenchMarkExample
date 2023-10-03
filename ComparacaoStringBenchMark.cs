using BenchmarkDotNet.Attributes;
namespace BenchMarkExample.Console;

public class ComparacaoStringBenchMark

{
    public string nome1 = "MathEUSdeV";
    public string nome2 = "matHEUSdEV";
    [Benchmark]
    public bool IgualdadeComLowerCase()
    {
        return nome1.ToLower() == nome2.ToLower();
    }
    [Benchmark]
    public bool IgualdadeComUpperCase()
    {
        return nome1.ToUpper() == nome2.ToUpper();
    }
    [Benchmark]
    public bool CompareComIgnoreCase()
    {
        return string.Compare(nome1, nome2, StringComparison.OrdinalIgnoreCase) == 0;
    }
    [Benchmark]
    public bool EqualsIgnoreCase()
    {
        return nome1.Equals(nome2, StringComparison.OrdinalIgnoreCase);
    }
}
