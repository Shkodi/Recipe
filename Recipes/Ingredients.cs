using System;
using System.IO;

namespace Recipes
{
    class Ingredients : Title
    {
        protected string[][] ingredName =
        {
            new string[] { "Quick cooking oats", "1/2 cup", "Flax seeds", "1 tsp", "Egg", "1", "Milk", "1/2 cup", "Banana", "1/3 (mashed)", "Cinnamon", "1/4 tsp", "Apple", "1/2 (chopped)", "Honey", "1 tbsp" }, //Oatmeal Cup
            new string[] { "Sausage", "1 1/2 cup", "Mince", "1 cup (boiled)", "Salt", "to taste", "Black pepper", "as required", "Eggs", "2", "Bread slice", "1", "Burger bun", "2", "Butter", "as required", "Cheddar cheese", "4 slices" }, //Brekfast Burger
            new string[] { "Hot sauce", "1/4 cup", "Oil", "1 tbsp", "Pizza dough", "300 g", "Shredded cheese", "1 1/2 cup", "Shredded chicken", "1/2 cup", "Minced onion", "2 tbsp", "Chopped olives", "2 tbsp", "Oregano", "1 tsp", "Oil", "for greasing", "Salt", "a pinch" }, //Chicken Pizza
            new string[] { "Onion", "1 medium (diced)", "Carrot", "2 medium (diced)", "Peas", "20 g (boiled)", "Rice", "250 g", "Garlic", "2 cloves (finely chopped)", "Hot vegetable stock", "700 ml", "Salt and pepper", "to taste", "Paneer", "225 g (cubed)", "Oil", "for fry" }, //Peas Carrot and Paneer Pilaf
            new string[] { "Chicken boiled and shreded", "1 cup", "Cucumber", "1 cut lengthwise", "Tomato", "1 cut lengthwise, remove seeds", "Pinapple cubes", "1/2 cup", "Apple", "1 cut in wedges", "Mayonnaise", "5 tbps", "Salt", "1/4 tbps", "White pepper", "1/4 tbps" }, //Chicken salad
            new string[] { "Oil", "1 tbsp", "Scallions", "1 (finely chopped)", "Cooked long grain rice", "1/2 cup", "Salt", "1/2 tbsp", "Chili powder", "1/2 tbsp (optional)", "Eggs", "2 (beaten)", "Sausages", "1 sliced (optional)", "Mozzarella/cheddar cheese", "1/3 cup (cut in cubes)" }, //Italian Rice Omlet
            new string[] { "Whole wheat flour", "180 g", "Flour", "75 g", "Eggs", "2 (large)", "Buttermilk", "1 cup (3/4 cup yogurt + 1/4 cup milk)", "Baking powder", "2 tbsp", "Baking soda", "1/2 tbsp", "Salt", "1/2 tbsp", "Garlic chives", "3 tbsp", "Rosemary", "1 tbsp", "Honey", "2 tbsp" }, //Herbed Muffins
            new string[] { "All purpose flour", "4 cup", "Milk powder", "4 tbsp", "Butter", "4 tbsp", "Sugar", "2 tbsp", "Yeast", "1 - 1/2 tbsp", "Egg", "1", "Water", "for kneading" }, //Croissants
            new string[] { "Yogurt", "2 cup", "Honey", "4 tbsp", "Raisins", "4 tbsp", "Coconut flakes", "4 tbsp", "Saffron", "a pinch", "Almonds", "for garnishing" }, //Yogurt with Honey and Saffron
            new string[] { "Banana", "6 (sliced)", "Mangoes", "2 (sliced)", "Apples", "3 (peeled and sliced)", "Pineapple", "1 tin (finely cubed)", "Chiku", "4 (peeled and sliced)", "Grapes", "1 cup", "Caster Sugar", "4 tbsp", "Salt", "1/2 tbsp", "Mayonnaise", "4 tbsp", "Fresh Cream", "1 1/2 cup" }, //Strawberry Cake
            new string[] { "Flour", "2 3/4 cup", "Caster sugar", "2 cup", "Jelly crystals", "1 packet", "Unsalted Butter", "200 g", "Eggs", "4", "Baking powder", "2 1/2 tbsp", "Corn flour", "1 tbsp heaped", "Milk", "1 cup", "Strawberries puree", "1/2 cup", "Vanilla essence", "1 tbsp" }, //Sugar Paste
            new string[] { "Wheat flour", "300 g", "Sugar", "30 g", "Egg yolk", "1", "Coconut milk", "50 g", "Ice water", "85 ml", "Margarine", "30 g", "Salt", "1 tsp", "Solid oil", "for frying", "Milk", "100 ml", "Dark chocolate", "200 g (chopped)", "Sugar donuts", "100 g for sprinkling" }, //Chocolate Donut
            new string[] { "Milk", "1/2 cup", "Hot brewed Easy Espresso", "1/3 cup" }, //Cappuccino
            new string[] { "Bananas", "2 (ripe)", "Yogurt", "1 cup", "Milk", "1/3 cup", "Dates", "3 (pitted and chopped)", "Vanilla Essence", "1 tsp", "Ice Cubes", "3-4" }, //Date Smoothie
            new string[] { "Coffee", "3/4 cup (mix 3/4 tsp coffee in 3/4 cup water)", "Milk", "1 cup", "Vanilla Ice-cream", "2 scoops", "Sugar", "to taste", "Coffees Ice-block", "4-6", "Strong Coffee", "1 1/2 cup (brewed)" }, //Iced Espresso
            new string[] { "Water", "6 cups", "Salt", "to taste", "Broccoli", "1 head", "Pepper", "to taste"}, //Broccoli Soup
            new string[] { "Fish fingers", "1/2 kg", "Flour", "1/2 cup", "Salt", "1 tbsp", "Black pepper powder", "1 tbsp", "Egg", "1", "Milk", "1/4 cup", "Bread crumbs", "1/4 cup", "Red chilli flakes", "1 tbsp (crushed)", "Garlic powder", "1 tbsp", "Dry ginger powder", "1 tsp" }, //Peri Peri Fish Finger
            new string[] { "Fish fillet", "1/2 kg", "Garlic paste", "1 tbsp", "Lemon juice", "2 tbsp", "Rice flour", "125 g", "Egg", "1", "Crushed cumin seeds", "1 tsp", "All spice powder", "1/2 tsp", "Turmeric", "1 tsp", "Crushed red pepper", "1 tsp", "Oil", "for fry" }, //Crispy Fried Fish 
        };

        public Ingredients()
        {
        }

        public string IngredientsDisplay()
        {
            Console.WriteLine("\n\tIngredients: ");
            File.AppendAllText("../../../../../MyRecipe.txt", "\n\n\tIngredients: \n");
            for (int i = 0; i < ingredName.Length; i++)
            {
                for(int j = 0; j < ingredName[i].Length; j++)
                {
                    for(int k = ingredName[i][j].Length; k <= 30; k++)
                    {
                        ingredName[i][j] = ingredName[i][j].Insert(ingredName[i][j].Length, " ");
                    }
                }
            }
            return null;
        }

        public void IngredientsList(string s)
        {
            for (int k = 0; k < mealName.Length; k++)
            {
                mealName[k] = mealName[k].ToUpper();
                if (s == mealName[k])
                {
                    for (int i = 0; i < ingredName[k].Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write("\n\t " + ingredName[k][i]);
                            File.AppendAllText("../../../../../MyRecipe.txt", "\n\t " + ingredName[k][i]);
                        }
                        else
                        {
                            Console.Write(ingredName[k][i] + "\n");
                            File.AppendAllText("../../../../../MyRecipe.txt", ingredName[k][i] + "\n");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
