using System;
using System.IO;
using System.Linq;

namespace Recipes
{
    class MealType : Ingredients
    {
        private string[] type = 
        {
            "Breakfast", 
            "Lunch",     
            "Supper",    
            "Snack",     
            "Dessert",   
            "Drinks",    
            "Vegan-food",
            "Seafood"    
        };

        public MealType()
        {
        }

        public string TypeOfMeal(string s)
        {
            for (int i = 0; i < mealName.Length; i++)
            {
                mealName[i] = mealName[i].ToUpper();
                if (s == mealName[i])
                {
                    if(i == 0 || i == 1)
                        return type[0];
                    else if (i == 2 || i == 3 || i == 4)
                        return type[1];
                    else if(i == 5 || i == 6)
                        return type[2];
                    else if (i == 7 || i == 8)
                        return type[3];
                    else if (i == 9 || i == 10 || i == 11)
                        return type[4];
                    else if (i == 12 || i == 13 || i == 14)
                        return type[5];
                    else if (i == 15)
                        return type[6];
                    else
                        return type[7];
                }
            }
            return null;
        }

        public void MyToStrM(string s)
        {
            MealType m = new MealType();
            Console.WriteLine("\n\tType of meal:\t\t\t" + m.TypeOfMeal(s));
            File.AppendAllText("../../../../../MyRecipe.txt", "\n\n\tType of meal:\t\t\t" + m.TypeOfMeal(s));
        }

        //public void TypeOfMeal(string s)
        //{
        //    Console.Write("\n\tType of meal: ");
        //    for (int i = 0; i < mealName.Length; i++)
        //    {
        //        mealName[i] = mealName[i].ToUpper();
        //        if (s == mealName[i])
        //        {
        //            if (ingredName[i].Contains("Fish"))
        //                Console.Write(type[7] + "\n");

        //            else if (!ingredName[i].Contains("Milk") && 
        //                    !ingredName[i].Contains("Egg") && 
        //                    !ingredName[i].Contains("Cheese") &&
        //                    !ingredName[i].Contains("Cream") &&
        //                    !ingredName[i].Contains("Yogurt") &&
        //                    !ingredName[i].Contains("Butter"))
        //                Console.Write(type[6] + "\n");

        //            else if (ingredName[i].Contains("Cream") ||
        //                    ingredName[i].Contains("Chocolate") ||
        //                    ingredName[i].Contains("Cocoa") ||
        //                    ingredName[i].Contains("Sugar"))
        //                Console.Write(type[4] + "\n");

        //            else if (ingredName[i].Contains("Coffee") ||
        //                    ingredName[i].Contains("Ice"))
        //                Console.Write(type[5] + "\n");

        //            else if (ingredName[i].Contains("Peeper") ||
        //                    ingredName[i].Contains("Chicken"))
        //                Console.Write(type[1] + "\n");

        //            else if (ingredName[i].Contains("Sausage") ||
        //                    ingredName[i].Contains("Apple"))
        //                Console.Write(type[0] + "\n");

        //            else if (ingredName[i].Contains("Rice") || 
        //                    ingredName[i].Contains("Flour"))
        //                Console.Write(type[2] + "\n");

        //            else
        //                Console.Write(type[3] + "\n");

        //        }
        //    }
        //}
    }
}