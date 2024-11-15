namespace CSharp.Trainings.Exercises.OOP.Lab3_2_1;

public class Person
{
    public string firstName;
    public string lastName;
    public int age;

    public void Introduce()
    {
        Console.WriteLine($"Hello! I'm {firstName} {lastName}.");
        Console.WriteLine($"I'm {age} years old.");
    }
}
