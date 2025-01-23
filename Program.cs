// See https://aka.ms/new-console-template for more information

using mission_3;
List<FoodItem> foodItemList = new List<FoodItem>();
string answer = "";

Console.WriteLine("Would you like to add a new food item? ");
answer = Console.ReadLine().ToLower();
if (answer == "yes")
{
    FoodItem fi = new FoodItem();    
    Console.WriteLine("What is the name of the food item? ");
    fi.foodName = Console.ReadLine();
    Console.WriteLine("What is the Category ex. 'Dairy','Poultry', 'Desserts' etc.");
    fi.foodCategory = Console.ReadLine();
    Console.WriteLine("What is the Quantity? ");
    fi.foodQuantity = Int32.Parse(Console.ReadLine());
    Console.WriteLine("What is the Expiration Date (in format of 'MM/DD/YYYY'? ");
    fi.foodExpDate = DateTime.Parse(Console.ReadLine());

    foodItemList.Add(fi);

    Console.WriteLine("Here is the current list: ");
    
    for (int i = 0; i < foodItemList.Count; i++)
    {
        Console.WriteLine($"{foodItemList[i].foodName} \n{foodItemList[i].foodCategory} \n{foodItemList[i].foodQuantity} \n{foodItemList[i].foodExpDate}");

    }

    Console.WriteLine("Would you like to add another, delete, edit ")


}

