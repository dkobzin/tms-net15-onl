using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Sample31
{
    internal class Program
    {
        public delegate int DisplayHandler(int k);



        static async Task Main(string[] args)
        {
            // Thread
            /*Console.WriteLine(Thread.GetCurrentProcessorId());
            Console.WriteLine(Thread.GetDomain().Id);

            var backgroundThread = new Thread(() =>
            {
                Console.WriteLine("background thread!");
                Thread.Sleep(3000);
            });
            backgroundThread.Start();

            Console.WriteLine(backgroundThread.Name);
            Console.WriteLine(backgroundThread.ThreadState);

            backgroundThread.Join();*/

            var t = new Thread(WriteX);
            t.Start();
            WriteY();
            t.Join();

            ThreadPool.QueueUserWorkItem(Go, "s");
            ThreadPool.QueueUserWorkItem(Go, "c");


            // IAsyncResult is not supported for .Net Core, only for .Net 4.8
            /*var displayHandler = new DisplayHandler(Display);

            IAsyncResult resultObj = displayHandler.BeginInvoke(10, new AsyncCallback(AsyncCompleted), "Асинхронные вызовы");

            Console.WriteLine("Продолжается работа метода Main");

            int res = displayHandler.EndInvoke(resultObj);*/

            // Async /await
            // Incorrect
            //var task = new Task( async () => await DisplayAsync());

            var ctx = new CancellationTokenSource();
            var result = async () => await ReturnAsync(4, ctx);
            ctx.Cancel();

            Console.WriteLine(result.Invoke().Result);

            // TPL
            var resultBag = new ConcurrentBag<IEnumerable<int>>();

            var options = new ParallelOptions()
            {
                CancellationToken = new CancellationToken(),
                MaxDegreeOfParallelism = Environment.ProcessorCount - 1,
                TaskScheduler = TaskScheduler.Current
            };
            await Parallel.ForEachAsync(Enumerable.Range(0, 5), options, async (index, _) =>
            {
                var result = await AsyncMethod();
                resultBag.Add(result);
            });
            foreach (var b in resultBag)
            {
                foreach (var index in b)    
                {
                    Console.WriteLine(index);
                }
            }
            Console.ReadLine();
        }

        static void WriteX()
        {
            for (int cycles = 0; cycles < 5; cycles++) Console.Write("x");
            Thread.Sleep(3000);
        }

        static void WriteY()
        {
            Thread.Sleep(3000);
            for (int cycles = 0; cycles < 5; cycles++) Console.Write("y");
        }

        static void Go(object s)
        {
            Thread.Sleep(3000);
            for (int cycles = 0; cycles < 5; cycles++) Console.Write(s);
        }

        private static int Display(int k)
        {
            Console.WriteLine("Начинается работа метода Display....");

            int result = 0;
            for (int i = 1; i < 10; i++)
            {
                result += k * i;
            }

            Thread.Sleep(3000);
            Console.WriteLine("Завершается работа метода Display....");
            return result;
        }

        static void AsyncCompleted(IAsyncResult resObj)
        {
            string mes = (string)resObj.AsyncState;
            Console.WriteLine(mes);
            Console.WriteLine("Работа асинхронного делегата завершена");
        }

        /*static async void DisplayAsync()
        {
            await Console.WriteLine("async await");
        }*/

        static async Task<int> ReturnAsync(int k, CancellationTokenSource cancellationTokenSource)
        {
            if (cancellationTokenSource.IsCancellationRequested)
                return default;
            await Task.Delay(3000);
            return k;
        }

        private static async Task<IEnumerable<int>> AsyncMethod()
        {
            Console.WriteLine($"AsyncMethod started on thread: {Environment.CurrentManagedThreadId}");

            await Task.Delay(250);

            Console.WriteLine($"AsyncMethod completed on thread: {Environment.CurrentManagedThreadId}");

            return Enumerable.Range(0, 5).Select(index => index ).ToArray();
        }
    }
}
