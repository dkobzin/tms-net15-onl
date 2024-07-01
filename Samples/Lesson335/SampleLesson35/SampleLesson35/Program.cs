using System;
using System.Net;
using static System.Net.WebRequestMethods;

namespace SampleLesson35
{
    internal class Program
    {
        private static object locker = new();

        static void Main(string[] args)
        {
            // Example properties Threads
            var currentThread = Thread.CurrentThread;
            
            Console.WriteLine($"Name thread: {currentThread.Name}");
            currentThread.Name = "Method Main";
            Console.WriteLine($"Name thread: {currentThread.Name}");

            Console.WriteLine($"Thread is alive: {currentThread.IsAlive}");
            Console.WriteLine($"Id thread: {currentThread.ManagedThreadId}");
            Console.WriteLine($"Thread priority: {currentThread.Priority}");
            Console.WriteLine($"Thread Status: {currentThread.ThreadState}");
            Console.WriteLine($"Application domain: {Thread.GetDomain()}");
            Console.WriteLine($"Application domain ID: {Thread.GetDomainID()}");

            // Thread.Sleep(3000);

            // Example for creating thread by ctor and run
            /*var thread1 = new Thread(Print);
            var thread2 = new Thread(new ThreadStart(Print));
            var thread3 = new Thread(() => Console.WriteLine("Hello thread!"));

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();*/

            // Examples for collection threads
            /*var threads = new List<Thread>();
            
            for (int i = 0; i < 5; i++)
            {
                var thread = new Thread(new ThreadStart(Print));
                threads.Add(thread);
            }

            foreach (var thread in threads)
            {
                thread.Start();
                Thread.Sleep(400);
            }*/

            // Examples ParameterizedThreadStart
            /*var paramsThread = new Thread(new ParameterizedThreadStart(Print2)); 
            paramsThread.Start("salt");*/

            // Examples sync threads with issues
            /*for (int i = 0; i < 5; i++)
            {
                var thread = new Thread(Print3)
                {
                    Name = $"Thread {i}"
                };
                thread.Start();
            }
            */

            // Examples sync threads with lock
            /*for (int i = 0; i < 5; i++)
            {
                var thread = new Thread(Print4)
                {
                    Name = $"Thread {i}"
                };
                thread.Start();
            }*/

            // Examples sync tasks with lock
            /*
            for (int i = 0; i < 5; i++)
            {
                var task = new Task(() => Print5(i));
                task.Start();
            }
            */

            // Example with TaskAll & When
            /*var task1 = Task.Factory.StartNew(() =>
            {
                Task.Delay(3000);
                Console.WriteLine("task1");
            });
            var task2 = Task.Factory.StartNew(() =>
            {
                Task.Delay(1000);
                Console.WriteLine("task2");
            });*/

            /*var cts = new CancellationTokenSource();
            Task.WhenAny(task1, task2).ContinueWith((t1) =>
            {
                Console.WriteLine($"{nameof(task1)} {task1.Id}: {task1.IsCompleted}");
                Console.WriteLine($"{nameof(task2)} {task2.Id}: {task2.IsCompleted}");
            }, cts.Token);*/

            // or
            /*Task.WhenAll(task1, task2).ContinueWith((t1) =>
            {
                Console.WriteLine($"{nameof(task1)} {task1.Id}: {task1.IsCompleted}");
                Console.WriteLine($"{nameof(task2)} {task2.Id}: {task2.IsCompleted}");
            });*/

            // Calculate prime numbers using a simple (unoptimized) algorithm.
            /*IEnumerable<int> numbers = Enumerable.Range (3, 100000-3);
            var parallelQuery = from n in numbers.AsParallel()
               where Enumerable.Range (2, (int) Math.Sqrt (n)).All (i => n % i > 0)
               select n;
            int[] primes = parallelQuery.ToArray();
            foreach (var prime in primes)
            {
                Console.WriteLine($"{prime}");
            }*/

            // PLINQ with select
            /*var cts = new CancellationTokenSource();
            var loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed mattis vitae ex in fringilla. Nunc malesuada sapien eget lobortis facilisis. Mauris tempor nunc viverra laoreet faucibus. Aenean at lectus vel ex pharetra gravida. Fusce augue ex, eleifend ac imperdiet eget, accumsan convallis leo. Quisque eleifend lorem et sapien consequat, sed convallis dui facilisis. Pellentesque ultrices sapien a volutpat aliquam. Suspendisse potenti. Sed aliquam tellus in tempor cursus. Etiam id nunc sed eros venenatis tempus. Praesent aliquam tincidunt viverra.";
            var loremIpsums = loremIpsum.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var wordLookup = new HashSet<string>(loremIpsims);
            
            var random = new Random();
            string[] wordList = wordLookup.ToArray();
            string[] wordsToTest = Enumerable.Range(0, 1000000)
                .Select(i => wordList[random.Next(0, wordList.Length)])
                .ToArray();
            wordsToTest[12345] = "woozsh";     // Introduce a couple
            wordsToTest[23456] = "wubsie";

            var query = wordsToTest
                .AsParallel()
                .WithDegreeOfParallelism(Environment.ProcessorCount -1)
                .WithCancellation(cts.Token)
                .Select((word, index) => (word, index))
                .Where(iword => !wordLookup.Contains(iword.word))
                .OrderBy(iword => iword.index);

            foreach (var mistake in query)
                Console.WriteLine(mistake.word + " - index = " + mistake.index);*/

            // Example Parallel
            /*Parallel.Invoke(
                () => new WebClient().DownloadFile("http://www.linqpad.net", "lp.html"),
                () => new WebClient().DownloadFile("http://microsoft.com", "ms.html"));*/

            // Parallel For / ForEach

            /*var loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed mattis vitae ex in fringilla. Nunc malesuada sapien eget lobortis facilisis. Mauris tempor nunc viverra laoreet faucibus. Aenean at lectus vel ex pharetra gravida. Fusce augue ex, eleifend ac imperdiet eget, accumsan convallis leo. Quisque eleifend lorem et sapien consequat, sed convallis dui facilisis. Pellentesque ultrices sapien a volutpat aliquam. Suspendisse potenti. Sed aliquam tellus in tempor cursus. Etiam id nunc sed eros venenatis tempus. Praesent aliquam tincidunt viverra.";
            var loremIpsums = loremIpsum.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            Parallel.For(0, loremIpsums.Length, index => Console.WriteLine($"{index}:{loremIpsums[index]}"));
            Parallel.ForEach(loremIpsums, (s) =>
            {
                var index = Array.IndexOf(loremIpsums, s);
                Console.WriteLine($"{index}:{s}");
            });*/

            // Parallel with locker
            /*double grandTotal = 0;
            Parallel.For(1, 10000000,
                () => 0.0,                        // Initialize the local value.
                (i, state, localTotal) =>         // Body delegate. Notice that it
                localTotal + Math.Sqrt(i),    // returns the new local total.
                localTotal => // Add the local value
                {
                    lock (locker)
                    {
                        grandTotal += localTotal;
                        Thread.Sleep(1000);
                    }
                }   // to the master value.
                );
            Console.WriteLine(grandTotal);*/

            // Task Parallelism
            /*try
            {
                TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                var parent = Task.Factory.StartNew(() =>
                {
                    Task.Factory.StartNew(() =>   // Child
                    {
                        //Task.Factory.StartNew(() => { throw null; }, atp);   // Grandchild
                        Task.Factory.StartNew(() => { Console.WriteLine($"{Thread.CurrentThread.Name}"); }, atp);   // Grandchild
                    }, atp);
                });
                // The following call throws a NullReferenceException (wrapped
                // in nested AggregateExceptions):
                parent.Wait();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.GetType()}, {e.HResult}, {e.Message}" );
                throw;
            }*/

            // Cancelation tasks
            /*var cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            cts.CancelAfter(500);
            Task task = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                token.ThrowIfCancellationRequested();  // Check for cancellation request
            }, token);
            try
            {
                task.Wait();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.InnerException is TaskCanceledException); // True
                Console.WriteLine(task.IsCanceled); // True
                Console.WriteLine(task.Status);
            }*/

            // Example with ThreadLocal
            //var localRandom = new ThreadLocal<Random>(() => new Random());
            var local = new ThreadLocal<int>(() => 5);
            for (int i = 0; i < 5; i++)
            {
                var task = Task.Factory.StartNew(() =>
                {
                    //Console.WriteLine(localRandom.Value.Next());
                    Console.WriteLine(local.Value);
                });
                task.Wait();
            }

            Console.ReadLine();
        }

        static void Print() => Console.WriteLine("Hello thread!");
        
        static void Print2(object salt) => Console.WriteLine($"Hello thread {salt}!");

        static void Print3()
        {
            var x = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}:{x}");
                x++;
                Thread.Sleep(100);
            }
        }
        
        static void Print4()
        {
            lock (locker)
            {
                var x = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread}:{x}");
                    x++;
                    Thread.Sleep(100);
                }
            }
        }
        static void Print5(int index)
        {
            lock (locker)
            {
                var x = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($" task {index}:{x}");
                    x++;
                    Thread.Sleep(100);
                }
            }

            return;
        }
    }
}
