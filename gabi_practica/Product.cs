﻿using System;
using System.Collections.Generic;
using System.Text;

namespace gabi_practica
{
    public class Product
    {
        public int ID { get; set; }
       
        public decimal Price { get; set; }

        public ProductType Type { get; set; }

        public string Name { get; set; }

        public Product(int id, decimal price, string name, ProductType type)
        {
            this.ID = id;
            this.Price = price;
            this.Name = name;
            this.Type = type;
        }
    }
}
