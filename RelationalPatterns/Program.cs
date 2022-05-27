using BenchmarkDotNet.Running;
using RelationalPatterns;

void Conditional(int x)
{
    Console.WriteLine($"Value: {x}");

    if (x is > 10 and < 30)
        Console.WriteLine("Matches");
    else
        Console.WriteLine("Doesn't match");

    Console.WriteLine();
}

Conditional(5);
Conditional(20);
Conditional(50);

//var summaries = new BookReviewSummary[]
//{
//    new ("Dr No", 1.22),
//    new ("Goldfinger", 4.32),
//    new ("Emma", 4.76),
//    new ("Persuasion", 3.58)
//};

//foreach (var summary in summaries)
//    Console.WriteLine(summary);

//BenchmarkRunner.Run<Benchmarks>();