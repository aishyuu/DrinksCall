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
    }
}
