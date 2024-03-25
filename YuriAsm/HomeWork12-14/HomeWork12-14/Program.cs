using HomeWork12_14.HomeWork13;
using HomeWork12_14.HomeWork14;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

#region Валидация данных
Console.Write("Get Login :");
var login = Console.ReadLine();
Console.Write("Get Password :");
var password = Console.ReadLine();
Console.Write("Get Password again :");
var confirmPassword = Console.ReadLine();

UserLogin userDate = new UserLogin(login!, password!, confirmPassword!);


try
{
    ValidateUserData.ValidateData(userDate);
}
catch (WrongLoginExeption ex)
{
    Console.WriteLine(ex.Message);
}
catch (WrongPasswordExeption ex)
{
    Console.WriteLine(ex.Message);
}
#endregion








