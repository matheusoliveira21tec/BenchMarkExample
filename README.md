# BenchMarkExample

Projeto de estudo, aprendendo a utilizar a biblioteca BenchMark para monitorar perfomance. Nesse exemplo testei 4 formas de comparar strings, está aqui o resultado:
| Method                | Mean      | Error     | StdDev    |
|---------------------- |----------:|----------:|----------:|
| IgualdadeComLowerCase | 49.634 ns | 0.9808 ns | 1.2045 ns |
| IgualdadeComUpperCase | 46.476 ns | 0.9093 ns | 0.9338 ns |
| CompareComIgnoreCase  | 13.621 ns | 0.3018 ns | 0.3229 ns |
| EqualsIgnoreCase      |  7.739 ns | 0.1533 ns | 0.1704 ns |


Aparentemente o metódo Equals() é o mais eficiente.
