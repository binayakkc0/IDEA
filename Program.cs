using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Title of the application
            Console.WriteLine("Food Review Tracker Plus");
            Console.WriteLine("-----------------------");

            //Creating a list object of Menu class
            List<Menu> allItems = new List<Menu>();

            //Creating objects and Adding items for snack
            Snack s1 = new Snack(101, "Vegetable Samosa", 8.5, 6.99);
            allItems.Add(s1);
            Snack s2 = new Snack(102, "Chicken Chilli", 7.5, 5.99);
            allItems.Add(s2);
            Snack s3 = new Snack(103, "Pakora", 9, 4.99);
            allItems.Add(s3);

            //Creating objects and Adding items for full meal
            FullMeal f1 = new FullMeal(201, "Chicken Tikka Masala", 9, 18.99);
            allItems.Add(f1);
            FullMeal f2 = new FullMeal(202, "Butter Chicken", 8.5, 17.99);
            allItems.Add(f2);
            FullMeal f3 = new FullMeal(203, "Mater Paneer", 7, 15.99);
            allItems.Add(f3);

            //Displaying all items
            foreach (Menu items in allItems)
            {
                Console.WriteLine(items);
            }

        }
    }
}
