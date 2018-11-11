using ApiODataMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiODataMS.Data
{
    public class ProductData
    {
        //public IList<Product> GetList()
        //{
        //    return ListProducts().ToList();           
        //}

        public static void AddList(Product product)
        {
            list.Add(new Product { ID = product.ID, Name = product.Name, Price = product.Price });
        }

        public static Product GetById(int id)
        {
            return list.Where(p => p.ID == id).SingleOrDefault();
        }

        public static IEnumerable<Product> GetList()
        {
            //var list = new List<Product>();
            //list.Add(new Product() { Id = 1, Name = "Batata", Price = 2.8, Category = "Legumes" });
            //list.Add(new Product() { Id = 2, Name = "Cenoura", Price = 3.0, Category = "Legumes" });
            //list.Add(new Product() { Id = 3, Name = "Beterraba", Price = 2.5, Category = "Legumes" });
            //list.Add(new Product() { Id = 4, Name = "Quiabo", Price = 4.9, Category = "Legumes" });

            return list;
        }

        private static List<Product> list = new List<Product>()
        {
            new Product() { ID = 1, Name = "Batata", Price = 2.8 },
            new Product() { ID = 2, Name = "Cenoura", Price = 3.0 },
            new Product() { ID = 3, Name = "Beterraba", Price = 2.5 },
            new Product() { ID = 4, Name = "Quiabo", Price = 4.9 },
        };
    }
}
