using System.Text.Json.Serialization;

public record class Category(
    [property: JsonPropertyName("drinks")] StrCategory[] list);

public record class StrCategory(
    [property: JsonPropertyName("strCategory")] string Name);

public record class Drinks(
    [property: JsonPropertyName("drinks")] DrinkOverview[] list);

public record class DrinkOverview(
    [property: JsonPropertyName("strDrink")] string Name,
    [property: JsonPropertyName("idDrink")] string Id);

public record class DrinksInfo(
    [property: JsonPropertyName("drinks")] FullInfo[] AllInfo);

public record class FullInfo(
    [property: JsonPropertyName("strDrink")] string Name,
    [property: JsonPropertyName("strCategory")] string Category,
    [property: JsonPropertyName("strAlcoholic")] string Alcoholic,
    [property: JsonPropertyName("strGlass")] string Glass);