using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCSamples
{
    public class User :IDisposable
    {
        protected bool disposed = false;
        public string Name { get; set; }
        public List<string> Addresses { get; set; }

        public User(string name, List<string> adresses)
        {
            GCHelper.DisplayTotalMemory();
            Name = name;
            Addresses = adresses;
            GCHelper.DisplayTotalMemory();
        }

        public void DoSomethingWork()
        {
            Console.WriteLine("Do something work!");
            Thread.Sleep(3000);
        }

        public unsafe void DoUnsafeWork()
        {
            int* x; // определение указателя
            int y = 10; // определяем переменную
            x = &y; // указатель x теперь указывает на адрес переменной y
            Console.WriteLine(*x); // 10
            y = y + 20; // меняем значение
            Console.WriteLine(*x);// 30
            *x = 50;
            Console.WriteLine(y); // переменная y=50
        }

        #region Finalize

        ~User()
        {
            ReleaseUnmanagedResources();
        }

        #endregion

        #region Dispose

        private void ReleaseUnmanagedResources()
        {
            GCHelper.DisplayTotalMemory();
        }

        public void Dispose()
        {
            // освобождаем неуправляемые ресурсы
            ReleaseUnmanagedResources();
            Dispose(true);
            // подавляем финализацию
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                // Освобождаем управляемые ресурсы
            }
            // освобождаем неуправляемые объекты
            ReleaseUnmanagedResources();
            disposed = true;
        }

        #endregion

    }
}
