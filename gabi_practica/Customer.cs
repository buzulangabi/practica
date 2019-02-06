﻿using System;
using System.Collections.Generic;
using System.Text;

namespace gabi_practica
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    
        public Customer(int id, string name, int age, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Address = address;
        }
    }
}

