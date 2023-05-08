using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class StoreManagement
    {
        private List<Product> products = new List<Product>();

        public void AddProduct()
        {
            Console.Write("Enter Product ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            double price = double.Parse(Console.ReadLine());

            Product product = new Product { Id = id, Name = name, Price = price };
            products.Add(product);

            Console.WriteLine("Product added successfully");
        }

        public void DisplayProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products available");
            }
            else
            {
                Console.WriteLine("Product ID\tProduct Name\tPrice");
                foreach (Product product in products)
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}", product.Id, product.Name,"$"+product.Price);
                }
            }
        }

        public void DeleteProduct(string id)
        {
            Product product = products.Find(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine("Product deleted successfully");
            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("1. Add product records");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by ID");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice (1-4): ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        DisplayProducts();
                        break;
                    case 3:
                        Console.Write("Enter Product ID to delete: ");
                        string id = Console.ReadLine();
                        DeleteProduct(id);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
