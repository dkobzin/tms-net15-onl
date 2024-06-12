using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;

namespace WinFormsAppEAP
{
    public partial class Form1 : Form
    {
        private HybridDictionary userStateToLifetime = new HybridDictionary();

        private delegate void WorkerEventHandler(int numberToCheck, AsyncOperation asyncOp);
        private SendOrPostCallback onProgressReportDelegate;
        private SendOrPostCallback onCompletedDelegate;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int testNumber = rand.Next(200000);
            var taskId = Guid.NewGuid();
            listBox.Items.Add(new { taskId, testNumber });
            CalculatePrimeAsync(testNumber, taskId);
        }

        public virtual void CalculatePrimeAsync(
            int numberToTest,
            object taskId)
        {
            // Create an AsyncOperation for taskId.
            AsyncOperation asyncOp =
                AsyncOperationManager.CreateOperation(taskId);

            // Multiple threads will access the task dictionary,
            // so it must be locked to serialize access.
            lock (userStateToLifetime.SyncRoot)
            {
                if (userStateToLifetime.Contains(taskId))
                {
                    throw new ArgumentException(
                        "Task ID parameter must be unique",
                        "taskId");
                }

                userStateToLifetime[taskId] = asyncOp;
            }

            // Start the asynchronous operation.
            WorkerEventHandler workerDelegate = new WorkerEventHandler(CalculateWorker);
            workerDelegate.BeginInvoke(
                numberToTest,
                asyncOp,
                null,
                null);
        }

        private void CalculateWorker(
            int numberToTest,
            AsyncOperation asyncOp)
        {
            bool isPrime = false;
            int firstDivisor = 1;
            Exception e = null;

            // Check that the task is still active.
            // The operation may have been canceled before
            // the thread was scheduled.
            if (!TaskCanceled(asyncOp.UserSuppliedState))
            {
                try
                {
                    // Find all the prime numbers up to
                    // the square root of numberToTest.
                    ArrayList primes = BuildPrimeNumberList(
                        numberToTest,
                        asyncOp);

                    // Now we have a list of primes less than
                    // numberToTest.
                    isPrime = IsPrime(
                        primes,
                        numberToTest,
                        out firstDivisor);
                }
                catch (Exception ex)
                {
                    e = ex;
                }
            }
        }

        private bool TaskCanceled(object taskId)
        {
            return (userStateToLifetime[taskId] == null);
        }

        private ArrayList BuildPrimeNumberList(
            int numberToTest,
            AsyncOperation asyncOp)
        {
            ProgressChangedEventArgs e = null;
            ArrayList primes = new ArrayList();
            int firstDivisor;
            int n = 5;

            // Add the first prime numbers.
            primes.Add(2);
            primes.Add(3);

            // Do the work.
            while (n < numberToTest &&
                   !TaskCanceled(asyncOp.UserSuppliedState))
            {
                if (IsPrime(primes, n, out firstDivisor))
                {
                    // Report to the client that a prime was found.
                    e = new CalculatePrimeProgressChangedEventArgs(
                        n,
                        (int)((float)n / (float)numberToTest * 100),
                        asyncOp.UserSuppliedState);

                    asyncOp.Post(this.onProgressReportDelegate, e);

                    primes.Add(n);

                    // Yield the rest of this time slice.
                    Thread.Sleep(0);
                }

                // Skip even numbers.
                n += 2;
            }

            return primes;
        }

        private bool IsPrime(
            ArrayList primes,
            int n,
            out int firstDivisor)
        {
            bool foundDivisor = false;
            bool exceedsSquareRoot = false;

            int i = 0;
            int divisor = 0;
            firstDivisor = 1;

            // Stop the search if:
            // there are no more primes in the list,
            // there is a divisor of n in the list, or
            // there is a prime that is larger than
            // the square root of n.
            while (
                (i < primes.Count) &&
                !foundDivisor &&
                !exceedsSquareRoot)
            {
                // The divisor variable will be the smallest
                // prime number not yet tried.
                divisor = (int)primes[i++];

                // Determine whether the divisor is greater
                // than the square root of n.
                if (divisor * divisor > n)
                {
                    exceedsSquareRoot = true;
                }
                // Determine whether the divisor is a factor of n.
                else if (n % divisor == 0)
                {
                    firstDivisor = divisor;
                    foundDivisor = true;
                }
            }

            return !foundDivisor;
        }

        public class CalculatePrimeProgressChangedEventArgs :
            ProgressChangedEventArgs
        {
            private int latestPrimeNumberValue = 1;

            public CalculatePrimeProgressChangedEventArgs(
                int latestPrime,
                int progressPercentage,
                object userToken) : base(progressPercentage, userToken)
            {
                this.latestPrimeNumberValue = latestPrime;
            }

            public int LatestPrimeNumber
            {
                get { return latestPrimeNumberValue; }
            }
        }

        public class CalculatePrimeCompletedEventArgs :
            AsyncCompletedEventArgs
        {
            private int numberToTestValue = 0;
            private int firstDivisorValue = 1;
            private bool isPrimeValue;

            public CalculatePrimeCompletedEventArgs(
                int numberToTest,
                int firstDivisor,
                bool isPrime,
                Exception e,
                bool canceled,
                object state) : base(e, canceled, state)
            {
                this.numberToTestValue = numberToTest;
                this.firstDivisorValue = firstDivisor;
                this.isPrimeValue = isPrime;
            }

        }
    }
}
