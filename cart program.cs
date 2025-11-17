// create dictionary for items

Dictionary<string, int> cart = new Dictionary<string, int>();

//create dictionary to hold products and their prices

Dictionary<string, decimal> products = new Dictionary<string, decimal>()
{
    {"Apple", 0.5m},
    {"Banana", 0.3m},
    {"Orange", 0.7m},
    {"Grapes", 2.0m}
};

// create a method to add products to the dictionary

void AddToCart(string product, int quantity)
{
    if (products.ContainsKey(product))
    {
        if (cart.ContainsKey(product))
        {
            Console.WriteLine("You have already added that to cart");
        }
        else
        {
            cart[product] = quantity;
            Console.WriteLine($"{quantity} {product}(s) added to cart.");
        }
    }
    else
    {
        Console.WriteLine("Product not found.");
    }
}
// create a method to display all products in the dictionary
void DisplayProducts()
{
    Console.WriteLine("Available Products:");
    foreach (var item in products)
    {
        Console.WriteLine($"{item.Key}: ${item.Value}");
    }
}

// create a method to display cart items

void DisplayCart()
{
    Console.WriteLine("Items in Cart:");
    foreach (var item in cart)
    {
        Console.WriteLine($"{item.Key}: {item.Value}");
    }
}

// create a method to display cost of cart

void DisplayCartTotal()
{
    decimal total = 0;
    foreach (var item in cart)
    {
        if (products.ContainsKey(item.Key))
        {
            total += products[item.Key] * item.Value;
        }
    }
    Console.WriteLine($"Total Cost: ${total}");
}

// create method to change quantity of items in cart
void ChangeQuantity(string product, int quantity)
{
    if (cart.ContainsKey(product))
    {
        cart[product] = quantity;
        Console.WriteLine($"Quantity of {product} changed to {quantity}.");
    }
    else
    {
        Console.WriteLine("Product not found in cart.");
    }
}

// create method to remove item from cart
void RemoveFromCart(string product)
{
    if (cart.ContainsKey(product))
    {
        cart.Remove(product);
        Console.WriteLine($"{product} removed from cart.");
    }
    else
    {
        Console.WriteLine("Product not found in cart.");
    }
}

// Main program loop
while (true)
{
    Console.WriteLine("\n1. Display Products\n2. Add to Cart\n3. Display Cart\n4. Change Quantity\n5. Remove from Cart\n6. Display Cart Total\n7. Exit");
    Console.Write("Choose an option: ");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            DisplayProducts();
            break;
        case "2":
            Console.Write("Enter product name: ");
            string productToAdd = Console.ReadLine();
            Console.Write("Enter quantity: ");
            int quantityToAdd = int.Parse(Console.ReadLine());
            AddToCart(productToAdd, quantityToAdd);
            break;
        case "3":
            DisplayCart();
            break;
        case "4":
            Console.Write("Enter product name: ");
            string productToChange = Console.ReadLine();
            Console.Write("Enter new quantity: ");
            int newQuantity = int.Parse(Console.ReadLine());
            ChangeQuantity(productToChange, newQuantity);
            break;
        case "5":
            Console.Write("Enter product name: ");
            string productToRemove = Console.ReadLine();
            RemoveFromCart(productToRemove);
            break;
        case "6":
            DisplayCartTotal();
            break;
        case "7":
            return;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}