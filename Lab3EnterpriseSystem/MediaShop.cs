using System;
using System.Windows.Forms;

namespace Lab3EnterpriseSystem
{
    public partial class MediaShop : Form // Presentationslagret i programmet. Utgör ett direkt gränssnitt  mot GUIt.
    {
        private readonly WareHouse wh;
        private readonly PointOfSale pos;
        private readonly ProductHandler ph;
        public MediaShop() // Konstruktor. Initierar GUIt, lagerhanteringsobjekt, kassaobjekt och produkthanteringsobjekt. Laddar in lagerlista.
        {
            InitializeComponent();
            wh = new WareHouse();
            pos = new PointOfSale();
            ph = new ProductHandler();
            InventoryBox.Text = "Fullständigt lager \n" + ph.ToString();
        }

        private void CreateProduct_Click(object sender, EventArgs e) // validerar användar-input och anropar därefter wh.createproduct.
        {
            string id = ID.Text;
            string name = IDName.Text;
            int.TryParse(Quantity.Text, out int quantity);
            int.TryParse(Price.Text, out int price);
            if (quantity >= 1 && price >= 1 && !string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(name) && ph.FindID(id) == null)
            {
                wh.MakeProduct(quantity, price, id, name, ph);
                ph.UpdateInventory();
                MessageBox.Show("Ny produkt har skapats!");
                InventoryBox.Text = "Fullständigt lager \n" + ph.ToString();
                Quantity.Text = string.Empty;
                Price.Text = string.Empty;
                ID.Text = string.Empty;
                IDName.Text = string.Empty;
            }
            else MessageBox.Show("Ogiltig input!");
        }

        private void DeleteProduct_Click(object sender, EventArgs e) // validerar användar-input och anropar därefter wh.deleteproduct.
        {
            Product product = ph.FindID(IDremove.Text);
            if (product != null)
            {
                if (product.Quantity != 0)
                {
                    DialogResult res = MessageBox.Show("Radera produkt?", "Radera", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        wh.RemoveProduct(product, ph);
                        ph.UpdateInventory();
                    }
                }
                else
                {
                    wh.RemoveProduct(product, ph);
                    ph.UpdateInventory();
                }
            }
            else MessageBox.Show("Den här produkten finns inte!");
            InventoryBox.Text = "Fullständigt lager \n" + ph.ToString();
            IDremove.Text = string.Empty;
        }

        private void AddToDelivery_Click(object sender, EventArgs e) // validerar användar-input och anropar därefter wh.addtodelivery.
        {
            Product product = ph.FindID(IDdelivery.Text);
            if (product != null)
            {
                if (int.TryParse(AmountDelivery.Text, out int quantity) != false && quantity >= 1)
                {
                    try
                    {
                        wh.AddToDelivery(quantity, product);
                        DeliveryBox.AppendText(product.FullDescription + "Antal: " + quantity + ".\n");
                    }
                    catch (Exception) { MessageBox.Show("Du får inte lägga samma order två gånger!"); }
                }
                else MessageBox.Show("Ogiltig input!");
            }
            else MessageBox.Show("Produkten finns inte!");
            IDdelivery.Text = string.Empty;
            AmountDelivery.Text = string.Empty;
        }

        private void AddToSale_Click(object sender, EventArgs e) // validerar användar-input och anropar därefter pos.addtosale.
        {
            Product product = ph.FindID(IDsale.Text);
            if (product != null)
            {
                if (int.TryParse(AmountSale.Text, out int quantity) != false && quantity >= 1 && product.Quantity >= quantity)
                {
                    try
                    {
                        pos.AddToSale(quantity, product);
                        SaleBox.AppendText(product.FullDescription + "Antal: " + quantity + ".\n");
                    }
                    catch (Exception) { MessageBox.Show("Du får inte lägga samma order två gånger!"); }
                }
                else MessageBox.Show("Ogiltig input!");
            }
            else MessageBox.Show("Produkten finns inte!");
            IDsale.Text = string.Empty;
            AmountSale.Text = string.Empty;
        }

        private void ConfirmDelivery_Click(object sender, EventArgs e) // Verkställer en leverans mha wh.executedelivery.
        {
            wh.ExecuteDelivery();
            DeliveryBox.Text = string.Empty;
            InventoryBox.Text = "Fullständigt lager \n" + ph.ToString();
            MessageBox.Show("Leverans har registrerats!");
            ph.UpdateInventory();
        }

        private void ConfirmSale_Click(object sender, EventArgs e) // Verkställer en leverans mha pos.executesale.
        {
            pos.ExecuteSale();
            SaleBox.Text = string.Empty;
            InventoryBox.Text = "Fullständigt lager \n" + ph.ToString();
            MessageBox.Show("Försäljning har registrerats!");
            ph.UpdateInventory();
        }
    }
}
