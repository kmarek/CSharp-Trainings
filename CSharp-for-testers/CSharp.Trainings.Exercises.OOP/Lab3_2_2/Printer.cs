namespace CSharp.Trainings.Exercises.OOP.Lab3_2_2;

public class Printer
{
    public void Print(int pageCount)
    {
        for (int i = 0; i < pageCount; i++)
        {
            Console.WriteLine("printing");
        }
    }
}
