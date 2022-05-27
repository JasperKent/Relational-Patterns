using RelationalPatterns;
using System;
using Xunit;

namespace SummaryTests
{
    public class BookReviewSummaryTests
    {
        [Fact]
        public void SuperbLowReview()
        {
            var summary = new BookReviewSummary("Book", 4.001);

            Assert.Equal("Book - Superb", summary.ToString());
        }

        [Fact]
        public void ExcellentHighReview()
        {
            var summary = new BookReviewSummary("Book", 4.0);

            Assert.Equal("Book - Excellent", summary.ToString());
        }

        [Fact]
        public void ExcellentLowReview()
        {
            var summary = new BookReviewSummary("Book", 3.001);

            Assert.Equal("Book - Excellent", summary.ToString());
        }

        [Fact]
        public void GoodHighReview()
        {
            var summary = new BookReviewSummary("Book", 3.0);

            Assert.Equal("Book - Good", summary.ToString());
        }

        [Fact]
        public void GoodLowReview()
        {
            var summary = new BookReviewSummary("Book", 2.001);

            Assert.Equal("Book - Good", summary.ToString());
        }

        [Fact]
        public void PoorHighReview()
        {
            var summary = new BookReviewSummary("Book", 2.0);

            Assert.Equal("Book - Poor", summary.ToString());
        }

        [Fact]
        public void PoorLowReview()
        {
            var summary = new BookReviewSummary("Book", 1.001);

            Assert.Equal("Book - Poor", summary.ToString());
        }

        [Fact]
        public void RubbishHighReview()
        {
            var summary = new BookReviewSummary("Book", 1.0);

            Assert.Equal("Book - Rubbish", summary.ToString());
        }

        [Fact]
        public void TooHighReview()
        {
            var summary = new BookReviewSummary("Book", 5.5);

            Assert.Throws<ArgumentOutOfRangeException>(() => summary.ToString());
        }

        [Fact]
        public void TooLowReview()
        {
            var summary = new BookReviewSummary("Book", 0.5);

            Assert.Throws<ArgumentOutOfRangeException>(() => summary.ToString());
        }
    }
}