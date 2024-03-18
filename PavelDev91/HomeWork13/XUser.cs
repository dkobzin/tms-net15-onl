
public class XUser
{
    public bool RegStatus { get; private set; }
    public string Login { get; private set; }
    public string Password { get; private set; }
    public string ConfirmPassword { get; private set; }
    //---------------------------------------------------------
    public XUser()
    {
        RegStatus = false;

        Login = null;
        Password = null;
        ConfirmPassword = null;
    }
    //---------------------------------------------------------
    public bool Login_Validate(string login)
    {
        bool res = false;

        if (login == null || login.Length == 0)
        {
            return false;
        }

        if (login.Length <= 20 && login.IndexOf(' ') == -1)
        {
            Login = login;

            return true;
        }

        return res;
    }
    //---------------------------------------------------------
    public bool Password_Validate(string password)
    {
        bool res = false;

        if (Login == null)
        {
            return false;
        }

        if (password == null || password.Length == 0)
        {
            return false;
        }

        if (password.Length <= 20 && password.IndexOf(' ') == -1 && FindDigit(password) != -1)
        {
            Password = password;

            return true;
        }

        return res;
    }
    //---------------------------------------------------------
    public bool ConfirmPassword_Validate(string confirmPassword)
    {
        bool res = false;

        if (Password == null)
        {
            return false;
        }

        if (confirmPassword == Password)
        {
            ConfirmPassword = confirmPassword;

            RegStatus = true;

            return true;
        }

        return res;
    }
    //---------------------------------------------------------
    private int FindDigit(string value)
    {
        int res = -1;

        for (int i = 0; i < value.Length; i++)
        {
            if (char.IsDigit(value[i]))
            {
                return i;
            }
        }

        return res;
    }
    //---------------------------------------------------------
}