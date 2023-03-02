using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3_products
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            using (StreamReader s = new StreamReader("products.txt"))
            {
                string line;
                while ((line = s.ReadLine()) != null)
                {
                    string[] p = line.Split(',');
                    string name = p[0];
                    int price = int.Parse(p[1]);
                    products.Add(new Product { Name = name, Price = price });
                }
            }
            var groups = products.GroupBy(p => p.Price);
            foreach (var group in groups)
            {
                Console.WriteLine($"Група з цiною {group.Key} грн:");
                foreach (var product in group)
                {
                    Console.WriteLine($"  {product.Name}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
