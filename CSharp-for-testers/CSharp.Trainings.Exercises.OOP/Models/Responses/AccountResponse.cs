namespace CSharp.Trainings.Exercises.OOP.Models.Responses;

public class AccountResponse
{
    public string ApiVersion { get; set; } = string.Empty;
    public List<User> Users { get; set; } = [];
}
