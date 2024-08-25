using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;

            List<Activity> activities = new List<Activity>
            {
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Morning Yoga",
                    Date = DateTime.Now.AddDays(1),
                    Description = "A relaxing morning yoga session.",
                    Category = "Health & Wellness",
                    City = "New York",
                    Venue = "Central Park"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Art Exhibition",
                    Date = DateTime.Now.AddDays(5),
                    Description = "Explore modern art by local artists.",
                    Category = "Arts & Culture",
                    City = "San Francisco",
                    Venue = "Museum of Modern Art"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Tech Conference",
                    Date = DateTime.Now.AddDays(10),
                    Description = "Annual conference on the latest in technology.",
                    Category = "Technology",
                    City = "Las Vegas",
                    Venue = "Convention Center"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Music Festival",
                    Date = DateTime.Now.AddDays(15),
                    Description = "A weekend of live music performances.",
                    Category = "Music",
                    City = "Austin",
                    Venue = "Zilker Park"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Cooking Workshop",
                    Date = DateTime.Now.AddDays(7),
                    Description = "Learn to cook Italian cuisine.",
                    Category = "Food & Drink",
                    City = "Chicago",
                    Venue = "Culinary Institute"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Charity Run",
                    Date = DateTime.Now.AddDays(20),
                    Description = "5K run for a good cause.",
                    Category = "Sports & Fitness",
                    City = "Boston",
                    Venue = "Charles River Esplanade"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Book Club Meeting",
                    Date = DateTime.Now.AddDays(12),
                    Description = "Discuss the latest book of the month.",
                    Category = "Literature",
                    City = "Seattle",
                    Venue = "Public Library"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Photography Walk",
                    Date = DateTime.Now.AddDays(18),
                    Description = "Capture the beauty of the city with fellow photographers.",
                    Category = "Arts & Culture",
                    City = "Portland",
                    Venue = "Downtown Portland"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Startup Pitch Night",
                    Date = DateTime.Now.AddDays(3),
                    Description = "Watch startups pitch their ideas to investors.",
                    Category = "Business",
                    City = "Los Angeles",
                    Venue = "Tech Hub LA"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Wine Tasting",
                    Date = DateTime.Now.AddDays(8),
                    Description = "Sample wines from local vineyards.",
                    Category = "Food & Drink",
                    City = "Napa Valley",
                    Venue = "Vineyard Estate"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Film Screening",
                    Date = DateTime.Now.AddDays(6),
                    Description = "Exclusive screening of an independent film.",
                    Category = "Film",
                    City = "Denver",
                    Venue = "Art House Cinema"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Dance Workshop",
                    Date = DateTime.Now.AddDays(4),
                    Description = "Learn salsa with a professional instructor.",
                    Category = "Dance",
                    City = "Miami",
                    Venue = "Dance Studio"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Comedy Night",
                    Date = DateTime.Now.AddDays(9),
                    Description = "An evening of stand-up comedy.",
                    Category = "Entertainment",
                    City = "Atlanta",
                    Venue = "Comedy Club"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Gardening Workshop",
                    Date = DateTime.Now.AddDays(11),
                    Description = "Learn the basics of urban gardening.",
                    Category = "Lifestyle",
                    City = "San Diego",
                    Venue = "Community Garden"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Historic Tour",
                    Date = DateTime.Now.AddDays(14),
                    Description = "Guided tour of historic sites in the city.",
                    Category = "History",
                    City = "Washington D.C.",
                    Venue = "National Mall"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Jazz Concert",
                    Date = DateTime.Now.AddDays(13),
                    Description = "Live jazz music performance.",
                    Category = "Music",
                    City = "New Orleans",
                    Venue = "Jazz Club"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Yoga Retreat",
                    Date = DateTime.Now.AddDays(21),
                    Description = "A weekend of relaxation and yoga in nature.",
                    Category = "Health & Wellness",
                    City = "Sedona",
                    Venue = "Retreat Center"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Fashion Show",
                    Date = DateTime.Now.AddDays(16),
                    Description = "Showcase of the latest fashion trends.",
                    Category = "Fashion",
                    City = "New York",
                    Venue = "Fashion District"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Startup Networking Event",
                    Date = DateTime.Now.AddDays(17),
                    Description = "Meet and connect with other startup founders.",
                    Category = "Business",
                    City = "San Francisco",
                    Venue = "Coworking Space"
                },
                new Activity
                {
                    Id = Guid.NewGuid(),
                    Title = "Coding Bootcamp",
                    Date = DateTime.Now.AddDays(19),
                    Description = "Intensive coding bootcamp for beginners.",
                    Category = "Technology",
                    City = "Austin",
                    Venue = "Tech Academy"
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}