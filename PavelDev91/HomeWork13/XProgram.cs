using System;

//-----------------------------
using nsMyConsole;
//-----------------------------

public class XProgram
{
    //-------------------------
    private MyConsole workConsole;

    private ConsoleKey pressKey;

    WrongLoginException loginException;
    WrongPasswordException passwordException;
    //-------------------------
    //---------------------------------------------------------
    public XProgram()
    {
        Console.SetWindowSize(80, 40);
        Console.SetBufferSize(80, 40);
        Console.SetWindowPosition(0, 0);

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.CursorVisible = false;

        Console.Title = "| HomeWork_13 | GitHub: PavelDev91 |";

        workConsole = new MyConsole(0, 0, Console.WindowWidth, Console.WindowHeight);

        XUser myUser = new XUser();

        //-----------------------------------------------------
        workConsole.Write(2, workConsole.GetLineCount(), new string('-', workConsole.GetWidth() - 4));
        workConsole.Write(2, workConsole.GetLineCount(), "| Введите логин:");
        workConsole.Write(2, workConsole.GetLineCount(), new string('-', workConsole.GetWidth() - 4));
        workConsole.Write(2, workConsole.GetLineCount(), "|");
        workConsole.Write(2, workConsole.GetLineCount(), new string('-', workConsole.GetWidth() - 4));

        //-----------------------------------------------------
        workConsole.Write(2, workConsole.GetLineCount(), "|* Макс кол-во символов = 20.");
        workConsole.Write(2, workConsole.GetLineCount(), "|* Не должен содержать пробелы.");
        workConsole.Write(2, workConsole.GetLineCount(), new string('-', workConsole.GetWidth() - 4));

        while(true)
        {
            if (myUser.Login_Validate(workConsole.WriteRead(2, 3, "Az Ая 09 =+-*/ `~_ !? ;: @#$%& []{}<>^ /\\\\|()\\", 60)) == false)
            {
                loginException = new WrongLoginException("Login: Не верный формат!");

                string[] message = new string[2];
                message[0] = loginException.GetType().Name;
                message[1] = loginException.Message;

                workConsole.ShowMessage(message, MyConsole.eMessageType.error, MyConsole.eMessageBtn.btnOk, out pressKey);

                continue;
            }

            break;
        }
        //-----------------------------------------------------
        workConsole.LineSame(2, 1, "| Введите пароль:");

        workConsole.LineSame(2, 7, "|* Должен содержать хотя бы одну цифру.");
        workConsole.Write(2, workConsole.GetLineCount(), new string('-', workConsole.GetWidth() - 4));

        while (true)
        {
            if (myUser.Password_Validate(workConsole.WriteRead(2, 3, "Az Ая 09 =+-*/ `~_ !? ;: @#$%& []{}<>^ /\\\\|()\\", 60)) == false)
            {
                passwordException = new WrongPasswordException("Password: Не верный формат!");

                string[] message = new string[2];
                message[0] = passwordException.GetType().Name;
                message[1] = passwordException.Message;

                workConsole.ShowMessage(message, MyConsole.eMessageType.error, MyConsole.eMessageBtn.btnOk, out pressKey);

                continue;
            }

            break;
        }
        //-----------------------------------------------------
        workConsole.LineSame(2, 1, "| Повторите пароль:");

        while(true)
        {
            if (myUser.ConfirmPassword_Validate(workConsole.WriteRead(2, 3, "Az Ая 09 =+-*/ `~_ !? ;: @#$%& []{}<>^ /\\\\|()\\", 60)) == false)
            {
                passwordException = new WrongPasswordException("Password: Пароли не совпадают!");

                string[] message = new string[2];
                message[0] = passwordException.GetType().Name;
                message[1] = passwordException.Message;

                workConsole.ShowMessage(message, MyConsole.eMessageType.error, MyConsole.eMessageBtn.btnOk, out pressKey);

                continue;
            }

            break;
        }
        //-----------------------------------------------------
        if (myUser.RegStatus == true)
        {
            string[] mess = new string[1];
            mess[0] = "Регистрация пройдена успешно!";

            workConsole.ShowMessage(mess, MyConsole.eMessageType.info, MyConsole.eMessageBtn.btnOk, out pressKey);
        }
    }
    //---------------------------------------------------------
    public bool Login(XUser userData)
    {
        return true;
    }
    //---------------------------------------------------------
}