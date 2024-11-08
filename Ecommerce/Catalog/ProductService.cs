using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCO;
namespace Catalog
{
    public class ProductService : IProductService
    {
        private List<Product> products;
        public ProductService()
        {
            this.products = new List<Product>(); 
        }
        public bool Delete(int id)
        {
            Product theProduct= this.Get(id);
            return this.products.Remove(theProduct);
        }

        public Product Get(int id)
        {
            return new Product { Id = 1, Name = "Sunflower", Description = "Wedding Flower", UnitPrice = 12, Quantity = 5000, Image = "/Images/gerbera.jpg" };
            //foreach (Product product in _productList)
            //{
            //    if (product.Id == id) return product;
           // }
           // return null;
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "gerbera", Description = "Wedding Flower", UnitPrice = 12, Quantity = 5000, Image = "/Images/gerbera.jpg" });
            products.Add(new Product { Id = 2, Name = "rose", Description = "Wedding Flower", UnitPrice = 11, Quantity = 4000, Image = "/Images/rose.jfif" });
            products.Add(new Product { Id = 3, Name = "lily", Description = "Wedding Flower", UnitPrice = 2, Quantity = 5000, Image = "" });
            products.Add(new Product { Id = 4, Name = "jasmine", Description = "Wedding Flower", UnitPrice = 22, Quantity = 5000, Image = "" });
            products.Add(new Product { Id = 5, Name = "lotus", Description = "Wedding Flower", UnitPrice = 19, Quantity = 3000, Image = "" });

            return products;
        }

        public bool Insert(Product Product)
        {
            this.products.Add(Product);
            return true;
        }

        public bool Update(Product Product)
        {
            Product theProduct = this.Get(Product.Id);
            //this.products.Remove(theProduct); 
            //this.products.Add(Product);
            theProduct.Name = Product.Name;
            theProduct.Description = Product.Description;
            theProduct.UnitPrice = Product.UnitPrice;
            theProduct.Quantity = Product.Quantity;
            return true;

        }
    }
}
