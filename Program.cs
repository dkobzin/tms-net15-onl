/*
 * Author: Pavel Dev
 * GitHub: PavelDev91
 * E-mail: PavelDev1991@gmail.com
 */

using System;

//-----------------------------
using nsMyConsole; // PavelDev
//-----------------------------

//----------------------------------------------------------------------------------------------------------------------------- 
public interface IAnimal
{
    string Name { get; set; }

    void SetName(string name);

    string GetName();

    string Eat();
}
//-------------------------------------------------------------
class MyDog : IAnimal
{
    public string Name { get; set; }

    public void SetName(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }

    public string Eat()
    {
        return "Ваша собака ест!";
    }
}
//-----------------------------------------------------------------------------------------------------------------------------
abstract class Animal
{
    public string Name { get; set; }

    public abstract void SetName(string name);

    public abstract string GetName();

    public virtual string Eat()
    {
        return "Ваше животное ест!";
    }
}
//-------------------------------------------------------------
class Dog : Animal
{
    public override void SetName(string name)
    {
        Name = name;
    }

    public override string GetName()
    {
        return Name;
    }

    public override string Eat()
    {
        return base.Eat();
    }
}
//-----------------------------------------------------------------------------------------------------------------------------

namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------
            Console.SetWindowSize(80, 40);
            Console.SetBufferSize(80, 40);

            Console.SetWindowPosition(0, 0);

            Console.Title = "GitHub: PavelDev91";

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.CursorVisible = false;
            //-------------------------------------------------

            MyConsole workConsole = new MyConsole(0, 0, Console.WindowWidth, Console.WindowHeight);

            workConsole.Write(2, workConsole.GetLineCount(), new string('-', workConsole.GetWidth() - 4));
            workConsole.Write((workConsole.GetWidth() - "Lesson_8".Length) / 2, workConsole.GetLineCount(), "Lesson_8");
            workConsole.Write(2, workConsole.GetLineCount(), new string('-', workConsole.GetWidth() - 4));

            workConsole.Write(2, workConsole.GetLineCount(), "| Exit | Press Key: '" + ConsoleKey.Escape.ToString() + "'");
            workConsole.Write(2, workConsole.GetLineCount(), new string('-', workConsole.GetWidth() - 4));

            workConsole.Draw();
            //-------------------------------------------------
       //     Dog dog = new Dog(); // abstract

            MyDog dog = new MyDog(); // interface

            ConsoleKey pressKey;

            int drawPos = workConsole.GetLineCount();

            string dogName;

            while(true)
            {
                workConsole.Write(2, drawPos, "| Введите имя собаки!");
                workConsole.Write(2, drawPos + 1, new string('-', workConsole.GetWidth() - 4));
                workConsole.Write(2, drawPos + 2, "|");
                workConsole.Write(2, drawPos + 3, new string('-', workConsole.GetWidth() - 4));

                workConsole.Draw();

                dogName = "";
                while(dogName == "")
                {
                    dogName = workConsole.WriteRead(2, drawPos + 2, "Az Ая 09 =+-*/ `~_ !? ;: @#$%& []{}<>^ /\\|()", 32);
                }

                Console.CursorVisible = false;

                dog.SetName(dogName);

                workConsole.LineSame(2, drawPos, "| Вашу собаку зовут: '" + dog.GetName() + "'");

                workConsole.LineSame(2, drawPos + 2, "| " + dog.Eat());

                workConsole.Write(2, drawPos + 4, "| Press any Key!");

                workConsole.Write(2, drawPos + 5, new string('-', workConsole.GetWidth() - 4));

                workConsole.Draw();

                pressKey = Console.ReadKey(true).Key;

                workConsole.ClearLine(drawPos + 4);
                workConsole.ClearLine(drawPos + 5);

                if (pressKey == ConsoleKey.Escape)
                {
                    return;
                }
            }
            //-------------------------------------------------
        }
    }
}
