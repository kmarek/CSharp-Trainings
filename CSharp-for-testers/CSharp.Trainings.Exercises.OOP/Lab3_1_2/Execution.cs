namespace CSharp.Trainings.Exercises.OOP.Lab3_1_2;

public class Execution
{
    public static void Execute()
    {
        Console.WriteLine($"Exercices LAB3_1_2");
        Console.WriteLine("");

        // zad 2
        Person johny = new Person();
        johny.firstName = "Johny";

        Console.WriteLine($"firstName: {johny.firstName}");
        Console.WriteLine($"lastName: {johny.lastName}");
        Console.WriteLine($"age: {johny.age}");

        // zad 3
        var request = new ApiRequest();
        request.resource = "/users";
        request.body = "user1, user2, user3";
        request.headers = ["header1", "header2", "header3", "header4"];

        // zad 4
        var response = new ApiResponse()
        {
            statusCode = 200,
            statusMessage = "OK",
            body = "some body",
            headers = request.headers // mogę też przypisać wartość innej zmiennej tego samego typu!
        };

        Console.WriteLine("");
    }
}
