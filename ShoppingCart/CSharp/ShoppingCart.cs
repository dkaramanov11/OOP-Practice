using System;
using System.Collections.Generic;

namespace OOP_Practice.ShoppingCart.CSharp
{
    internal class Product
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;

            if (price < 0)
            {
                Console.WriteLine(
                    "Price cannot be negative. Setting it to 0.");

                Price = 0;
            }
            else
            {
                Price = price;
            }
        }
    }

    internal class CartItem
    {
        public Product Product { get; }
        public int Quantity { get; private set; }

        public CartItem(Product product, int quantity)
        {
            Product = product;

            if (quantity <= 0)
            {
                Console.WriteLine(
                    "Quantity must be greater than 0. Setting it to 1.");

                Quantity = 1;
            }
            else
            {
                Quantity = quantity;
            }
        }

        public void IncreaseQuantity(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(
                    "Amount must be greater than 0.");

                return;
            }

            Quantity += amount;
        }

        public decimal GetSubtotal()
        {
            return Product.Price * Quantity;
        }
    }

    internal class ShoppingCart
    {
        private readonly List<CartItem> items = new List<CartItem>();

        public void AddProduct(Product? product, int quantity)
        {
            if (product == null)
            {
                Console.WriteLine("Product cannot be null.");
                return;
            }

            if (quantity <= 0)
            {
                Console.WriteLine(
                    "Quantity must be greater than 0.");

                return;
            }

            foreach (CartItem item in items)
            {
                if (item.Product.Id == product.Id)
                {
                    item.IncreaseQuantity(quantity);
                    return;
                }
            }

            items.Add(new CartItem(product, quantity));
        }

        public void RemoveProduct(int productId)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Product.Id == productId)
                {
                    items.RemoveAt(i);
                    Console.WriteLine("Product removed.");
                    return;
                }
            }

            Console.WriteLine(
                $"Product with ID {productId} was not found.");
        }

        public decimal GetTotal()
        {
            decimal total = 0;

            foreach (CartItem item in items)
            {
                total += item.GetSubtotal();
            }

            return total;
        }

        public void PrintCart()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("The cart is empty.");
                return;
            }

            Console.WriteLine("Shopping cart:");

            foreach (CartItem item in items)
            {
                Console.WriteLine(
                    $"{item.Product.Name} | " +
                    $"Quantity: {item.Quantity} | " +
                    $"Subtotal: {item.GetSubtotal():F2}");
            }

            Console.WriteLine($"Total: {GetTotal():F2}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product keyboard = new Product(1, "Keyboard", 1500m);
            Product mouse = new Product(2, "Mouse", 800m);
            Product headphones = new Product(3, "Headphones", 2000m);

            ShoppingCart cart = new ShoppingCart();

            cart.AddProduct(keyboard, 1);
            cart.AddProduct(mouse, 2);
            cart.AddProduct(headphones, 1);

            // The keyboard quantity becomes 3.
            cart.AddProduct(keyboard, 2);

            // Invalid additions leave the cart unchanged.
            cart.AddProduct(mouse, 0);
            cart.AddProduct(null, 1);

            Console.WriteLine();
            cart.PrintCart();

            Console.WriteLine();
            cart.RemoveProduct(2);
            cart.RemoveProduct(999);

            Console.WriteLine();
            cart.PrintCart();

            Console.WriteLine();
            ShoppingCart emptyCart = new ShoppingCart();
            emptyCart.PrintCart();
        }
    }
}