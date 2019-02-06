using System;
using System.Collections.Generic;
using System.Text;

namespace gabi_practica.printers
{
    public class CustomerListPrinter
    {
        public void PrintCustomers(List<Customer> list)
        {
            foreach (Customer customer in list)
            {
                Console.WriteLine(CustomerToString(customer));
                

            }
        }

        private string CustomerToString(Customer customer)
        {
            string s = $"Id: {customer.Id}; Name: {customer.Name}; Age: {customer.Age}; Address: {customer.Address}";
            return s;
        
        }


    }
}
