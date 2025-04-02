using CSharp.Trainings.Exercises.OOP.Extensions;
using CSharp.Trainings.Exercises.OOP.Models.Responses;
using CSharp.Trainings.Exercises.OOP.Services;

namespace CSharp.Trainings.Exercices.OOP.Tests.ExampleFiles;

public class ArticleResponseTests
{
    [Test]
    public void TestArticleResponse1()
    {
        string filePath = "ExampleFiles\\articleResponse1.json";
        string content = FileService.ReadFile(filePath);

        ArticleResponse articleResponse = content.ToArticleResponse();

        Assert.That(content, Is.Not.Null);
        Assert.That(articleResponse.Name, Is.EqualTo("Visiting New Zealand"));
        Assert.That(articleResponse.PhotoUrls.Count, Is.EqualTo(2));
        Assert.That(articleResponse.Tags.Count, Is.EqualTo(2));
        Assert.That(articleResponse.Status, Is.EqualTo(Status.Published));
    }

    [Test]
    public void TestArticleResponse2()
    {
        string filePath = "ExampleFiles\\articleResponse2.json";
        string content = FileService.ReadFile(filePath);

        ArticleResponse articleResponse = content.ToArticleResponse();

        Assert.That(content, Is.Not.Null);
        Assert.That(articleResponse.Name, Is.EqualTo("Canoeing in Norway"));
        Assert.That(articleResponse.PhotoUrls.Count, Is.EqualTo(2));
        Assert.That(articleResponse.Tags.Count, Is.EqualTo(2));
        Assert.That(articleResponse.Status, Is.EqualTo(Status.Draft));
    }
}
