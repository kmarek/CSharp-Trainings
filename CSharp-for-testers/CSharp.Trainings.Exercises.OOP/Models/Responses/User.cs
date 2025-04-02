namespace CSharp.Trainings.Exercises.OOP.Models.Responses;

public class User
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Email { get; set; } = string.Empty;
    public Address Address { get; set; } = new();
}
