using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksCall
{
    internal class MenuUtility
    {
        public static string CategoryPrompt(Category categories)
        {
            string[] list = new string[categories.list.Length];
            int count = 0;

            foreach(StrCategory category in categories.list)
            {
                list[count] = category.Name;
                count++;
            }

            

            var chosenCategory = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Choose a drinks [blue]category[/]")
                    .AddChoices(list));

            return chosenCategory;
        }

        public static string DrinkPrompt(Drinks drinks)
        {
            string[] list = new string[drinks.list.Length];
            int count = 0;

            foreach(DrinkOverview drink in drinks.list)
            {
                list[count] = drink.Name;
                count++;
            }

            var chosenDrink = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Choose a drinks [blue]category[/]")
                    .AddChoices(list));

            var foundItem = drinks.list.SingleOrDefault(item => item.Name == chosenDrink);
            return foundItem.Id;
        }

        public static void DisplayDrinkInfo(DrinksInfo drink)
        {
            AnsiConsole.Write(new Rows(
                new Markup($"[green]Name[/]: {drink.AllInfo[0].Name}"),
                new Markup($"[green]Category[/]: {drink.AllInfo[0].Category}"),
                new Markup($"[red]{drink.AllInfo[0].Alcoholic}[/]"),
                new Markup($"[green]Glass[/]: {drink.AllInfo[0].Glass}")
                ));
        }
    }
}
