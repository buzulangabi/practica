using System;
using System.Collections.Generic;
using System.Text;

namespace gabi_practica
{
   public class SuperCustomer:Customer
    {
       
        public decimal Discount { get; set; }

        public SuperCustomer(int id, string name, int age, string address, decimal discount):base(id,name,age,address)
        {
            this.Discount = discount;
        }
    }
}
