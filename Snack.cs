/* Method: GetFlavorScore()

Rating >= 9 → "Super Tasty" Rating >= 7 → "Good Flavor" Rating >= 5 → "Average Taste" Else → "Needs More Spice"
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    internal class Snack : Menu
    {
        //Constructor to initialize all fields and inherit from base class
        public Snack(int itemId, string name, double rating, double price) :
            base(itemId, name, rating, price)
        {
        }

        //Method to get flavor score based on rating
        string getFlavorScore()
        {
            if (Rating >= 9)
            {
                return "Super Tasty";
            }
            else if (Rating >= 7)
            {
                return "Good Flavor";
            }
            else if (Rating >= 5)
            {
                return "Average Taste";
            }
            else
            {
                return "Needs More Spice";
            }
        }

            //Tostring method to add flavor score
            public override string ToString()
        {
            string str;
            str = base.ToString() + " | Flavour Score: " + getFlavorScore();
            return str;
        }
        
    }
}

