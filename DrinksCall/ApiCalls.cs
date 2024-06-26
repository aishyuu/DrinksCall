using System.Text.Json;

namespace DrinksCall
{
    internal class ApiCalls
    {
        public static async Task<Category> ProcessCategoriesAsync(HttpClient client)
        {
            await using Stream stream =
                await client.GetStreamAsync("https://www.thecocktaildb.com/api/json/v1/1/list.php?c=list");
            var categories =
                await JsonSerializer.DeserializeAsync<Category>(stream);

            return categories;
        }

        public static async Task<Drinks> ProcessDrinksAsync(HttpClient client, string chosenCategory)
        {
            await using Stream stream =
                await client.GetStreamAsync($"https://www.thecocktaildb.com/api/json/v1/1/filter.php?c={chosenCategory}");
            var drinks =
                await JsonSerializer.DeserializeAsync<Drinks>(stream);

            return drinks;
        }

        public static async Task<DrinksInfo> ProcessDrinksInfoAsync(HttpClient client, string drinkId)
        {
            await using Stream stream =
                await client.GetStreamAsync($"https://www.thecocktaildb.com/api/json/v1/1/lookup.php?i={drinkId}");
            var drink =
                await JsonSerializer.DeserializeAsync<DrinksInfo>(stream);

            return drink;
        }
    }
}
