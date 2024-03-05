using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-----------------------------
using nsMyFunc_2;
using nsMyConsole;
//-----------------------------

namespace HomeWork10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40);
            Console.SetBufferSize(80, 40);
            Console.SetWindowPosition(0, 0);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.CursorVisible = false;

            Console.Title = "GitHub: PavelDev91";

            //-------------------------------------------------
            MyConsole workConsole = new MyConsole(0, 0, Console.WindowWidth, Console.WindowHeight);

            workConsole.Write(2, workConsole.GetLineCount(), new string('-', workConsole.GetWidth() - 4));
            workConsole.Write((workConsole.GetWidth() - "Home Work 10".Length) / 2, workConsole.GetLineCount(), "Home Work 10");
            workConsole.Write(2, workConsole.GetLineCount(), new string('-', workConsole.GetWidth() - 4));

            workConsole.Write(2, workConsole.GetLineCount(), new string('-', workConsole.GetWidth() - 4));
            workConsole.Write(2, workConsole.GetLineCount(), "| Exit | Press Key: '" + ConsoleKey.Escape.ToString() + "'");
            workConsole.Write(2, workConsole.GetLineCount(), new string('-', workConsole.GetWidth() - 4));
            //-------------------------------------------------

            ConsoleKey pressKey;

            Truck truck = new Truck();
            SportCar sportCar = new SportCar();

            //-------------------------------------------------
            workConsole.Write(2, workConsole.GetLineCount(), new string('-', workConsole.GetWidth() - 4));
            workConsole.Write(2, workConsole.GetLineCount(), "| Your Car:");
            workConsole.Write(2, workConsole.GetLineCount(), new string('-', workConsole.GetWidth() - 4));

            workConsole.Write(2, workConsole.GetLineCount(), "| " + truck.ToString());
            workConsole.Write(2, workConsole.GetLineCount(), "| Drive      | Press Key '" + ConsoleKey.D.ToString() + "'");
            workConsole.Write(2, workConsole.GetLineCount(), "| ReFuel     | Press Key '" + ConsoleKey.R.ToString() + "'");
            workConsole.Write(2, workConsole.GetLineCount(), "| Fuel Value | '" + truck.fuelValue.ToString() + "'");
            workConsole.Write(2, workConsole.GetLineCount(), new string('-', workConsole.GetWidth() - 4));

            workConsole.Write(2, workConsole.GetLineCount(), "| " + sportCar.ToString());
            workConsole.Write(2, workConsole.GetLineCount(), "| Drive      | Press Key '" + ConsoleKey.M.ToString() + "'");
            workConsole.Write(2, workConsole.GetLineCount(), "| ReFuel     | Press Key '" + ConsoleKey.F.ToString() + "'");
            workConsole.Write(2, workConsole.GetLineCount(), "| Fuel Value | '" + sportCar.fuelValue.ToString() + "'");
            workConsole.Write(2, workConsole.GetLineCount(), new string('-', workConsole.GetWidth() - 4));
            //-------------------------------------------------

            int drawPos = workConsole.GetLineCount();

            string info;

            int reFuelValue;

            while(true)
            {
                workConsole.LineSame(2, 12, "| Fuel Value | '" + truck.fuelValue.ToString() + "'");
                workConsole.LineSame(2, 17, "| Fuel Value | '" + sportCar.fuelValue.ToString() + "'");

                workConsole.Draw();

                //---------------------------------------------
                pressKey = Console.ReadKey(true).Key;

                if (pressKey == ConsoleKey.D)
                {
                    truck.Drive(out info);

                    workConsole.LineSame(2, drawPos, "| " + info);

                    workConsole.Write(2, drawPos + 1, new string('-', workConsole.GetWidth() - 4));

                    continue;
                }

                if (pressKey == ConsoleKey.M)
                {
                    sportCar.Drive(out info);

                    workConsole.LineSame(2, drawPos, "| " + info);

                    workConsole.Write(2, drawPos + 1, new string('-', workConsole.GetWidth() - 4));

                    continue;
                }

                if (pressKey == ConsoleKey.R)
                {
                    workConsole.LineSame(2, drawPos, "| Write ReFuel Value:");

                    info = workConsole.WriteRead(2, drawPos + 1, "09", 6);

                    Console.CursorVisible = false;

                    if (info.Length == 0)
                    {
                        workConsole.ClearLine(drawPos);
                        workConsole.ClearLine(drawPos + 1);
                        workConsole.Draw();

                        continue;
                    }

                    reFuelValue = (int)MyFunc_2.StringToInt(info);

                    truck.ReFuel(reFuelValue);

                    workConsole.LineSame(2, drawPos, "| Ваш автомобиль <" + truck.ToString() + "> заправлен!");
                    workConsole.LineSame(2, drawPos + 1, "| Press any Key");

                    workConsole.Draw();

                    Console.ReadKey(true);

                    workConsole.ClearLine(drawPos);
                    workConsole.ClearLine(drawPos + 1);
                    workConsole.Draw();

                    continue;
                }

                if (pressKey == ConsoleKey.F)
                {
                    workConsole.LineSame(2, drawPos, "| Write ReFuel Value:");

                    info = workConsole.WriteRead(2, drawPos + 1, "09", 6);

                    Console.CursorVisible = false;

                    if (info.Length == 0)
                    {
                        workConsole.ClearLine(drawPos);
                        workConsole.ClearLine(drawPos + 1);
                        workConsole.Draw();

                        continue;
                    }

                    reFuelValue = (int)MyFunc_2.StringToInt(info);

                    sportCar.ReFuel(reFuelValue);

                    Console.CursorVisible = false;

                    workConsole.LineSame(2, drawPos, "| Ваш автомобиль <" + sportCar.ToString() + "> заправлен!");
                    workConsole.LineSame(2, drawPos + 1, "| Press any Key");

                    workConsole.Draw();

                    Console.ReadKey(true);

                    workConsole.ClearLine(drawPos);
                    workConsole.ClearLine(drawPos + 1);
                    workConsole.Draw();

                    continue;
                }

                if (pressKey == ConsoleKey.Escape)
                {
                    return;
                }
            }
        }
    }
}
