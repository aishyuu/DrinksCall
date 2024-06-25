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
        public static string CategoryPrompt(List<Category> categories, int length)
        {
            string[] list = new string[length];
            int count = 0;

            foreach (Category category in categories)
            {
                count++;
            }

            var chosenCategory = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Choose a drinks [blue]category[/]")
                    .AddChoices(list));

            return chosenCategory;
        }
    }
}
