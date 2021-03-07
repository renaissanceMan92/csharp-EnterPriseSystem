using System;

namespace Lab3EnterpriseSystem
{
    partial class MediaShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTab = new System.Windows.Forms.TabControl();
            this.pointOfSale = new System.Windows.Forms.TabPage();
            this.SaleBox = new System.Windows.Forms.RichTextBox();
            this.AmountSale = new System.Windows.Forms.TextBox();
            this.IDsale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.performSale = new System.Windows.Forms.Button();
            this.inventoryPage = new System.Windows.Forms.TabPage();
            this.WarehouseTab = new System.Windows.Forms.TabControl();
            this.leftTab = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IDremove = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.IDName = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.createProduct = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rightTab = new System.Windows.Forms.TabPage();
            this.deliveryBtn = new System.Windows.Forms.Button();
            this.DeliveryBox = new System.Windows.Forms.RichTextBox();
            this.IDdelivery = new System.Windows.Forms.TextBox();
            this.AmountDelivery = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddDelivery = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.InventoryBox = new System.Windows.Forms.RichTextBox();
            this.MainTab.SuspendLayout();
            this.pointOfSale.SuspendLayout();
            this.inventoryPage.SuspendLayout();
            this.WarehouseTab.SuspendLayout();
            this.leftTab.SuspendLayout();
            this.rightTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.pointOfSale);
            this.MainTab.Controls.Add(this.inventoryPage);
            this.MainTab.Location = new System.Drawing.Point(296, 3);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(283, 342);
            this.MainTab.TabIndex = 0;
            // 
            // pointOfSale
            // 
            this.pointOfSale.Controls.Add(this.SaleBox);
            this.pointOfSale.Controls.Add(this.AmountSale);
            this.pointOfSale.Controls.Add(this.IDsale);
            this.pointOfSale.Controls.Add(this.label3);
            this.pointOfSale.Controls.Add(this.label2);
            this.pointOfSale.Controls.Add(this.label1);
            this.pointOfSale.Controls.Add(this.addToCart);
            this.pointOfSale.Controls.Add(this.performSale);
            this.pointOfSale.Location = new System.Drawing.Point(4, 22);
            this.pointOfSale.Name = "pointOfSale";
            this.pointOfSale.Padding = new System.Windows.Forms.Padding(3);
            this.pointOfSale.Size = new System.Drawing.Size(275, 316);
            this.pointOfSale.TabIndex = 0;
            this.pointOfSale.Text = "Försäljning";
            this.pointOfSale.UseVisualStyleBackColor = true;
            // 
            // SaleBox
            // 
            this.SaleBox.Location = new System.Drawing.Point(7, 131);
            this.SaleBox.Name = "SaleBox";
            this.SaleBox.Size = new System.Drawing.Size(247, 151);
            this.SaleBox.TabIndex = 12;
            this.SaleBox.Text = "";
            // 
            // AmountSale
            // 
            this.AmountSale.Location = new System.Drawing.Point(101, 76);
            this.AmountSale.Name = "AmountSale";
            this.AmountSale.Size = new System.Drawing.Size(60, 20);
            this.AmountSale.TabIndex = 10;
            // 
            // IDsale
            // 
            this.IDsale.Location = new System.Drawing.Point(101, 47);
            this.IDsale.Name = "IDsale";
            this.IDsale.Size = new System.Drawing.Size(60, 20);
            this.IDsale.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Välj antal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Markerad vara:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Välj vara ur sortimentet";
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(19, 102);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(121, 23);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Lägg till i varukorgen";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.AddToSale_Click);
            // 
            // performSale
            // 
            this.performSale.Location = new System.Drawing.Point(7, 287);
            this.performSale.Name = "performSale";
            this.performSale.Size = new System.Drawing.Size(88, 23);
            this.performSale.TabIndex = 2;
            this.performSale.Text = "Utför köp";
            this.performSale.UseVisualStyleBackColor = true;
            this.performSale.Click += new System.EventHandler(this.ConfirmSale_Click);
            // 
            // inventoryPage
            // 
            this.inventoryPage.Controls.Add(this.WarehouseTab);
            this.inventoryPage.Location = new System.Drawing.Point(4, 22);
            this.inventoryPage.Name = "inventoryPage";
            this.inventoryPage.Padding = new System.Windows.Forms.Padding(3);
            this.inventoryPage.Size = new System.Drawing.Size(275, 316);
            this.inventoryPage.TabIndex = 1;
            this.inventoryPage.Text = "Lagerhantering";
            this.inventoryPage.UseVisualStyleBackColor = true;
            // 
            // WarehouseTab
            // 
            this.WarehouseTab.Controls.Add(this.leftTab);
            this.WarehouseTab.Controls.Add(this.rightTab);
            this.WarehouseTab.Location = new System.Drawing.Point(3, 9);
            this.WarehouseTab.Name = "WarehouseTab";
            this.WarehouseTab.SelectedIndex = 0;
            this.WarehouseTab.Size = new System.Drawing.Size(261, 304);
            this.WarehouseTab.TabIndex = 39;
            // 
            // leftTab
            // 
            this.leftTab.Controls.Add(this.label18);
            this.leftTab.Controls.Add(this.label16);
            this.leftTab.Controls.Add(this.label7);
            this.leftTab.Controls.Add(this.IDremove);
            this.leftTab.Controls.Add(this.ID);
            this.leftTab.Controls.Add(this.IDName);
            this.leftTab.Controls.Add(this.Quantity);
            this.leftTab.Controls.Add(this.Price);
            this.leftTab.Controls.Add(this.deleteProduct);
            this.leftTab.Controls.Add(this.createProduct);
            this.leftTab.Controls.Add(this.label14);
            this.leftTab.Controls.Add(this.label13);
            this.leftTab.Controls.Add(this.label11);
            this.leftTab.Controls.Add(this.label10);
            this.leftTab.Location = new System.Drawing.Point(4, 22);
            this.leftTab.Name = "leftTab";
            this.leftTab.Padding = new System.Windows.Forms.Padding(3);
            this.leftTab.Size = new System.Drawing.Size(253, 278);
            this.leftTab.TabIndex = 0;
            this.leftTab.Text = "Skapa/radera produkt...";
            this.leftTab.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(71, 209);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "TA BORT PRODUKT";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(71, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "SKAPA NY PRODUKT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Skriv in ID:";
            // 
            // IDremove
            // 
            this.IDremove.Location = new System.Drawing.Point(74, 239);
            this.IDremove.Name = "IDremove";
            this.IDremove.Size = new System.Drawing.Size(64, 20);
            this.IDremove.TabIndex = 40;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(63, 38);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(65, 20);
            this.ID.TabIndex = 36;
            // 
            // IDName
            // 
            this.IDName.Location = new System.Drawing.Point(63, 64);
            this.IDName.Name = "IDName";
            this.IDName.Size = new System.Drawing.Size(65, 20);
            this.IDName.TabIndex = 34;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(63, 90);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(65, 20);
            this.Quantity.TabIndex = 33;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(63, 115);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(65, 20);
            this.Price.TabIndex = 32;
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(154, 237);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(50, 23);
            this.deleteProduct.TabIndex = 41;
            this.deleteProduct.Text = "Ta bort";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // createProduct
            // 
            this.createProduct.Location = new System.Drawing.Point(22, 161);
            this.createProduct.Name = "createProduct";
            this.createProduct.Size = new System.Drawing.Size(119, 26);
            this.createProduct.TabIndex = 38;
            this.createProduct.Text = "Lägg till";
            this.createProduct.UseVisualStyleBackColor = true;
            this.createProduct.Click += new System.EventHandler(this.CreateProduct_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Namn:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Antal:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Pris:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "ID:";
            // 
            // rightTab
            // 
            this.rightTab.Controls.Add(this.deliveryBtn);
            this.rightTab.Controls.Add(this.DeliveryBox);
            this.rightTab.Controls.Add(this.IDdelivery);
            this.rightTab.Controls.Add(this.AmountDelivery);
            this.rightTab.Controls.Add(this.label9);
            this.rightTab.Controls.Add(this.label8);
            this.rightTab.Controls.Add(this.AddDelivery);
            this.rightTab.Controls.Add(this.label15);
            this.rightTab.Controls.Add(this.label19);
            this.rightTab.Location = new System.Drawing.Point(4, 22);
            this.rightTab.Name = "rightTab";
            this.rightTab.Padding = new System.Windows.Forms.Padding(3);
            this.rightTab.Size = new System.Drawing.Size(253, 278);
            this.rightTab.TabIndex = 2;
            this.rightTab.Text = "Ny leverans...";
            this.rightTab.UseVisualStyleBackColor = true;
            // 
            // deliveryBtn
            // 
            this.deliveryBtn.Location = new System.Drawing.Point(10, 249);
            this.deliveryBtn.Name = "deliveryBtn";
            this.deliveryBtn.Size = new System.Drawing.Size(121, 23);
            this.deliveryBtn.TabIndex = 55;
            this.deliveryBtn.Text = "Registrera leverans";
            this.deliveryBtn.UseVisualStyleBackColor = true;
            this.deliveryBtn.Click += new System.EventHandler(this.ConfirmDelivery_Click);
            // 
            // DeliveryBox
            // 
            this.DeliveryBox.Location = new System.Drawing.Point(10, 124);
            this.DeliveryBox.Name = "DeliveryBox";
            this.DeliveryBox.Size = new System.Drawing.Size(229, 119);
            this.DeliveryBox.TabIndex = 54;
            this.DeliveryBox.Text = "";
            // 
            // IDdelivery
            // 
            this.IDdelivery.Location = new System.Drawing.Point(41, 30);
            this.IDdelivery.Name = "IDdelivery";
            this.IDdelivery.Size = new System.Drawing.Size(65, 20);
            this.IDdelivery.TabIndex = 49;
            // 
            // AmountDelivery
            // 
            this.AmountDelivery.Location = new System.Drawing.Point(41, 56);
            this.AmountDelivery.Name = "AmountDelivery";
            this.AmountDelivery.Size = new System.Drawing.Size(65, 20);
            this.AmountDelivery.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Index av nya leveransartiklar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Lägg till varor:";
            // 
            // AddDelivery
            // 
            this.AddDelivery.Location = new System.Drawing.Point(41, 82);
            this.AddDelivery.Name = "AddDelivery";
            this.AddDelivery.Size = new System.Drawing.Size(65, 23);
            this.AddDelivery.TabIndex = 51;
            this.AddDelivery.Text = "Lägg till";
            this.AddDelivery.UseVisualStyleBackColor = true;
            this.AddDelivery.Click += new System.EventHandler(this.AddToDelivery_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "Antal:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "ID:";
            // 
            // InventoryBox
            // 
            this.InventoryBox.Location = new System.Drawing.Point(12, 21);
            this.InventoryBox.Name = "InventoryBox";
            this.InventoryBox.Size = new System.Drawing.Size(278, 320);
            this.InventoryBox.TabIndex = 4;
            this.InventoryBox.Text = "";
            // 
            // MediaShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 347);
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.InventoryBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MediaShop";
            this.Text = "ERP";
            this.MainTab.ResumeLayout(false);
            this.pointOfSale.ResumeLayout(false);
            this.pointOfSale.PerformLayout();
            this.inventoryPage.ResumeLayout(false);
            this.WarehouseTab.ResumeLayout(false);
            this.leftTab.ResumeLayout(false);
            this.leftTab.PerformLayout();
            this.rightTab.ResumeLayout(false);
            this.rightTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage pointOfSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox InventoryBox;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Button performSale;
        private System.Windows.Forms.TabPage inventoryPage;
        private System.Windows.Forms.RichTextBox SaleBox;
        private System.Windows.Forms.TextBox AmountSale;
        private System.Windows.Forms.TextBox IDsale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl WarehouseTab;
        private System.Windows.Forms.TabPage leftTab;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IDremove;
        private System.Windows.Forms.TextBox ID;
        private new System.Windows.Forms.TextBox IDName;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button createProduct;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage rightTab;
        private System.Windows.Forms.Button deliveryBtn;
        private System.Windows.Forms.RichTextBox DeliveryBox;
        private System.Windows.Forms.TextBox IDdelivery;
        private System.Windows.Forms.TextBox AmountDelivery;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddDelivery;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
    }
}

