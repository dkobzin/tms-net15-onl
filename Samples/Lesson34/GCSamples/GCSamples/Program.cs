using System.Text;

namespace GCSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var addresess = new List<string>
            {
                "Address 1",
                "Address 2",
                "Address 3",
                "Address 4",
                "Address 5",
                "Address 6",
                "Address 7",
            };
            using (var bob = new User("Bob", addresess))
            {
                bob.DoSomethingWork();
                bob.DoUnsafeWork();
            }

            GC.Collect(0, GCCollectionMode.Default);
            GCHelper.DisplayTotalMemory();

            var users = Enumerable.Range(0, 10000).Select(index => new User($"user_{index}", addresess)).ToList();
            GCHelper.DisplayTotalMemory();

            // Uncomment to learn about unsafe 
            /*foreach (var user in users)
            {
                user.DoSomethingWork();
                user.DoUnsafeWork();
                user.Dispose();
            }*/

            GCHelper.DisplayTotalMemory();
            GC.Collect();
            GCHelper.DisplayTotalMemory();
            
            // LOH
            var sb = new StringBuilder(86000);
            foreach (var user in users)
            {
                sb.AppendFormat($"User {user.Name}");
                foreach (var address in user.Addresses)
                {
                    sb.AppendFormat($" with {address}");
                }
            }

            GCHelper.DisplayTotalMemory();

            var displayUsers = sb.ToString();

            GCHelper.DisplayTotalMemory();

            Console.ReadLine();

            GC.Collect();
            GCHelper.DisplayTotalMemory();
        }
    }
}
