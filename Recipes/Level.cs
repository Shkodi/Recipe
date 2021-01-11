using System;
using System.IO;

namespace Recipes
{
    class Level : Ingredients
    {
        protected string easy = "Beginner";
        protected string medium = "Intermediate";
        protected string hard = "Advanced";

        public Level ()
        {
        }
        //Decide the difficulty level based in the number of ingredients
        public string AppointLevel(string s)
        {
            for (int i = 0; i < mealName.Length; i++)
            {
                mealName[i] = mealName[i].ToUpper();
                if (s == mealName[i])
                {
                    if (ingredName[i].Length <= 8)
                        return easy;
                    else if (ingredName[i].Length <= 16)
                        return medium;
                    else
                        return hard;
                }
            }
            return null;
        }

        //Gets value from AppointLevel and displays it to console / writes to file
        public void MyToStrL(string s)
        {
            Level l = new Level();
            Console.WriteLine("\n\tLevel:\t\t\t\t" + l.AppointLevel(s));
            File.AppendAllText("../../../../../MyRecipe.txt", "\n\n\tLevel:\t\t\t\t" + l.AppointLevel(s));
        }
    }
}
