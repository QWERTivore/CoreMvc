namespace GetTheRepsWeb.Domain.Aggregates.Entities
{
    public class Rating
    {
        public int Stars { get; set; }

        public Rating(int stars)
        {
            this.Stars = stars;
        }
    }
}
