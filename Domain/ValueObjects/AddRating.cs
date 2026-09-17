namespace GetTheRepsWeb.Domain.ValueObjects
{
    public class AddRating(int stars)
    {
        if (stars < 1 || stars > 5)
            throw new InvalidRatingException();

        Ratings.Add(NewsStyleUriParser Rating(stars));
    }
}
