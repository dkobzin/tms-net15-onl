/*
 * MyFunc (version: 2.0)
 * Author: Pavel Dev
 * GitHub: PavelDev91
 * E-mail: PavelDev1991@gmail.com
 */

namespace nsMyFunc_2
{
    public static class MyFunc_2
    {
        //-----------------------------------------------------
        public enum eByteSlide
        {
            Forward,

            Back,
        }
        //---------------------------------------------------------------------------------------------------------------------
        public static int ToExp(int value, int exp)
        {
            int res = 1;

            for (int i = 0; i < exp; i++)
            {
                res *= value;
            }

            return res;
        }
        //---------------------
        public static decimal ToExp(decimal value, int exp)
        {
            decimal res = 1;

            for (int i = 0; i < exp; i++)
            {
                res *= value;
            }

            return res;
        }
        //---------------------
        public static double ToExp(double value, int exp)
        {
            double res = 1;

            for (int i = 0; i < exp; i++)
            {
                res *= value;
            }

            return res;
        }
        //---------------------------------------------------------------------------------------------------------------------
        public static bool IntOrNotInt(string value)
        {
            bool res = false;

            if (value.Length == 0)
            {
                return false;
            }

            if (value.Length > 1 && value[0] == '-')
            {
                value = value.Substring(1, value.Length - 1);
            }

            for (int i = 0; i < value.Length; i++)
            {
                res = false;

                switch (value[i])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        res = true;
                        break;
                }

                if (res == false)
                {
                    return res;
                }
            }

            return res;
        }
        //-----------------------------------------------------
        public static int? StringToInt(string value)
        {
            if (IntOrNotInt(value) == false)
            {
                return null;
            }

            int? res = 0;

            bool pref = false;

            if (value[0] == '-')
            {
                pref = true;

                value = value.Substring(1, value.Length - 1);
            }

            int x;

            for (int i = 0; i < value.Length; i++)
            {
                switch (value[i])
                {
                    case '0':
                        x = 0;
                        break;

                    case '1':
                        x = 1;
                        break;

                    case '2':
                        x = 2;
                        break;

                    case '3':
                        x = 3;
                        break;

                    case '4':
                        x = 4;
                        break;

                    case '5':
                        x = 5;
                        break;

                    case '6':
                        x = 6;
                        break;

                    case '7':
                        x = 7;
                        break;

                    case '8':
                        x = 8;
                        break;

                    case '9':
                        x = 9;
                        break;

                    default:
                        x = 0;
                        break;
                }

                res += x * (ToExp(10, (value.Length - 1) - i));
            }

            if (pref == true)
            {
                res = 0 - res;
            }

            return res;
        }
        //---------------------------------------------------------------------------------------------------------------------
        public static double? ToSqrt(double value)
        {
            if (value <= 0)
            {
                return null;
            }
            //-----------------
            double? res = value;

            double x = 1d;

            double z = 0d;

            while (x <= res)
            {
                res -= x;
                x += 2;

                z++;
            }

            x = z;
            res = (double)(value / x);
            res = (double)(x + res);
            res = (double)(res / 2d);

            x = (double)(res);
            res = (double)(value / x);
            res = (double)(x + res);
            res = (double)(res / 2d);

            x = (double)(res);
            res = (double)(value / x);
            res = (double)(x + res);
            res = (double)(res / 2d);

            x = (double)(res);
            res = (double)(value / x);
            res = (double)(x + res);
            res = (double)(res / 2d);

            return res;
        }
        //-----------------------------------------------------
        public static int? ToSqrt(int value)
        {
            if (value <= 0)
            {
                return null;
            }
            //-----------------
            int? res = value;

            int x = 1;

            int z = 0;

            while (x <= res)
            {
                res -= x;
                x += 2;

                z++;
            }

            x = z;
            res = (int)(value / x);
            res = (int)(x + res);
            res = (int)(res / 2);

            x = (int)(res);
            res = (int)(value / x);
            res = (int)(x + res);
            res = (int)(res / 2);

            x = (int)(res);
            res = (int)(value / x);
            res = (int)(x + res);
            res = (int)(res / 2);

            x = (int)(res);
            res = (int)(value / x);
            res = (int)(x + res);
            res = (int)(res / 2);

            return res;
        }
        //---------------------------------------------------------------------------------------------------------------------
        public static void Array_Sort(ref int[] intArray, bool reverse = false)
        {
            bool ws = false;

            while (true)
            {
                int value;

                for (int i = 0; i < intArray.Length; i++)
                {
                    if (i + 1 == intArray.Length)
                    {
                        break;
                    }

                    if (intArray[i + 1] >= intArray[i])
                    {
                        continue;
                    }
                    else
                    {
                        value = intArray[i + 1];

                        intArray[i + 1] = intArray[i];
                        intArray[i] = value;
                    }
                }

                for (int i = 0; i < intArray.Length; i++)
                {
                    if (i + 1 == intArray.Length)
                    {
                        break;
                    }

                    ws = false;

                    if (intArray[i] <= intArray[i + 1])
                    {
                        ws = true;
                    }

                    if (ws == false)
                    {
                        break;
                    }
                }

                if (ws == true)
                {
                    if (reverse == true)
                    {
                        for (int i = 0; i <= intArray.Length / 2; i++)
                        {
                            value = intArray[(intArray.Length - 1) - i];

                            intArray[(intArray.Length - 1) - i] = intArray[i];
                            intArray[i] = value;
                        }
                    }

                    return;
                }
            }
        }
        //-----------------------------------------------------
        public static bool String_DecimalOrNotDecimal(string value)
        {
            if (value.Length == 0)
            {
                return false;
            }

            if (value.Length > 1 && value[0] == '-')
            {
                value = value.Substring(1, value.Length - 1);
            }

            if (value.Length > 1 && value[0] == '.')
            {
                return false;
            }

            if (value.Length > 1 && value[value.Length - 1] == '.')
            {
                return false;
            }

            bool res = false;

            int dot = -1;

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] != '.')
                {
                    continue;
                }

                if (value[i] == '.' && dot == -1)
                {
                    dot = i;

                    continue;
                }

                return false;
            }

            for (int i = 0; i < value.Length; i++)
            {
                if (i == dot)
                {
                    continue;
                }

                res = false;

                switch (value[i])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        res = true;
                        break;
                }

                if (res == false)
                {
                    return false;
                }
            }

            return res;
        }
        //-----------------------------------------------------
        public static decimal? StringToDecimal(string Value)
        {
            if (String_DecimalOrNotDecimal(Value) == false)
            {
                return null;
            }

            bool pref = false;

            if (Value[0] == '-')
            {
                Value = Value.Substring(1);

                pref = true;
            }

            int dot = -1;

            for (int i = 0; i < Value.Length; i++)
            {
                if (Value[i] == '.')
                {
                    dot = i;

                    break;
                }
            }

            int x;

            decimal? res = 0;

            for (int i = 0; i < Value.Length; i++)
            {
                if (i == dot)
                {
                    break;
                }

                x = 0;
                switch (Value[i])
                {
                    case '0':
                        x = 0;
                        break;

                    case '1':
                        x = 1;
                        break;

                    case '2':
                        x = 2;
                        break;

                    case '3':
                        x = 3;
                        break;

                    case '4':
                        x = 4;
                        break;

                    case '5':
                        x = 5;
                        break;

                    case '6':
                        x = 6;
                        break;

                    case '7':
                        x = 7;
                        break;

                    case '8':
                        x = 8;
                        break;

                    case '9':
                        x = 9;
                        break;
                }

                
                if (dot == -1)
                {
                    try
                    {
                        res += (x * ToExp(10m, (Value.Length - 1) - i));
                    }
                    catch
                    {
                    }
                }
                else
                {
                    try
                    {
                        res += (x * ToExp(10m, (dot - 1) - i));
                    }
                    catch
                    {
                    }
                }
            }

            if (dot == -1)
            {
                if (pref == true)
                {
                    res = 0 - res;
                }

                return res;
            }

            Value = Value.Substring(dot + 1);

            for (int i = 0; i < Value.Length; i++)
            {
                x = 0;
                switch (Value[i])
                {
                    case '0':
                        x = 0;
                        break;

                    case '1':
                        x = 1;
                        break;

                    case '2':
                        x = 2;
                        break;

                    case '3':
                        x = 3;
                        break;

                    case '4':
                        x = 4;
                        break;

                    case '5':
                        x = 5;
                        break;

                    case '6':
                        x = 6;
                        break;

                    case '7':
                        x = 7;
                        break;

                    case '8':
                        x = 8;
                        break;

                    case '9':
                        x = 9;
                        break;
                }

                res += ToExp(0.1m, i + 1) * x;
            }

            if (pref == true)
            {
                res = 0 - res;
            }

            return res;
        }
        //-----------------------------------------------------
        public static byte[] ByteToBinary(byte value)
        {
            byte[] res = new byte[8];

            int b = 0;

            int exp;

            for (int i = 0; i < res.Length; i++)
            {
                exp = (res.Length - 1) - i;

                if (ToExp(2, exp) + b <= value)
                {
                    b += ToExp(2, exp);

                    res[i] = 1;
                }
                else
                {
                    res[i] = 0;
                }
            }

            return res;
        }
        //-----------------------------------------------------
        public static byte BinaryToByte(byte[] value)
        {
            byte res = 0;

            int exp;

            if (value == null || value.Length != 8)
            {
                return res;
            }

            for (int i = 0; i < value.Length; i++)
            {
                exp = (value.Length - 1) - i;

                if (value[i] == 1)
                {
                    res += (byte)ToExp(2, exp);
                }
            }

            return res;
        }
        //-----------------------------------------------------
        public static byte ByteNE(byte value)
        {
            byte[] mass = ByteToBinary(value);

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == 1)
                {
                    mass[i] = 0;
                }
                else
                {
                    mass[i] = 1;
                }
            }

            return BinaryToByte(mass);
        }
        //-----------------------------------------------------
        public static byte ByteMirror(byte value)
        {
            byte[] buf = ByteToBinary(value);

            byte[] res = new byte[8];

            for (int i = 0; i < buf.Length; i++)
            {
                res[i] = buf[(buf.Length - 1) - i];
            }

            return BinaryToByte(res);
        }
        //-----------------------------------------------------
        public static byte ByteSlide(byte value, eByteSlide slide, byte slideValue)
        {
            byte res = value;

            if (slide == eByteSlide.Forward)
            {
                if (value + slideValue <= byte.MaxValue)
                {
                    res = (byte)(value + slideValue);
                }
                else
                {
                    res = (byte)((value + slideValue) - byte.MaxValue);
                }
            }

            if (slide == eByteSlide.Back)
            {
                if (value - slideValue >= 0)
                {
                    res = (byte)(value - slideValue);
                }
                else
                {
                    res = (byte)(byte.MaxValue - (slideValue - value));
                }
            }

            return res;
        }
        //-----------------------------------------------------
        public static byte[] CharToByte(char value)
        {
            byte[] buf = new byte[16];

            byte[] res = new byte[2];

            byte[] mass = new byte[8];

            int x = 0;

            int exp;

            for (int i = 0; i < buf.Length; i++)
            {
                exp = (buf.Length - 1) - i;

                if (ToExp(2, exp) + x <= value)
                {
                    x += ToExp(2, exp);

                    buf[i] = 1;
                }
                else
                {
                    buf[i] = 0;
                }
            }

            mass[0] = buf[0];
            mass[1] = buf[1];
            mass[2] = buf[2];
            mass[3] = buf[3];
            mass[4] = buf[4];
            mass[5] = buf[5];
            mass[6] = buf[6];
            mass[7] = buf[7];

            res[0] = BinaryToByte(mass);

            mass[0] = buf[8];
            mass[1] = buf[9];
            mass[2] = buf[10];
            mass[3] = buf[11];
            mass[4] = buf[12];
            mass[5] = buf[13];
            mass[6] = buf[14];
            mass[7] = buf[15];

            res[1] = BinaryToByte(mass);

            return res;
        }
        //-----------------------------------------------------
        public static char? ByteToChar(byte[] value)
        {
            int res = 0;

            int exp;

            if (value == null || value.Length != 2)
            {
                return null;
            }

            byte[] mass = new byte[16];
            byte[] mass1;
            byte[] mass2;

            mass1 = ByteToBinary(value[0]);
            mass2 = ByteToBinary(value[1]);

            for (int i = 0; i < mass1.Length; i++)
            {
                mass[i] = mass1[i];
            }

            for (int i = 0; i < mass2.Length; i++)
            {
                mass[mass1.Length + i] = mass2[i];
            }

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == 1)
                {
                    exp = (mass.Length - 1) - i;

                    res += ToExp(2, exp);
                }
            }

            return (char)res;
        }
        //-----------------------------------------------------
        public static string CharToString(char[] value)
        {
            string res = "";

            if (value == null || value.Length == 0)
            {
                return res;
            }

            for (int i = 0; i < value.Length; i++)
            {
                res += value[i];
            }

            return res;
        }
        //-----------------------------------------------------
        public static char[] StringToChar(string value)
        {
            char[] res = new char[value.Length];

            for (int i = 0; i < value.Length; i++)
            {
                res[i] = value[i];
            }

            return res;
        }
        //-----------------------------------------------------
        public static string String_AddXLength(string value, int setLenght, char xChar)
        {
            if (setLenght == value.Length)
            {
                return value;
            }

            if (setLenght < value.Length)
            {
                return value.Substring(0, setLenght);
            }

            for (int i = value.Length; i < setLenght; i++)
            {
                value += xChar;
            }

            return value;
        }
        //-----------------------------------------------------
        public static string String_DeleteXLength(string value, char xChar)
        {
            int x = 0;

            for (int i = 0; i < value.Length; i++)
            {
                if (value[(value.Length - 1) - i] != xChar)
                {
                    x = value.Length - i;

                    break;
                }
            }

            string res = "";

            for (int i = 0; i < x; i++)
            {
                res += value[i];
            }

            return res;
        }
        //-----------------------------------------------------
    }
}