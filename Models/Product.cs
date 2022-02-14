using System.ComponentModel.DataAnnotations;
namespace Core6_Internationalization.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Product Id is Required")]
        [Display(Name = "ProductId")]
        public int? ProductId { get; set; }
        [Required(ErrorMessage = "Product Name is Required")]
        public string? ProductName { get; set; }
        [Required(ErrorMessage = "Category Name is Required")]
        public string CategoryName { get; set; } =  string.Empty;
        [Required(ErrorMessage = "Manufacturer is Required")]
        public string Manufacturer { get; set; } = String.Empty;
        [Required(ErrorMessage = "Price is Required")]
        public int? Price { get; set; }
    }

    public class Products : List<Product>
    {
        public Products()
        {
            Add(new Product() { ProductId=101,ProductName="Laptop",CategoryName="Electronics",Manufacturer="MS-Electronics", Price=456000 });
            Add(new Product() { ProductId = 102, ProductName = "Iron", CategoryName = "Electrical", Manufacturer = "MS-Electical", Price = 5000 });
            Add(new Product() { ProductId = 103, ProductName = "Biscuts", CategoryName = "Food", Manufacturer = "MS-Food", Price = 60 });
            Add(new Product() { ProductId = 104, ProductName = "Router", CategoryName = "Electronics", Manufacturer = "LS-Electronics", Price = 5600 });
            Add(new Product() { ProductId = 105, ProductName = "Mixer", CategoryName = "Electrical", Manufacturer = "LS-Electrical", Price = 4000 });
            Add(new Product() { ProductId = 106, ProductName = "Chips", CategoryName = "Food", Manufacturer = "LS-Food", Price = 40 });
            Add(new Product() { ProductId = 107, ProductName = "Mouse", CategoryName = "Electronics", Manufacturer = "TS-Electronics", Price = 500 });
            Add(new Product() { ProductId = 108, ProductName = "Dryer", CategoryName = "Electrical", Manufacturer = "TS-Electrical", Price = 4600 });
            Add(new Product() { ProductId = 109, ProductName = "Soya Milk", CategoryName = "Food", Manufacturer = "TS-Food", Price = 45 });
            Add(new Product() { ProductId = 110, ProductName = "Keyboard", CategoryName = "Electronics", Manufacturer = "MS-Electronics", Price = 1600 });
            Add(new Product() { ProductId = 111, ProductName = "Charger", CategoryName = "Electrical", Manufacturer = "LS-Electrical", Price = 600 });
            Add(new Product() { ProductId = 112, ProductName = "Yoghurt", CategoryName = "Food", Manufacturer = "TS-Foods", Price = 40 });
        }
    }

}
