namespace CSharp.Trainings.Exercises.OOP.Models.Responses;

public class ArticleResponse
{
    public int Id { get; set; }
    public Category Category { get; set; } = new();
    public string Name { get; set; } = string.Empty;
    public List<string> PhotoUrls { get; set; } = [];
    public List<Tag> Tags { get; set; } = [];
    public Status Status { get; set; }
}
