namespace CSharp.Trainings.Exercises.OOP.Lab3_1_1;

public class Execution
{
    public static void Execute()
    {
        Console.WriteLine($"Exercices LAB3_1_1");
        Console.WriteLine("");

        // przeniesione z Main :)
        /* aby wywołać z main => 
         * 
        
        using using CSharp.Trainings.Exercises.OOP.Lab3_1_1;

        // a w metodzie main kod

        Execution.Execute();

        // nie tworzymy obiektu Execution bo metoda Execute ma słowo kluczowe static
         
         */

        // zadanie
        var johnProfile = new UserProfile();
        UserProfile jasonProfile = new();

        Console.WriteLine("");
    }
}
