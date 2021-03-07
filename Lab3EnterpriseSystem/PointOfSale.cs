using System.Collections.Generic;

namespace Lab3EnterpriseSystem
{
    class PointOfSale // Representerar kassasystemet och dess metoder.
    {
        private readonly IDictionary<Product, int> sale; // En lista av produkter för försäljning.
        public PointOfSale() // konstruktor. Skapar en lista för försäljningar.
        {
            sale = new Dictionary<Product, int>();
        }
        public void AddToSale(int quantity, Product product) // Lägger till en produkt i en lista över köade försäljningar.
        {
            sale.Add(product, quantity);
        }
        public void ExecuteSale() // Utför försäljning och sparar i CSV-filen.
        {
            foreach (KeyValuePair<Product, int> item in sale)
            {
                item.Key.Quantity -= item.Value;
            }
            sale.Clear();
        }
    }
}
