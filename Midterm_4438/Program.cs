public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        //Initialized the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    //To Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // Updated the item's price with the new price.
        Price = newPrice;
    }

    //To Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // Increased the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
    }

    // To Sell an item
    public void SellItem(int quantitySold)
    {
        // Decreasing the item's stock quantity by the quantity sold along with surity tyhat the stock doesn't go negative.

        if (QuantityInStock >= quantitySold)
        {
            QuantityInStock -= quantitySold;
        }
        else
        {
            Console.WriteLine("Error: There are not enough items in stock to sell.");
        }
    }

    // To check if an item is in stock
    public bool IsInStock()
    {
        //  Checking if an item is in stock
        //  Returning true if the item is in stock (quantity > 0), otherwise false.
        return QuantityInStock >= 0;
    }

    // To Print item details
    public void PrintDetails()
    {
        // for Printing the details of an item such as name, id, price, and stock quantity.
        Console.WriteLine($"Item: {ItemName} (ID: {ItemId})");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
        Console.WriteLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.49, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.39, 15);

        // Implementing logic to interact with these objects.

        // 1. Printing details of all items.
        Console.WriteLine("Initial Inventory Details:\n");
        item1.PrintDetails();
        item2.PrintDetails();
        Console.WriteLine("----------------------------------------------");

        // 2. Selling some items and then printing the updated details.
        int quantitySold = 6;
        item1.SellItem(quantitySold);
        item2.SellItem(quantitySold);
        Console.WriteLine($"Sold {quantitySold} Laptops and {quantitySold} Smartphones.\nUpdated Inventory Details:");
        item1.PrintDetails();
        item2.PrintDetails();
        Console.WriteLine("----------------------------------------------");

        // 3. Restocking an item and printing the updated details.
        int additionalQuantity = 3;
        item1.RestockItem(additionalQuantity);
        item2.RestockItem(additionalQuantity);
        Console.WriteLine($"Restocked {additionalQuantity} Laptops and {additionalQuantity} Smartphones.\nUpdated Inventory Details:");
        item1.PrintDetails();
        item2.PrintDetails();
        Console.WriteLine("----------------------------------------------");


        // 4.C hecking if an item is in stock and printing a message accordingly.
        Console.WriteLine($"Is {item1.ItemName} in stock? {item1.IsInStock()}");
        Console.WriteLine($"Is {item2.ItemName} in stock? {item2.IsInStock()}");
        Console.WriteLine("----------------------------------------------");
    }
}