namespace CSharp.Trainings.Exercises.OOP.Lab3_2_2;

public class LoginPage
{
    public void Login(string username, string password)
    {
        Console.WriteLine($"Logging using {username} and {password}");
    }

    public void Login(User user)
    {
        Console.WriteLine($"Logging using {user.username} and {user.password}");
    }
}
