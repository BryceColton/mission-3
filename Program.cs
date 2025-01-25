

// I have to import all of these otherwise it breaks

using System;
using System.Collections.Generic;
using mission_3;

// Main program starts here
class Program
{
    static void Main(string[] args)
    {
        // List to store all food items in the inventory
        List<FoodItem> foodItemList = new List<FoodItem>();
        string answer = "";

        // Infinite loop for until the user types exit
        while (true)
        {
            // Displaying menu options for the user
            Console.WriteLine("\n--- Food Bank Inventory System ---");
            Console.WriteLine("1. Add Food Item");
            Console.WriteLine("2. Delete Food Item");
            Console.WriteLine("3. Print Food Items");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option (1-4): ");


            answer = Console.ReadLine();

            // Handling exceptions and when users are being dumb
            try
            {
                switch (answer)
                {
                    case "1":
                        AddFoodItem(foodItemList);
                        break;
                    case "2":
                        DeleteFoodItem(foodItemList);
                        break;
                    case "3":
                        PrintFoodItems(foodItemList);
                        break;
                    case "4":
                        Console.WriteLine("Thanks for using the Food Bank Inventory System!");
                        return;
                    default:
                        throw new ArgumentException("Invalid option. Please select a number between 1 and 4.");
                }
            }
            // Catching and displaying specific argument exceptions
            catch (ArgumentException error)
            {
                Console.WriteLine(error.Message);
            }
            // Catching any other unforeseen exceptions
            catch (Exception error)
            {
                Console.WriteLine($"An unexpected error occurred: {error.Message}");
            }
        }
    }

    // This is the Method to add a new food item to the inventory
    static void AddFoodItem(List<FoodItem> foodItemList)
    {
        Console.Write("Enter food name: ");
        string foodName = Console.ReadLine();

        Console.Write("Enter food category (e.g., Dairy, Poultry): ");
        string foodCategory = Console.ReadLine();

        Console.Write("Enter food quantity: ");
        int foodQuantity;
        while (!int.TryParse(Console.ReadLine(), out foodQuantity) || foodQuantity < 0)
        {
            Console.Write("Invalid quantity. Enter a positive whole number: ");
        }

        Console.Write("Enter expiration date (MM/DD/YYYY): ");
        DateTime foodExpDate;
        while (!DateTime.TryParse(Console.ReadLine(), out foodExpDate))
        {
            Console.Write("Invalid date format. Enter again (MM/DD/YYYY): ");
        }

        foodItemList.Add(new FoodItem(foodName, foodCategory, foodQuantity, foodExpDate));
        Console.WriteLine($"Food item: {foodName} added!");
    }

    // this method is delete a food item from the inventory
    static void DeleteFoodItem(List<FoodItem> foodItemList)
    {
        if (foodItemList.Count == 0)
        {
            Console.WriteLine("No items in the inventory to delete.");
            return;
        }

        PrintFoodItems(foodItemList);
        Console.Write("Enter the ID of the item to delete: ");
        int id;
        while (!int.TryParse(Console.ReadLine(), out id) || id <= 0 || id > foodItemList.Count)
        {
            Console.Write("Invalid ID. Please try entering again: ");
        }

        foodItemList.RemoveAt(id - 1);
        Console.WriteLine($"Item deleted successfully");
    }

    // this Method displays all food items in the inventory
    static void PrintFoodItems(List<FoodItem> foodItemList)
    {
        if (foodItemList.Count == 0)
        {
            Console.WriteLine("No food items in the inventory.");
            return;
        }

        Console.WriteLine("\n--- Current Food Items ---");
        for (int i = 0; i < foodItemList.Count; i++)
        {
            Console.WriteLine($"\nID: {i + 1}\nName: {foodItemList[i].FoodName}\nCategory: {foodItemList[i].FoodCategory}\nQuantity: {foodItemList[i].FoodQuantity}\nExpiration Date: {foodItemList[i].FoodExpDate:MM/dd/yyyy}\nExpired: {(foodItemList[i].IsExpired() ? $"Yes (Expired on: {foodItemList[i].FoodExpDate:MM/dd/yyyy})" : $"No (Expires on: {foodItemList[i].FoodExpDate:MM/dd/yyyy})")}");
        }
    }
}
