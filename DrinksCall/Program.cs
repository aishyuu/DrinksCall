using DrinksCall;
using Spectre.Console;
using System.Net.Http.Headers;
using System.Text.Json;

using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
client.DefaultRequestHeaders.Add("User-Agent", ".Net Foundation Repository Reporter");

var categories = await ApiCalls.ProcessCategoriesAsync(client);

string chosenCategory = MenuUtility.CategoryPrompt(categories);
chosenCategory = chosenCategory.Replace(" ", "_");

var drinks = await ApiCalls.ProcessDrinksAsync(client, chosenCategory);
string drinkId = MenuUtility.DrinkPrompt(drinks);

var fullDrinkInfo = await ApiCalls.ProcessDrinksInfoAsync(client, drinkId);

MenuUtility.DisplayDrinkInfo(fullDrinkInfo);