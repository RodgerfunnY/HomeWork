
namespace HomeWork12;
internal class PersonalAccount
{
    public string Login { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public PersonalAccount(string login, string password, string confirmPassword)
    {
        Login = login;
        Password = password;
        ConfirmPassword = confirmPassword;
    }
    public static bool ValidateCredentials(string login, string password, string confirmPassword)
    {
        if (login.Contains(' ') || login.Length >= 20)
        {
            throw new WrongLoginException("Логин не должен содержать пробелов и должен быть короче 20 символов");
        }
        if (password.Contains(' ') || password.Length >= 20)
        {
            throw new WrongPasswordException("Пароль не должен содержать пробелов и должен быть короче 20 символов");
        }
        bool namber = false;
        string nambers = "1234567890";
        for (int i = 0; i < password.Length; i++)
        {
            for (int j = 0; j < nambers.Length; j++)
            {
                if (password[i] == nambers[j])
                {
                    namber = true;
                    break;
                }
            }

        }
        if (!namber)
        {
            throw new WrongPasswordException("Пароль должен содержать хотя бы одну цифру");
        }
        if (!(password == confirmPassword))
        {
            throw new WrongPasswordException("Пароль и подтверждение пароля не совпадают");
        }
        return true;
    }
}
