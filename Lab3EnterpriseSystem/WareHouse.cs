using System.Collections.Generic;

namespace Lab3EnterpriseSystem
{
    class WareHouse // Klass som ger metoder för produkthantering i lagret.
    {
        private readonly IDictionary<Product, int> delivery; // En lista av produkter för leverans.
        public WareHouse() // Konstruktor. Skapar leveranslista.
        {
            delivery = new Dictionary<Product, int>();
        }
        public void RemoveProduct(Product p, ProductHandler ph) // Tar bort en produkt.
        {
            ph.Products.Remove(p);
        }
        public void MakeProduct(int quantity, int price, string id, string name, ProductHandler ph) // Skapar en ny produkt och lägger den i en produktlista.
        {
            ph.Products.Add(new Product(quantity, price, id, name));
        }
        public void AddToDelivery(int quantity, Product product) // Lägger till en produkt i en lista över köade leveranser.
        {
            delivery.Add(product, quantity);
        }
        public void ExecuteDelivery() // Verkställer leverans.
        {
            foreach (KeyValuePair<Product, int> item in delivery)
            {
                item.Key.Quantity += item.Value;
            }
            delivery.Clear();
        }
    }
}
