namespace CSharp.Trainings.Exercises.OOP.Lab3_2_2;

public class Execution
{
    public static void Execute()
    {
        Console.WriteLine($"Exercices LAB3_2_2");
        Console.WriteLine("");

        // zad 2-3-4
        var printer = new Printer();
        printer.Print(4);

        //zad 5
        var loginPage = new LoginPage();
        loginPage.Login("user1", "password1");
        loginPage.Login("user2", "password2");

        // zad 6
        var james = new User { username = "james@email.pl", password = "pass1" };
        var loginPage2 = new LoginPage();
        loginPage2.Login(james);

        // zad 7
        var chrome = new Browser();
        chrome.Launch(["--automated-setting", "--other-arg"]);

        string[] chromeArgs = ["--arg--1", "--arg--2", "--arg--3"];
        chrome.Launch(chromeArgs);

        Console.WriteLine("");
    }
}
