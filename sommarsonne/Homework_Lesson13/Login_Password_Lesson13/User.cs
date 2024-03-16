using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Password_Lesson13

{
    public class User
    {
        public string login { get; set; }

        public string password { get; set; }

        public string confirmPassword { get; set; }

        public void GetLoginAndPassword()
        {
            Console.Write("Введите логин: ");
            login = Console.ReadLine();

            Console.Write("Введите пароль: ");
            password = Console.ReadLine();

            Console.Write("Подтвердите пароль: ");
            confirmPassword = Console.ReadLine();
        }
    }
}