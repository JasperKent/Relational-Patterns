namespace RelationalPatterns
{
    public class BookReviewSummary
    {
        public BookReviewSummary(string title, double rating)
        {
            Title = title;
            Rating = rating;
        }

        public string Title { get; }

        public double Rating { get; }

        public string Description => Rating.ToString();

        public Ratings RatingsByPattern =>
            Rating switch
            {
                <= 5 and > 4 => Ratings.Superb,
                <= 5 and > 3 => Ratings.Excellent,
                <= 5 and > 2 => Ratings.Good,
                <= 5 and > 1 => Ratings.Poor,
                1 => Ratings.Rubbish,
                _ => throw new ArgumentOutOfRangeException("Rating out of range")
            };

        public Ratings RatingByIfElse
        {
            get
            {
                if (Rating > 5)
                    throw new ArgumentOutOfRangeException("Rating out of range");
                else if (Rating > 4)
                    return Ratings.Superb;
                else if (Rating > 3)
                    return Ratings.Excellent;
                else if (Rating > 2)
                    return Ratings.Good;
                else if (Rating > 1)
                    return Ratings.Poor;
                else if (Rating == 1)
                    return Ratings.Rubbish;
                else
                    throw new ArgumentOutOfRangeException("Rating out of range");
            }
        }

        public override string ToString() => $"{Title} - {RatingsByPattern}";
    }
}
