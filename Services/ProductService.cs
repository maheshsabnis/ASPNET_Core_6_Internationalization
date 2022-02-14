using Core6_Internationalization.Models;

namespace Core6_Internationalization.Services
{
    public class ProductService
    {
        private Products products;
        public ProductService()
        {
            products = new Products();
        }
        public List<Product> GetProducts()
        {
            return products;
        }

        public List<Product> AddProducts(Product prd)
        {
            products.Add(prd);
            return products;
        }

    }
}
