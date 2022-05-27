using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationalPatterns
{
    public class Benchmarks
    {
        [Params(4.5, 3.5, 2.5, 1.5)]
        public double Rating { get; set; }

        [Benchmark]
        public Ratings IfElse()
        {
            var review = new BookReviewSummary("Book", Rating);

            return review.RatingByIfElse;
        }

        [Benchmark(Baseline = true)]
        public Ratings Pattern()
        {
            var review = new BookReviewSummary("Book", Rating);

            return review.RatingsByPattern;
        }
    }
}
