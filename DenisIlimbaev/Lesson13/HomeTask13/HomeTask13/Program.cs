using FluentValidation;
using HomeTask13;
namespace HomeWork13
{
    /*
     * 1. Создать класс Program в консольном приложении, в котором будет статический метод Login.
Этот метод принимает на вход класс User c тремя свойствами:
- Login
- Password
- ConfirmPassword
2.Все свойства имеют тип данных String.
a)Длина Login должна быть меньше 20 символов и не должен содержать
пробелы. Если Login не соответствует этим требованиям, необходимо выбросить
WrongLoginException.
b)Длина Password должна быть меньше 20 символов, не должен содержать
пробелом и должен содержать хотя бы одну цифру.
c)Также Password и ConfirmPassword должны быть равны.Если Password не соответствует этим требованиям, необходимо выбросить WrongPasswordException.
3.WrongPasswordException и WrongLoginException - пользовательские
классы исключения с двумя конструкторами – один по умолчанию, второй
принимает сообщение исключения и передает его в конструктор класса
Exception. 
4.Метод Login возвращает true, если значения верны или false в другом случае.
5.Цикл в Program не использовать.
6.Допустимо использовать FluentValidation для проверки класса User.
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sequentially: " + Environment.NewLine + "1.Login" + Environment.NewLine + "2.Password" + Environment.NewLine + "3.ConfirmPassword");
            Console.WriteLine();
            User user = new User()
            {
                Login = Console.ReadLine(),
                Password = Console.ReadLine(),
                ConfirmPassword = Console.ReadLine(),
            };
            Console.WriteLine(Login(user));
        }
        static bool Login(User user)
        {
            bool res = true;
            string message = string.Empty;
            UserValidator validationRules = new UserValidator(user.ConfirmPassword!);
            var resOP1 = validationRules.Validate(user, context =>
            {
                context.IncludeRuleSets(UserValidator.PasswordSetName);
            });
            var resOP2 = validationRules.Validate(user, context =>
            {
                context.IncludeRuleSets(UserValidator.LoginSetName);
            });
            try
            {

                if (resOP1.IsValid == false || ResultPasswordTest(user.Password!) == false) throw new WrongPasswordExeption("Invalid password.Please check your password");
                if (resOP2.IsValid == false) throw new WrongLoginExeption("Invalid login.Please check your login");
            }
            catch (WrongPasswordExeption ex)
            {
                res = false;
                message += ex.Message + Environment.NewLine;
            }
            catch (WrongLoginExeption ex)
            {
                res = false;
                message += ex.Message + Environment.NewLine;
            }
            if (res == false) Console.WriteLine(message);
            return res;
        }
        static bool ResultPasswordTest(string text)
        {
            bool result = false;
            foreach (char c in text)
            {
                int.TryParse(c.ToString(), out int res);
                if (res is not 0) result = true;
            }
            return result;
        }
    }

}
