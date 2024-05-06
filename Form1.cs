using System.Collections.ObjectModel;

namespace ComputerSales
{
    public partial class Form1 : Form
    {
        private Category[] categories = [
            new Category() { Name = "Процессоры" },
            new Category() { Name = "Видеокарты" },
            new Category() { Name = "Материнские платы" },
            new Category() { Name = "Оперативная память" },
            new Category() { Name = "Накопители" },
        ];
        private ObservableCollection<Product> products;
        private decimal TotalToPay
        {
            get
            {
                return userCartListBox.Items.OfType<Product>().Sum(e => e.Price);
            }
        }
        public Form1()
        {
            InitializeComponent();
            InitializeProducts();

            categoriesComboBox.DataSource = categories;
            categoriesComboBox.DisplayMember = "Name";
            categoriesComboBox.ValueMember = "Id";

            productsListBox.SelectionMode = SelectionMode.MultiExtended;

            productsListBox.DataSource = products.Where(e => e.Category.Id.Equals(categoriesComboBox.SelectedValue)).ToList();
        }
        private void categoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productsListBox.DataSource = products.Where(e => e.Category.Id.Equals(categoriesComboBox.SelectedValue)).ToList();
        }
        private void RemoveItemButton_MouseEnter(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.ForeColor = Color.White;
        }

        private void RemoveItemButton_MouseLeave(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.ForeColor = Color.Black;
        }

        private void toCartButton_Click(object sender, EventArgs e)
        {
            var selectedProducts = productsListBox.SelectedItems.OfType<Product>().ToArray();
            if (selectedProducts != null) { 
                userCartListBox.Items.AddRange(selectedProducts);
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            var selectedProducts = productsListBox.SelectedItems.OfType<Product>().ToArray();
            if (selectedProducts != null)
            {
                ComputerSalesInfoForm infoForm = new ComputerSalesInfoForm(selectedProducts);
                var result = infoForm.ShowDialog();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int index = userCartListBox.SelectedIndex;
            if (index != -1)
            {
                userCartListBox.Items.RemoveAt(index);
            }
        }

        private void finishOrderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"К оплате: {TotalToPay}$", "Оплата", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void InitializeProducts()
        {
            products = [
                new Product() { Name = "GeForce RTX 4060", Category = categories[1], Price = 354.32m, Count = 76 },
                new Product() { Name = "Intel Core i9-12900K", Category = categories[0], Price = 549.99m, Count = 43 },
                new Product() { Name = "AMD Ryzen 9 5950X", Category = categories[0], Price = 799.99m, Count = 28 },
                new Product() { Name = "ASUS ROG Strix Z690-E Gaming WiFi", Category = categories[2], Price = 389.99m, Count = 15 },
                new Product() { Name = "G.SKILL Trident Z RGB Series 32GB (2 x 16GB)", Category = categories[3], Price = 189.99m, Count = 62 },
                new Product() { Name = "Samsung 980 PRO 1TB PCIe NVMe Gen4 Internal Gaming SSD", Category = categories[4], Price = 199.99m, Count = 37 },
                new Product() { Name = "AMD Radeon RX 7900 XT", Category = categories[1], Price = 649.99m, Count = 52 },
                new Product() { Name = "MSI MEG Z590 ACE Gold Edition", Category = categories[2], Price = 479.99m, Count = 9 },
                new Product() { Name = "Corsair Vengeance LPX 16GB (2 x 8GB)", Category = categories[3], Price = 89.99m, Count = 84 },
                new Product() { Name = "Western Digital WD_BLACK SN850 1TB NVMe Internal Gaming SSD", Category = categories[4], Price = 179.99m, Count = 41 },
                new Product() { Name = "NVIDIA GeForce RTX 4080", Category = categories[1], Price = 799.99m, Count = 64 },
                new Product() { Name = "AMD Ryzen 7 5800X", Category = categories[0], Price = 399.99m, Count = 37 },
                new Product() { Name = "ASUS ROG Maximus XIV Extreme Glacial", Category = categories[2], Price = 1299.99m, Count = 12 },
                new Product() { Name = "Crucial Ballistix 16GB (2 x 8GB)", Category = categories[3], Price = 79.99m, Count = 92 },
                new Product() { Name = "Seagate FireCuda 520 2TB NVMe Internal Gaming SSD", Category = categories[4], Price = 299.99m, Count = 23 },
                new Product() { Name = "NVIDIA GeForce RTX 4070", Category = categories[1], Price = 549.99m, Count = 58 },
                new Product() { Name = "Intel Core i7-12700K", Category = categories[0], Price = 349.99m, Count = 51 }
            ];
        }

        
    }

    public class Product
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public override string ToString()
        {
            return $"{Name} | Цена - {Price}$";
        }
    }

    public class Category
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

   
}
