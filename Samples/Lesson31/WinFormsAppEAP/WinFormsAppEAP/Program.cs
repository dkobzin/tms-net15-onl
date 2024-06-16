using System;
using System.Windows.Forms;

namespace WinFormsAppEAP;

public class Program
{
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        //ApplicationConfiguration.Initialize();
        Application.Run(new PrimeNumberCalculatorMain());
    }
}