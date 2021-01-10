using System;
using System.IO;

namespace Recipes
{
    class RecipeCard
    {
        static void Main(string[] args)
        {
            Title t = new Title();
            t.MealName();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n Your choice: ");

            string inp = Console.ReadLine();
            inp = inp.ToUpper();
            Console.ResetColor();

            Title t2 = new Title();
            if (t2.ContainTitle(inp))
            {
                Console.WriteLine("\n\n");
                WriteFullLine(" ");
                WriteFullLine(" " + inp);
                WriteFullLine(" ");
                File.AppendAllText("../../../../../MyRecipe.txt", "\n\n\t\t\t" + inp);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Level l = new Level();
                l.MyToStrL(inp);

                MealType m = new MealType();
                m.MyToStrM(inp);

                NoOfPeople n = new NoOfPeople();
                n.MyToStrN(inp);

                Ingredients i = new Ingredients();
                i.IngredientsDisplay();
                i.IngredientsList(inp);

                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n\n File \"MyRecipe.txt\" containing your chosen recipes is in your desktop now");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n Recipe not found:\n");
                Console.ResetColor();
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\n If you want to learn another recipe type yes: ");
            string inpYes = Console.ReadLine();
            inpYes = inpYes.ToLower();
            Console.ResetColor();

            if (inpYes == "yes")
                RecipeCard.Main(args);
        }

        static void WriteFullLine(string value)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(value.PadRight(Console.WindowWidth));

            Console.ResetColor();
        }
    }
}
