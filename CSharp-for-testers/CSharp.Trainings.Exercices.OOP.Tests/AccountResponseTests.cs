using CSharp.Trainings.Exercises.OOP.Extensions;
using CSharp.Trainings.Exercises.OOP.Models.Responses;
using CSharp.Trainings.Exercises.OOP.Services;
using System.Text.Json;

namespace CSharp.Trainings.Exercices.OOP.Tests;

public class AccountResponseTests
{
    [Test]
    public void TestAccountResponseAsObject()
    {
        string filePath = "ExampleFiles\\accountResponse.json";
        string content = FileService.ReadFile(filePath);

        AccountResponse accountResponse = JsonSerializer.Deserialize<AccountResponse>(content, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

        Assert.That(content, Is.Not.Null);
        Assert.That(accountResponse.Users.Count, Is.EqualTo(3));
        Assert.That(accountResponse.Users[1].Address.Street, Is.EqualTo("Marszałkowska"));
        Assert.That(accountResponse.Users[2].Email, Is.EqualTo("bob@test.pl"));
    }

    [Test]
    public void TestAccountResponseAsObjectUsingExtensions()
    {
        string filePath = "ExampleFiles\\accountResponse.json";
        string content = FileService.ReadFile(filePath);

        AccountResponse accountResponse = content.ToAccountResponse();

        Assert.That(content, Is.Not.Null);
        Assert.That(accountResponse.Users.Count, Is.EqualTo(3));
        Assert.That(accountResponse.Users[1].Address.Street, Is.EqualTo("Marszałkowska"));
        Assert.That(accountResponse.Users[2].Email, Is.EqualTo("bob@test.pl"));
    }
}
