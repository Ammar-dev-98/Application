using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [DisplayName("Order ID")]
        public int OrderId { get; set; }
        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        //public static List<Product> GetAllProduct()
        //{
        //    List<Product> products = new List<Product>() {
        //        new Product() { ProductId=1, ProductName="a", OrderId=11, Quantity=10 },
        //        new Product() { ProductId=2, ProductName="b", OrderId=22, Quantity=15 },
        //        new Product() { ProductId=3, ProductName="c", OrderId=33, Quantity=70 },
        //        new Product() { ProductId=4, ProductName="d", OrderId=44, Quantity=13 }
        //    };
        //    return products;
        //}

        //public static List<Product> AddProduct(Product product, List<Product> productList)
        //{
        //    productList.Add(product);
        //    return productList;
        //}

        //public static List<Product> DeleteProduct(int productId, List<Product> productList)
        //{
        //    var result = productList.Remove(productList.Find((elem) => elem.ProductId == productId));
        //    if (result)
        //    {
        //        Console.WriteLine("Removed");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No such record exist");
        //    }
        //    return productList;
        //}

        //public static List<Product> EditProduct(Product product, List<Product> productList)
        //{
        //    var result = productList.Remove(productList.Find((elem) => elem.ProductId == product.ProductId));
        //    if (result)
        //    {
        //        productList.Add(product);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Could not be edited");
        //    }
        //    return productList;
        //}

    }
}