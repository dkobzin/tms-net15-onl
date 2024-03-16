using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Password_Lesson13

{
    public class User
    {
        //public string login { get; set; }

        //public string password { get; set; }

        //public string confirmPassword { get; set; }

        //public void GetLoginAndPassword()
        //{
        //    try
        //    {
        //        Console.Write("Введите логин: ");
        //        login = Console.ReadLine();

        //        Console.Write("Введите пароль: ");
        //        password = Console.ReadLine();

        //        Console.Write("Подтвердите пароль: ");
        //        confirmPassword = Console.ReadLine();

        //    }
        //    catch (WrongLoginException)
        //    {
        //        Console.WriteLine("Ошибка при вводе логина");

        //    }
        //    catch (WrongPasswordException)
        //    {
        //        Console.WriteLine("Ошибка при вводе пароля");
        //    }
        //}

        public string login
        {
            get { return login; }
            set
            {
                if (WrongLoginException.CheckSpaces(value))
                {
                    throw new WrongLoginException("Login can't contain spaces");
                }
                else if (WrongLoginException.CheckLength(value, 20))
                {
                    throw new WrongLoginException("Login can't be longer than 20 characters");
                }
                else
                {
                    login = value;
                }
            }
        }

        public void GetLoginPassword()
        {
            try
            {
                Console.Write("Enter your login: ");
                login = Console.ReadLine();

                //Console.Write("Enter your password: ");
                //Password = Console.ReadLine();
            }
            catch (WrongLoginException ex)
            {
                Console.WriteLine("Login error: " + ex.Message);
            }
            //catch (WrongPasswordException ex)
            //{
            //    Console.WriteLine("Password error: " + ex.Message);
            //}
        }
    }
}