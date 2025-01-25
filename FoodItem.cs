using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission_3
{
    // Class representing a food item with its attributes
    internal class FoodItem
    {
        public string FoodName = ""; // Name of the food item
        public string FoodCategory = ""; // Category (e.g., Dairy, Poultry)
        public int FoodQuantity = 0; // Quantity of the food item
        public DateTime FoodExpDate = DateTime.MinValue; // Expiration date of the food item

        // Constructor to initialize a new FoodItem object and passes in the correct parameters
        public FoodItem(string foodName, string foodCategory, int foodQuantity, DateTime foodExpDate)
        {
            FoodName = foodName;
            FoodCategory = foodCategory;
            FoodQuantity = foodQuantity;
            FoodExpDate = foodExpDate;
        }

        // Method to check if the food item is expired kinda cool!
        public bool IsExpired()
        {
            return FoodExpDate < DateTime.Now;
        }
    }
}