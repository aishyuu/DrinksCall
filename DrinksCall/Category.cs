using System.Text.Json.Serialization;

public record class Category(
    [property: JsonPropertyName("drinks")] StrCategory[] list);

public record class StrCategory(
    [property: JsonPropertyName("strCategory")] string Name);
