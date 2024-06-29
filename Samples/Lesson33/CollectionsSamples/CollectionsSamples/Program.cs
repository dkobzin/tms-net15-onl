using System.Collections;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace CollectionsSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Simple IEnumerator
            var s = "Hello, World!";
            IEnumerator simpleEnumerator = s.GetEnumerator();
            while (simpleEnumerator.MoveNext())
            {
                var c = (char) simpleEnumerator.Current;
                Console.Write(c + ".");
            }
            Console.WriteLine();

            // Generic enumerable
            IEnumerable<int> numbers = new[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
            };
            IEnumerator genericEnumerator = numbers.GetEnumerator();
            while (genericEnumerator.MoveNext())
            {
                Console.Write(genericEnumerator.Current + ",");
            }

            Console.WriteLine();

            // Yield
            foreach (int i in ProduceEvenNumbers(9))
            {
                Console.WriteLine(i + ",");
            }
            Console.WriteLine();

            foreach (int i in GetSomeIntegers())
                Console.WriteLine(i);

            Console.WriteLine();

            // Get element by index
            var arrayNumbers = numbers.ToArray();
            for (int i = 0; i < arrayNumbers.Count(); i++)
            {
                Console.Write(arrayNumbers[i] + ",");
            }

            Console.WriteLine();

            // ICollection 
            ICollection<int> collections = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,
            };
            Console.WriteLine(collections.Count);
            collections.Add(20);
            Console.WriteLine(collections.Contains(20));
            collections.Remove(20);
            Console.WriteLine(collections.Contains(20));
            collections.Clear();
            Console.WriteLine(collections.Contains(1));
            Console.WriteLine();
            
            // IList
            IList<string> months = new List<string>();
            months = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            foreach (var month in months)
            {
                Console.WriteLine(month);
                // months.Remove(month); Error 'cause months has fixed size
            }
            Console.WriteLine(months.Count);
            Console.WriteLine(months.IsReadOnly);
            Console.WriteLine(months.FirstOrDefault("April"));
            //Console.WriteLine(months.SingleOrDefault("May"));

            Console.WriteLine();

            // Array
            var amounts = new int[]
            {
                100, 301, 205, 406
            };
            foreach (var amount in amounts)
            {
                Console.WriteLine(amount);
            }
            Console.WriteLine(amounts.IsReadOnly);
            Console.WriteLine(amounts.IsFixedSize);
            Console.WriteLine(amounts.Length);
            Console.WriteLine(Array.BinarySearch(amounts, 406));
            Console.WriteLine(Array.Find(amounts, amount => amount > 400));
            
            Console.WriteLine();

            // List
            var words = new List<string>();    // New string-typed list
            
            words.Add("melon");
            words.Add("avocado");
            words.AddRange(["banana", "plum"]);
            words.Insert(0, "lemon");                   // Insert at start
            words.InsertRange(0, ["peach", "nashi"]);   // Insert at start
            words.Remove("melon");
            words.RemoveAt(3);                         // Remove the 4th element
            words.RemoveRange(0, 2);                   // Remove first 2 elements
            
            // Remove all strings starting in 'n':
            words.RemoveAll(s => s.StartsWith("n"));
            Console.WriteLine(words[0]);                          // first word
            Console.WriteLine(words[words.Count - 1]);            // last word
            
            foreach (string s1 in words) 
                Console.WriteLine(s1);      // all words
            List<string> subset = words.GetRange(1, 2);            // 2nd->3rd words
            string[] wordsArray = words.ToArray();    // Creates a new typed array
            // Copy first two elements to the end of an existing array:
            string[] existing = new string[1000];
            words.CopyTo(0, existing, 998, 2);
            List<string> upperCaseWords = words.ConvertAll(s => s.ToUpper());
            List<int> lengths = words.ConvertAll(s => s.Length);

            Console.WriteLine();

            // Queue
            var q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            int[] data = q.ToArray();         // Exports to an array
            Console.WriteLine(q.Count);      // "2"
            Console.WriteLine(q.Peek());     // "10"
            Console.WriteLine(q.Dequeue());  // "10"
            Console.WriteLine(q.Dequeue());  // "20"
            // Console.WriteLine(q.Dequeue());  // throws an exception (queue empty)

            Console.WriteLine();

            // Stack
            var stack = new Stack<int>();
            stack.Push(1);                      //            Stack = 1
            stack.Push(2);                      //            Stack = 1,2
            stack.Push(3);                      //            Stack = 1,2,3
            Console.WriteLine(stack.Count);     // Prints 3
            Console.WriteLine(stack.Peek());    // Prints 3,  Stack = 1,2,3
            Console.WriteLine(stack.Pop());     // Prints 3,  Stack = 1,2
            Console.WriteLine(stack.Pop());     // Prints 2,  Stack = 1
            Console.WriteLine(stack.Pop());     // Prints 1,  Stack = <empty>
            // Console.WriteLine(s.Pop());     // throws exception

            Console.WriteLine();

            // HashSet & SortedSet
            
            var letters = new HashSet<char>("the quick brown fox");
            Console.WriteLine(letters.Contains('t'));      // true
            Console.WriteLine(letters.Contains('j'));      // false
            foreach (char c in letters) Console.Write(c);
            
            letters.Add('t');
            
            Console.WriteLine();
            
            // Dictionary
            var dictionary = new Dictionary<int, bool>
            {
                { 1, true },
                { 2, false }
            };

            var d = new Dictionary<string, int>();
            d.Add("One", 1);
            d["Two"] = 2;     // adds to dictionary because "two" isn't already present
            d["Two"] = 22;    // updates dictionary because "two" is now present
            d["Three"] = 3;
            Console.WriteLine(d["Two"]);                // Prints "22"
            Console.WriteLine(d.ContainsKey("One"));   // true (fast operation)
            Console.WriteLine(d.ContainsValue(3));     // true (slow operation)
            int val = 0;
            if (!d.TryGetValue("onE", out val))
                Console.WriteLine("No val");              // "No val" (case sensitive)
            // Three different ways to enumerate the dictionary:
            foreach (KeyValuePair<string, int> kv in d)          //  One; 1
                Console.WriteLine(kv.Key + "; " + kv.Value);      //  Two; 22
            //  Three; 3
            foreach (string s3 in d.Keys) Console.Write(s3);      // OneTwoThree
            Console.WriteLine();
            foreach (int i in d.Values) Console.Write(i);       // 1223


            // Immutable Collections
            
            var oldList = ImmutableList.Create<int>(1, 2, 3);
            ImmutableList<int> newList = oldList.Add(4);
            Console.WriteLine(oldList.Count);     // 3  (unaltered)
            Console.WriteLine(newList.Count);     // 4

            ImmutableArray<int>.Builder builder = ImmutableArray.CreateBuilder<int>();
            builder.Add(1);
            builder.Add(2);
            builder.Add(3);
            
            builder.RemoveAt(0);
            ImmutableArray<int> myImmutable = builder.ToImmutable();

            var builder2 = myImmutable.ToBuilder();
            builder2.Add(4);      // Efficient
            builder2.Remove(2);   // Efficient
            
            // Return a new immutable collection with all the changes applied:
            ImmutableArray<int> myImmutable2 = builder2.ToImmutable();

            // Comparer

            Customer c1 = new Customer("Bloggs", "Joe");
            Customer c2 = new Customer("Bloggs", "Joe");

            Console.WriteLine(c1 == c2);               // False
            Console.WriteLine(c1.Equals(c2));         // False

            var eqComparer = new LastFirstEqComparer();
            var d1 = new Dictionary<Customer, string>(eqComparer);
            d1[c1] = "Joe";
            Console.WriteLine(d1.ContainsKey(c2));         // True

            var s11 = "Hello, world!";
            var s12 = "Hello, world!";
            Console.WriteLine(s11 == s12);
            Console.ReadLine();


        }

        private static IEnumerable<int> ProduceEvenNumbers(int upto)
        {
            for (int i = 0; i <= upto; i += 2)
            {
                yield return i;
            }
        }

        public static IEnumerable<int> GetSomeIntegers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
        public class Customer
        {
            public string LastName;
            public string FirstName;
            public Customer(string last, string first)
            {
                LastName = last;
                FirstName = first;
            }
        }

        public class LastFirstEqComparer : EqualityComparer<Customer>
        {
            public override bool Equals(Customer x, Customer y)
                => x.LastName == y.LastName && x.FirstName == y.FirstName;
            public override int GetHashCode(Customer obj)
                => (obj.LastName + ";" + obj.FirstName).GetHashCode();
        }


    }
}
