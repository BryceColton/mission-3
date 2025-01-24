// See https://aka.ms/new-console-template for more information

using mission_3;
List<FoodItem> foodItemList = new List<FoodItem>();
string answer = "";

Console.WriteLine("Would you like to add a new food item? ");
answer = Console.ReadLine().ToLower();
while (answer == "yes")
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
        Console.WriteLine($"\n {i + 1}: \n{foodItemList[i].foodName} \n{foodItemList[i].foodCategory} \n{foodItemList[i].foodQuantity} \n{foodItemList[i].foodExpDate}");

    }

    Console.WriteLine("Would you like to add another Food Item? ");
    answer = Console.ReadLine();

}

while (answer != "exit")
{
    Console.WriteLine("Would you like to see the current list (type Current), delete a food item (Type Delete) or exit the program? ");

    answer = Console.ReadLine();
    switch (answer)
    {
        case "Current":
            Console.WriteLine("Current List: ");
            for (int i = 0; i < foodItemList.Count; i++)
            {
                Console.WriteLine($"\n {i + 1}: \n{foodItemList[i].foodName} \n{foodItemList[i].foodCategory} \n{foodItemList[i].foodQuantity} \n{foodItemList[i].foodExpDate}");

            }

            break;

        case "Delete":
            while (answer == "Delete" || answer == "yes")
            {
                Console.WriteLine("Here is the current List of Items What is the ID number of the Item to Delete: ");
                for (int i = 0; i < foodItemList.Count; i++)
                {
                    Console.WriteLine($"\n {i + 1}: \n{foodItemList[i].foodName} \n{foodItemList[i].foodCategory} \n{foodItemList[i].foodQuantity} \n{foodItemList[i].foodExpDate}");

                }
                int foodTrash = Int32.Parse(Console.ReadLine());
                foodItemList.RemoveAt(foodTrash - 1);
                Console.WriteLine($"Item Deleted {foodTrash}");
                for (int i = 0; i < foodItemList.Count; i++)
                {
                    Console.WriteLine($"\n {i + 1}: \n{foodItemList[i].foodName} \n{foodItemList[i].foodCategory} \n{foodItemList[i].foodQuantity} \n{foodItemList[i].foodExpDate}");

                }

                Console.WriteLine("Would you like to Delete another? ");
                answer = Console.ReadLine();

            }



            break;

        case "exit":
            Console.WriteLine("Thanks for using the program!");
            Environment.Exit(200);
            break;

    }

}


