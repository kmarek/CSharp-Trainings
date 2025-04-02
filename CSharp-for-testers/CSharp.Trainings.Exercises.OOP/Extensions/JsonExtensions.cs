using CSharp.Trainings.Exercises.OOP.Models.Responses;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharp.Trainings.Exercises.OOP.Extensions;

public static class JsonExtensions
{
    public static AccountResponse ToAccountResponse(this string json)
    {
        return JsonSerializer.Deserialize<AccountResponse>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
    }

    public static ArticleResponse ToArticleResponse(this string json)
    {
        var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        options.Converters.Add(new JsonStringEnumConverter());
        return JsonSerializer.Deserialize<ArticleResponse>(json, options);
    }
}
