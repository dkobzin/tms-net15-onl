/*
 * MyConsole
 * Author: Pavel Dev
 * GitHub: PavelDev91
 * E-mail: PavelDev1991@gmail.com
 */

using System;
using System.Threading;
using System.Globalization;

namespace nsMyConsole
{
    class MyConsole
    {
        //-----------------------------------------------------
        private struct sMyConsole_Position
        {
            public int left;
            public int top;

            public int width;
            public int height;
        }
        //-----------------------------------------------------
        private sMyConsole_Position myConsole_Position;

        private char?[,] workArray;
        private char?[,] bufferArray;

        private bool autoSize;

        private Thread myThread;
        //-----------------------------------------------------
        public MyConsole(int left, int top, int width, int height, bool _autoSize = false)
        {
            myConsole_Position = new sMyConsole_Position();

            myConsole_Position.left = left;
            myConsole_Position.top = top;

            myConsole_Position.width = width;
            myConsole_Position.height = height;

            workArray = new char?[width, height];
            bufferArray = new char?[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    workArray[x, y] = ' ';
                    bufferArray[x, y] = ' ';
                }
            }

            autoSize = _autoSize;

            if (autoSize == true)
            {
                myThread = new Thread(AutoReSize);
                myThread.IsBackground = true;
                myThread.Start();
            }
        }
        //-----------------------------------------------------
        public void Draw()
        {
            for (int y = 0; y < myConsole_Position.height; y++)
            {
                for (int x = 0; x < myConsole_Position.width - 1; x++)
                {
                    if (workArray[x, y] == ' ' && workArray[x, y] != bufferArray[x, y])
                    {
                        Console.SetCursorPosition(myConsole_Position.left + x, myConsole_Position.top + y);
                        Console.Write(' ');

                        bufferArray[x, y] = ' ';

                        continue;
                    }

                    if (workArray[x, y] == bufferArray[x, y])
                    {
                        continue;
                    }

                    bufferArray[x, y] = workArray[x, y];

                    Console.SetCursorPosition(myConsole_Position.left + x, myConsole_Position.top + y);
                    Console.Write(workArray[x, y]);
                }
            }
        }
        //-----------------------------------------------------
        public void ReDraw()
        {
            for (int x = 0; x < GetWidth(); x++)
            {
                for (int y = 0; y < GetHeight(); y++)
                {
                    bufferArray[x, y] = ' ';
                }
            }

            Console.Clear();

            Draw();
        }
        //-----------------------------------------------------
        public void Write(int left, int top, string value, bool reWrite = false)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (left + i > myConsole_Position.width - 1 | top > myConsole_Position.height - 1)
                {
                    break;
                }

                workArray[left + i, top] = value[i];

                if (reWrite == true)
                {
                    bufferArray[left + i, top] = ' ';
                }
            }
        }
        //-----------------------------------------------------
        public string WriteRead(int left, int top, string mask, int maxLength, string defaultValue = "")
        {
            string res = defaultValue;

            ConsoleKeyInfo pressKey;

            Console.CursorVisible = false;

            string buf;

            while (true)
            {
                //---------------------------------------------
                if (res.Length <= maxLength && res.Length > myConsole_Position.width - (left + 4))
                {
                    ClearLine(top);

                    buf = String_CopyLastNChars(res, res.Length % (myConsole_Position.width - (left + 4)));
                }
                else
                {
                    buf = String_CopyLastNChars(res, res.Length);
                }

                LineSame(left, top, buf);

                Draw();

                Console.SetCursorPosition(left + buf.Length, top);
                Console.CursorVisible = true;
                //---------------------------------------------

                pressKey = Console.ReadKey(true);

                for (int i = 0; i < mask.Length; i++)
                {
                    if (res.Length == maxLength)
                    {
                        break;
                    }

                    if (CharUnicodeInfo.GetUnicodeCategory(pressKey.KeyChar) == CharUnicodeInfo.GetUnicodeCategory(mask[i]))
                    {
                        res += pressKey.KeyChar;

                        break;
                    }
                }

                if (pressKey.Key == ConsoleKey.Backspace)
                {
                    if (res.Length > 0)
                    {
                        res = res.Substring(0, res.Length - 1);
                    }
                }

                if (pressKey.Key == ConsoleKey.Enter)
                {
                    break;
                }

                if (pressKey.Key == ConsoleKey.Escape)
                {
                    return "";
                }
            }

            return res;
        }
        //-----------------------------------------------------
        public void DrawList(int left, int top, int width, int height, string[] list, int? selIndex = null, string selIndexPrefix = null, string prefix = null)
        {
            if (list == null || list.Length == 0)
            {
                for (int i = 0; i < height; i++)
                {
                    ClearLine(top + i);
                }

                return;
            }

            if (selIndex == null || selIndex < 0 || selIndex >= list.Length)
            {
                selIndex = 0;
            }

            int x = 0;

            string value;

            if (list.Length > height)
            {
                x = (int)selIndex;

                if (list.Length - x <= height)
                {
                    x = list.Length - height;
                }

                for (int i = 0; i < height; i++)
                {
                    ClearLine(top + i);
                }

                Draw();
            }

            for (int i = x; i < list.Length; i++)
            {
                if (i - x >= height)
                {
                    break;
                }

                value = list[i];
                if (list[i].Length > width)
                {
                    value = list[i].Substring((list[i].Length - (width - left)));
                }

                if (i == selIndex)
                {
                    if (selIndexPrefix == null && prefix != null)
                    {
                        selIndexPrefix = prefix;
                    }

                    LineSame(left, top + (i - x), selIndexPrefix + value);
                }
                else
                {
                    LineSame(left, top + (i - x), prefix + value);
                }
            }

            for (int i = list.Length; i < height; i++)
            {
                ClearLine(top + i);
            }
        }
        //-----------------------------------------------------
        public string String_CopyLastNChars(string value, int nChars)
        {
            string res = "";

            if (nChars > value.Length)
            {
                nChars = value.Length;
            }

            for (int i = value.Length - nChars; i < value.Length; i++)
            {
                res += value[i];
            }

            return res;
        }
        //-----------------------------------------------------
        public void LineSame(int left, int lineIndex, string value)
        {
            if (lineIndex >= myConsole_Position.height - 1)
            {
                return;
            }

            for (int i = 0; i < myConsole_Position.width; i++)
            {
                workArray[i, lineIndex] = ' ';
            }

            for (int i = 0; i < value.Length; i++)
            {
                workArray[left + i, lineIndex] = value[i];
            }
        }
        //-----------------------------------------------------
        public int GetWidth()
        {
            return myConsole_Position.width;
        }
        //-----------------------------------------------------
        public int GetHeight()
        {
            return myConsole_Position.height;
        }
        //-----------------------------------------------------
        public int GetLineCount()
        {
            int res = 0;

            for (int y = 0; y < myConsole_Position.height; y++)
            {
                for (int x = 0; x < myConsole_Position.width; x++)
                {
                    if (workArray[x, y] != ' ')
                    {
                        res = y + 1;

                        break;
                    }
                }
            }

            return res;
        }
        //-----------------------------------------------------
        public void ClearLine(int LineIndex)
        {
            for (int x = 0; x < myConsole_Position.width; x++)
            {
                workArray[x, LineIndex] = ' ';
            }
        }
        //-----------------------------------------------------
        public void Clear()
        {
            for (int x = 0; x < myConsole_Position.width; x++)
            {
                for (int y = 0; y < myConsole_Position.height; y++)
                {
                    workArray[x, y] = ' ';
                }
            }
        }
        //-----------------------------------------------------
        public enum eMessageType : byte
        {
            info = 0,
            error = 1,
            dialog = 2,
        }
        //---------------------
        public enum eMessageBtn : byte
        {
            btnOk = 0,
            btnYesNo = 1,
            btnYesNoCancel = 2,
            btnCancel = 3,
        }
        //---------------------
        public void ShowMessage(string[] messageText, eMessageType messageType, eMessageBtn messageBtn, out ConsoleKey result)
        {
            Console.CursorVisible = false;

            string consoleTitle = Console.Title;
            //-------------------------------------------------
            char?[,] buf = new char?[GetWidth(), GetHeight()];

            for (int x = 0; x < GetWidth(); x++)
            {
                for (int y = 0; y < GetHeight(); y++)
                {
                    buf[x, y] = bufferArray[x, y];
                }
            }
            //-------------------------------------------------
            Clear();
            Draw();

            //-------------------------------------------------
            Write(2, GetLineCount(), new string('-', GetWidth() - 4));

            for (int i = 0; i < messageText.Length; i++)
            {
                Write((GetWidth() / 2) - (messageText[i].Length / 2), GetLineCount(), messageText[i]);
            }

            Write(2, GetLineCount(), new string('-', GetWidth() - 4));

            if (messageType == eMessageType.info)
            {
                Console.Title = "| Message | Info!";
            }

            if (messageType == eMessageType.error)
            {
                Console.Title = "| Message | Error!";
            }

            if (messageType == eMessageType.dialog)
            {
                Console.Title = "| Message | Dialog!";
            }
            //-------------------------------------------------
            int btnL;

            if (messageBtn == eMessageBtn.btnOk)
            {
                btnL = GetWidth() / 2;
                btnL -= ("| Ok | Press Key: '" + ConsoleKey.Enter.ToString() + "'").Length / 2;

                Write(btnL, GetLineCount(), "| Ok | Press Key: '" + ConsoleKey.Enter.ToString() + "' |");
            }

            if (messageBtn == eMessageBtn.btnYesNo)
            {
                btnL = GetWidth() / 2;
                btnL /= 2;
                btnL -= ("| Yes | Press Key: '" + ConsoleKey.Y.ToString() + "' |").Length / 2;

                Write(btnL, GetLineCount(), "| Yes | Press Key: '" + ConsoleKey.Y.ToString() + "' |");

                btnL = GetWidth() / 2;
                btnL += btnL / 2;
                btnL -= ("| No | Press Key: '" + ConsoleKey.N.ToString() + "' |").Length / 2;

                Write(btnL, GetLineCount() - 1, "| No | Press Key: '" + ConsoleKey.N.ToString() + "' |");
            }
            //-------------------------------------------------

            Draw();

            ConsoleKey pressKey;

            while(true)
            {
                pressKey = Console.ReadKey(true).Key;

                if (messageBtn == eMessageBtn.btnOk)
                {
                    if (pressKey == ConsoleKey.Enter)
                    {
                        result = pressKey;

                        break;
                    }
                }

                if (messageBtn == eMessageBtn.btnYesNo)
                {
                    if (pressKey == ConsoleKey.Y || pressKey == ConsoleKey.N)
                    {
                        result = pressKey;

                        break;
                    }
                }
            }

            //-------------------------------------------------
            for (int x = 0; x < GetWidth(); x++)
            {
                for (int y = 0; y < GetHeight(); y++)
                {
                    workArray[x, y] = buf[x, y];
                }
            }
            //-------------------------------------------------

            Draw();

            Console.Title = consoleTitle; 
        }
        //-----------------------------------------------------
        private void AutoReSize()
        {
            bool resSize;

            while(autoSize == true)
            {
                resSize = false;

                if (Console.WindowWidth != myConsole_Position.width)
                {
                    myConsole_Position.width = Console.WindowWidth;

                    resSize = true;
                }

                if (Console.WindowHeight != myConsole_Position.height)
                {
                    myConsole_Position.height = Console.WindowHeight;

                    resSize = true;
                }

                if (resSize == true)
                {
                    bufferArray = new char?[myConsole_Position.width, myConsole_Position.height];

                    char?[,] buff = workArray;

                    workArray = new char?[myConsole_Position.width, myConsole_Position.height];

                    for (int y = 0; y < myConsole_Position.height; y++)
                    {
                        for (int x = 0; x < myConsole_Position.width; x++)
                        {
                            bufferArray[x, y] = ' ';
                        }
                    }

                    for (int y = 0; y < buff.GetLength(1); y++)
                    {
                        for (int x = 0; x < buff.GetLength(0); x++)
                        {
                            workArray[x, y] = buff[x, y];
                        }
                    }

                    ReDraw();
                }
            }
        }
        //-----------------------------------------------------
    }
}