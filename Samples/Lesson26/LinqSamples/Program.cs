using Microsoft.EntityFrameworkCore;

namespace LinqSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString =
                @"Server=localhost;Database=sample26;User Id=sa_sample26;Password=SuperPassword123;Trust Server Certificate=True;";
            DbContextOptionsBuilder<ApplicationDbContext> contextOptionsBuilder = new();
            contextOptionsBuilder
                .UseSqlServer((string?)connectionString, options => options.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null));

            using var databaseContext = new ApplicationDbContext(contextOptionsBuilder.Options);

            // method extension with Select
            
            var pinguins = databaseContext.Pinguins.Where(pinguin => pinguin.Sex.Equals("MALE"))
                //.Select(p => new { p.Id, p.Sex, p.Island})
                //.ToList()
                ;

            // operator Linq
            /*var penquins = (from p in databaseContext.Pinguins where p.Sex.Equals("MALE") 
                select new { p.Id, p.Sex} ).ToList();*/

            // Find
            // var pinquin = databaseContext.Pinguins.Find(3);

            //  First()/FirstOrDefault()

            //var pinquin = databaseContext.Pinguins.FirstOrDefault( p => p.Id == 2);
            var pinquin = databaseContext.Pinguins.SingleOrDefault( p => p.Id == 2);

            // Order by

            //pinguins = pinguins.OrderBy(p => p.Sex).ToList();

            //pinguins = pinguins.OrderByDescending(p => p.Id).ToList();

            var males = pinguins.Count(p => p.Sex!.Contains("MALE"));
            var malesIsExusted = pinguins.Any(p => p.Sex!.Contains("MALE"));
            var sumWeightForMale = pinguins
                .Where(p => p.Sex.Contains("MALE"))
                .Sum(p => p.BodyMassG);

            var littlePinguins = databaseContext.LittlePinguins.Join(databaseContext.Pinguins, lp => lp.ParentId,
                p => p.Id,
                (lp, p) => new { lp, p });

            var list = pinguins.Where(p => p.Id < 10).AsEnumerable().ToList();
            var query = pinguins.AsQueryable();

            var take = 10;
            var skip = 0;
            var count = pinguins.Count();
            for (int i = 0; i < count; i+=take)
            {
                var chunk = pinguins.Skip(skip).Take(take).ToList();
                Console.WriteLine("$Skip:{skip}, take: {take}");
                foreach (var c in chunk)
                {
                    Console.WriteLine($"Id={c.Id}, {c.Species}, {c.Island}");
                }

                skip += take;
            }

            var simpleQuery = databaseContext.Database.ExecuteSql($"SELECT * FROM penguins");
            Console.ReadLine();
        }
    }
}
