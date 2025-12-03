/* Fields: itemId, name, rating, price

Constructor: initializes all fields

Properties: for each field (use auto-properties)

Method: ToString() — returns a formatted string like
"Item ID: 101 | Name: Veggie Wrap | Rating: 8 | Price: $7.99"
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    internal class Menu
    {

        //Private fields or properties for encapsulation
        private int itemId;
        private string name;
        private double rating;
        private double price;

        //Getter and Setter to access the private fields
        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        //Constructor to initialize all fields
        public Menu(int itemId, string name, double rating, double price)
        {
            ItemId = itemId;
            Name = name;
            Rating = rating;
            Price = price;
        }

        //Tostring method to display 
        public override string ToString()
        {
            string dsp;
            dsp = "Item ID: " + ItemId + " | Name: " + Name + " | Rating: " + Rating + " | Price: $" + Price;
            return dsp;
        }

    }
}
