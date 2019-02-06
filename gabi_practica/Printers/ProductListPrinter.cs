using System;
using System.Collections.Generic;
using System.Text;

namespace gabi_practica.printers
{
    public class ProductListPrinter
    {
        public void PrintProducts(List<Product> list)
        {
            foreach (Product product in list)
            {
                string customerString = ProductToString(product);
                Console.WriteLine(customerString);
            }
        }

        private string ProductToString(Product product)
        {
            string p = $"Id: {product.ID}; Price: {product.Price}; Name: {product.Name}; Type: {product.Type}";
            return p;
        }
    }
}
