namespace CSharp.Trainings.Exercises.OOP.Lab3_2_1;

public class Execution
{
    public static void Execute()
    {
        Console.WriteLine($"Exercices LAB3_2_1");
        Console.WriteLine("");

        // zad 2
        var sarah = new Person
        {
            firstName = "Sarah",
            lastName = "Doe",
            age = 25
        };

        // wywołanie metody Introduce
        sarah.Introduce();


        // zad 5 (coś mi numeracja siadła :(
        var companyPrinter = new Printer();
        companyPrinter.PrintPage();

        // zad 6
        var mainPage = new MainPage();
        mainPage.Logout();

        Console.WriteLine("");
    }
}
