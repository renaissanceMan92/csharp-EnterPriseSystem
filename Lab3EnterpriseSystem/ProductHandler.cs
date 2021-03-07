using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab3EnterpriseSystem
{
    class ProductHandler // Klass som tillhandlahåller metoder för produkthantering och interaktion med externa filer.
    {
        public HashSet<Product> Products { get; set; } // En lista av alla produkter i mediashoppen.
        private readonly string filepath; // Representerar filvägen till CSV-filen där produkter lagras externt.
        public ProductHandler() // Konstruktor. Skapar en produktlista, laddar in innehållet från en VSC-fil och skapar produkter ur detta.
        {
            Products = new HashSet<Product>();
            Directory.SetCurrentDirectory(@"..\..\..");
            filepath = Path.Combine(Directory.GetCurrentDirectory(), "inv.csv");
            foreach (string row in File.ReadAllLines(filepath))
            {
                List<string> values = row.Split(',').Select(col => col).ToList();
                int.TryParse(values[0], out int quantity);
                int.TryParse(values[1], out int price);
                Products.Add(new Product(quantity, price, values[2], values[3]));
            }
        }
        public void UpdateInventory() // Sparar den nuvarande produktlistan på en CSV-fil.
        {
            using (StreamWriter sr = new StreamWriter(filepath))
            {
                foreach (Product product in Products)
                {
                    sr.WriteLine(Convert.ToString(product.Quantity) + "," + Convert.ToString(product.Price) + "," + product.ID + "," + product.Name);
                }
                sr.Close();
                sr.Dispose();
            }
        }
        public Product FindID(string id) // Identifierar och returnerar en produkt baserat på ID.
        {
            Product p = null;
            foreach (Product product in Products.Where(product => product.ID == id).Select(product => product))
            {
                p = product;
            }
            return p;
        }
        public override string ToString() // Returnerar en lista av produkter i läs-vänligt format.
        {
            string str = "\n";
            foreach (Product product in Products)
            {
                str += product.FullDescription;
            }
            return str;
        }
    }
}
