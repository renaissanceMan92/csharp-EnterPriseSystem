
namespace Lab3EnterpriseSystem
{
    class Product // Representerar produkterna i mediashoppen (böcker, filmer, etc).
    {
        public string ID { get; }
        public int Price { get; }
        public string Name { get; }
        public int Quantity { get; set; }
        public string FullDescription => $"{Name}, pris:  {Price} kr, ID:  {ID}, antal:  {Quantity} \n";
        public Product(int quantity, int price, string id, string name) // Konstruktor. Identifierar produktobjektets attribut-värden.
        {
            ID = id;
            Price = price;
            Name = name;
            Quantity = quantity;
        }

    }
}
