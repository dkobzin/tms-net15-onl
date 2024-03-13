using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Lesson13Using;

public class BaseClass: IDisposable
{
    private string _name;
    // Flag: Has Dispose already been called?
    private bool _disposed;
    SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

    public BaseClass(string name)
    {
        this._name = name;
    }

    public void DoWork()
    {
        Console.WriteLine($"{_name} do work!");
    }
    // Public implementation of Dispose pattern callable by consumers.
    public void Dispose()
    {
        Console.WriteLine($"Called {_name} Dispose()!");
        Dispose(true);
        GC.SuppressFinalize(this);           
    }

    // Protected implementation of Dispose pattern.
    protected virtual void Dispose(bool disposing)
    {
        Console.WriteLine($"Called {_name} Dispose() with {disposing}!");
        if (_disposed)
            return; 

        if (disposing) {
            handle.Dispose();
        }

        // Free any unmanaged objects here.
        //
        _disposed = true;
    } 
    ~BaseClass()
    {
        Console.WriteLine($"Finalize {_name}!");
        Dispose(false);
    }
}