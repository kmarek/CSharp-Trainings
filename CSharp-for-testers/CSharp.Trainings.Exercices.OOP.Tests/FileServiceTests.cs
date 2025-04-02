using CSharp.Trainings.Exercises.OOP.Services;

namespace CSharp.Trainings.Exercices.OOP.Tests;

public class FileServiceTests
{
    [Test]
    public void TestFileServiceForExistingFile()
    {
        string filePath = "ExampleFiles\\accountResponse.json";

        string content = FileService.ReadFile(filePath);

        Assert.That(content, Is.Not.Empty);
    }

    [Test]
    public void TestFileServiceForNotExistingFile()
    {
        string filePath = "not-existing-file.txt";

        void Act() => FileService.ReadFile(filePath);

        Assert.Throws<FileNotFoundException>(Act);
    }
}