using System;
using System.Collections.Generic;
using Products.Entities;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> prod = new List<Product>();

            Console.Write("Enter the number of products: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char op = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if(op == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    prod.Add(new ImportedProduct(name, price, customsFee));
                }
                else if(op == 'u')
                {
                    Console.Write("Manufacture date: ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());
                    prod.Add(new UsedProduct(name, price, manufacture));
                }
                else
                    prod.Add(new Product(name, price));
            }

            Console.WriteLine();
            Console.WriteLine("Price Tags: ");
            foreach(Product product in prod)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}