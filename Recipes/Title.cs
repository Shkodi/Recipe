using System;

namespace Recipes
{
    class Title
    {
        //An array of string which represent title of recipes
        protected string[] mealName =
        {
            //breakfast
            "Oatmeal Cup",
            "Brekfast Burger",
            //lunch
            "Chicken Pizza",
            "Peas Carrot and Paneer Pilaf",
            "Chicken salad",
            //supper
            "Italian Rice Omlet",
            "Herbed Muffins",
            //snack
            "Croissants",
            "Yogurt with Honey and Saffron",
            //dessert
            "Strawberry Cake",
            "Sugar Paste",
            "Chocolate Donut",
            //drinks
            "Cappuccino",
            "Date Smoothie",
            "Iced Espresso",
            //vegan-food
            "Broccoli Soup",
            //seafood
            "Peri Peri Fish Finger",
            "Crispy Fried Fish",
        };

        public Title()
        {  
        }

        //Makes all elemnts of mealName same length
        public void MealName()
        {
            Console.WriteLine("\n");
            WriteFullLine(" ");
            WriteFullLine(" Choose a recipe in the list below:");
            WriteFullLine(" ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green; 
            for (int i = 0; i < mealName.Length; i++)
            {
                int j = mealName[i].Length;
                while(j <= 30)
                {
                    mealName[i] = mealName[i].Insert(mealName[i].Length, " ");
                    j++;
                }

                if (i%3 == 2)
                    Console.WriteLine("\t" + mealName[i] + "\n");
                else
                    Console.Write("\t" + mealName[i]);
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        //check if user input equals one of the elements of mealName
        public bool ContainTitle(string s)
        {
            for (int i = 0; i < mealName.Length; i++)
            {
                mealName[i] = mealName[i].ToUpper();
                if (s == mealName[i])
                    return true;
            }
            return false;
        }

        //A method to display an entire line with chosen color
        static void WriteFullLine(string value)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(value.PadRight(Console.WindowWidth));

            Console.ResetColor();
        }
    } 
}
