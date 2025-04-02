namespace CSharp.Trainings.Exercises.OOP.Services;

public class FileService
{
    public static string ReadFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"File {filePath} does not exist!");
        }

        string content = File.ReadAllText(filePath);
        return content;
    }
}
