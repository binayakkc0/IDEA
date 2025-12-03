/* Method: GetNutritionLevel()

Rating >= 9 → "Very Healthy" Rating >= 7 → "Balanced Meal" Rating >= 5 → "Fairly Healthy" Else → "Poor Choice"
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    internal class FullMeal : Menu
    {
        //Constructor to initialize all fields and inherit from base class
        public FullMeal(int itemId, string name, double rating, double price) :
            base(itemId, name, rating, price)
        {
        }

        //Method to get nutrition level based on rating
        string getNutritionLevel()
        {
            if (Rating >= 9)
            {
                return "Very Healthy";
            }
            else if (Rating >= 7)
            {
                return "Balanced Meal";
            }
            else if (Rating >= 5)
            {
                return "Fairly Healthy";
            }
            else
            {
                return "Poor Choice";
            }
        }

        //Tostring method to add nutrition level
        public override string ToString()
        {
            string str;
            str = base.ToString() + " | Nutrition Level: " + getNutritionLevel();
            return str;
        }
    }
}
