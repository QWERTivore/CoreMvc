namespace GetTheRepsWeb.Domain.ValueObjects
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
