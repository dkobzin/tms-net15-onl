namespace GCSamples;

public static class GCHelper
{
    public static void DisplayTotalMemory()
    {
        Console.WriteLine($"GC said Total memory: {GC.GetTotalMemory(true)}");
    }

}