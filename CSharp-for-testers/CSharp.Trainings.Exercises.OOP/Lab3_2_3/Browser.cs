namespace CSharp.Trainings.Exercises.OOP.Lab3_2_3;

public class Browser
{
    public LoginPage OpenLoginPage(string url)
    {
        Console.WriteLine($"Opening page {url}");
        var loginPage = new LoginPage();
        return loginPage;
    }
}
