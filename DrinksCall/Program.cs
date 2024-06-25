using DrinksCall;
using System.Net.Http.Headers;
using System.Text.Json;

using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
client.DefaultRequestHeaders.Add("User-Agent", ".Net Foundation Repository Reporter");

var categories = await ApiCalls.ProcessCategoriesAsync(client);
Console.WriteLine(categories.list[0].Name);