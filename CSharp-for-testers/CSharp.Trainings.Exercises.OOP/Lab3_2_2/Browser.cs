namespace CSharp.Trainings.Exercises.OOP.Lab3_2_2;

public class Browser
{
    public void Launch(string[] args)
    {
        Console.WriteLine($"Launching browser with args.");

        foreach (string arg in args)
        {
            Console.WriteLine($"Browser arg: {arg}");
        }
    }
}
