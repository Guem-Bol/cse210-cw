using System;
using System.Collections.Generic;
using System.Linq;

// 1. Define a Product class
public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(int productId, string name, decimal price)
    {
        ProductId = productId;
        Name = name;
        Price = price;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"{ProductId}. {Name} - ${Price:F2}");
    }
}

// 2. Define a CartItem class
public class CartItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public CartItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public decimal TotalPrice
    {
        get { return Product.Price * Quantity; }
    }

    public void DisplayCartItem()
    {
        Console.WriteLine($"- {Product.Name} x {Quantity} = ${TotalPrice:F2}");
    }
}

// 3. Define the ShoppingCart class
public class ShoppingCart
{
    private List<CartItem> items;

    public ShoppingCart()
    {
        items = new List<CartItem>();
    }

    public void AddItem(Product product, int quantity)
    {
        // Check if item already exists in cart, update quantity
        CartItem existingItem = items.FirstOrDefault(i => i.Product.ProductId == product.ProductId);
        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
            Console.WriteLine($"{quantity} more of {product.Name} added to cart. Total quantity: {existingItem.Quantity}");
        }
        else
        {
            items.Add(new CartItem(product, quantity));
            Console.WriteLine($"{quantity} x {product.Name} added to cart.");
        }
    }

    public void RemoveItem(int productId)
    {
        CartItem itemToRemove = items.FirstOrDefault(i => i.Product.ProductId == productId);
        if (itemToRemove != null)
        {
            items.Remove(itemToRemove);
            Console.WriteLine($"{itemToRemove.Product.Name} removed from cart.");
        }
        else
        {
            Console.WriteLine("Item not found in cart.");
        }
    }

    public void ViewCart()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("\nYour cart is empty.");
            return;
        }

        Console.WriteLine("\n--- Your Shopping Cart ---");
        foreach (var item in items)
        {
            item.DisplayCartItem();
        }
        Console.WriteLine($"--------------------------");
        Console.WriteLine($"Cart Total: ${GetCartTotal():F2}");
        Console.WriteLine("--------------------------");
    }

    public decimal GetCartTotal()
    {
        return items.Sum(item => item.TotalPrice);
    }

    public void ClearCart()
    {
        items.Clear();
    }
}

// 4. Main Program Logic
public class OnlineOrderingProgram
{
    private static List<Product> availableProducts;
    private static ShoppingCart customerCart;

    static void Main(string[] args)
    {
        InitializeProducts();
        customerCart = new ShoppingCart();

        Console.WriteLine("Welcome to our Online Ordering System!");

        bool running = true;
        while (running)
        {
            DisplayMainMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayProducts();
                    break;
                case "2":
                    AddToCart();
                    break;
                case "3":
                    customerCart.ViewCart();
                    break;
                case "4":
                    RemoveFromCart();
                    break;
                case "5":
                    PlaceOrder();
                    running = false; // Exit after placing order
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Thank you for visiting! Goodbye.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    private static void InitializeProducts()
    {
        availableProducts = new List<Product>
        {
            new Product(101, "Iphone", 1200.00m),
            new Product(102, "TV 32Inch", 25.50m),
            new Product(103, "board Game", 75.00m),
            
        };
    }

    private static void DisplayMainMenu()
    {
        Console.WriteLine("\n--- Main Menu ---");
        Console.WriteLine("1. View Products");
        Console.WriteLine("2. Add Item to Cart");
        Console.WriteLine("3. View Cart");
        Console.WriteLine("4. Remove Item from Cart");
        Console.WriteLine("5. Place Order");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
    }

    private static void DisplayProducts()
    {
        Console.WriteLine("\n--- Available Products ---");
        foreach (var product in availableProducts)
        {
            product.DisplayProduct();
        }
        Console.WriteLine("--------------------------");
    }

    private static void AddToCart()
    {
        DisplayProducts();
        Console.Write("Enter Product ID to add: ");
        if (int.TryParse(Console.ReadLine(), out int productId))
        {
            Product productToAdd = availableProducts.FirstOrDefault(p => p.ProductId == productId);
            if (productToAdd != null)
            {
                Console.Write($"Enter quantity for {productToAdd.Name}: ");
                if (int.TryParse(Console.ReadLine(), out int quantity) && quantity > 0)
                {
                    customerCart.AddItem(productToAdd, quantity);
                }
                else
                {
                    Console.WriteLine("Invalid quantity. Please enter a positive number.");
                }
            }
            else
            {
                Console.WriteLine("Product not found with that ID.");
            }
        }
        else
        {
            Console.WriteLine("Invalid Product ID.");
        }
    }

    private static void RemoveFromCart()
    {
        customerCart.ViewCart();
        if (customerCart.GetCartTotal() == 0) return; 

        Console.Write("Enter Product ID to remove from cart: ");
        if (int.TryParse(Console.ReadLine(), out int productId))
        {
            customerCart.RemoveItem(productId);
        }
        else
        {
            Console.WriteLine("Invalid Product ID.");
        }
    }

    private static void PlaceOrder()
    {
        if (customerCart.GetCartTotal() == 0)
        {
            Console.WriteLine("Your cart is empty. Please add items before placing an order.");
            return;
        }

        Console.WriteLine("\n--- Confirm Your Order ---");
        customerCart.ViewCart();

        Console.Write("Proceed with order? (yes/no): ");
        string confirmation = Console.ReadLine().ToLower();

        if (confirmation == "yes")
        {
            Console.WriteLine("\nOrder placed successfully!");
            Console.WriteLine($"Total amount: ${customerCart.GetCartTotal():F2}");
            Console.WriteLine("Thank you for your purchase!");
            customerCart.ClearCart();
        }
        else
        {
            Console.WriteLine("Order cancelled.");
        }
    }
}