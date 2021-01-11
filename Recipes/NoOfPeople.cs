using System;
using System.IO;

namespace Recipes
{
    class NoOfPeople : Level
    {
        private int[] NumOfPer = { 1, 3, 5, 7 };
        public NoOfPeople()
        {
        }
        //Calculate for each recipe, number of peple it serves
        public int Number(string s)
        {
            Random r = new Random();
            Level l = new Level();
            if (l.AppointLevel(s) == easy)
                return r.Next(NumOfPer[0], NumOfPer[1]);
            else if (l.AppointLevel(s) == medium)
                return r.Next(NumOfPer[1], NumOfPer[2]);
            else
                return r.Next(NumOfPer[2], NumOfPer[3]);
        }
        
        //Gets value from Number and displays it to console / writes to file 
        public void MyToStrN(string s)
        {
            NoOfPeople n = new NoOfPeople();
            Console.WriteLine("\n\tFor:\t\t\t\t" + n.Number(s) + " people");
            File.AppendAllText("../../../../../MyRecipe.txt", "\n\n\tFor:\t\t\t\t" + n.Number(s) + " people");
        }
    }
}
