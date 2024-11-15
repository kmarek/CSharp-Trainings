namespace CSharp.Trainings.Exercises.OOP.Lab3_2_3;

public class Execution
{
    public static void Execute()
    {
        Console.WriteLine($"Exercices LAB3_2_3");
        Console.WriteLine("");

        // zad 2
        var person = new Person();
        int age1 = person.AddYears(1);
        int age2 = person.AddYears(23);

        Console.WriteLine($"age1: {age1} po dodaniu 1");
        Console.WriteLine($"age2: {age2} po dodaniu 23");

        // zad 3
        int currentAge = person.GetAge();
        Console.WriteLine($"Current age is {currentAge}");

        // zad 4
        person.SetEmail("email@email.pl");
        string email = person.GetEmail();
        Console.WriteLine($"Email: {email}");

        // zad 6
        var firefox = new Browser();
        LoginPage loginPage = firefox.OpenLoginPage("https://my.loging.page.pl");
    }
}
