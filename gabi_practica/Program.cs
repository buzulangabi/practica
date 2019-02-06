using System;
using System.Collections.Generic;
using System.Linq;
using gabi_practica.printers;

namespace gabi_practica
{
    class Program
    {
        const int MaxAge = 18;

        static void Main(string[] args)
        {
           CustomerListPrinter customerListPrinter= new CustomerListPrinter();


            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(123, "Cristi", 24, "Buiucani"));
            customers.Add(new Customer(321, "Cristi", 18, "Germania"));
            customers.Add(new Customer(456, "Anastasia", 23, "Ialoveni"));
            customers.Add(new Customer(789, "Maya", 28, "Valea Perjei"));
            customers.Add(new Customer(963, "Valeria", 25, "Taraclia"));

            customerListPrinter.PrintCustomers(customers);
            Console.WriteLine();

            List<Customer> sortedList = customers.OrderBy(o => o.Name).ToList();

            customerListPrinter.PrintCustomers(sortedList);



            Console.WriteLine("Introduceti numele ");
            string name=Console.ReadLine(); 
            if (name.Length == 0)
            {
                Console.WriteLine("Numele este invalid");
                Console.ReadLine();
                return;
            }

            List<Customer> matchingCustomers= new List<Customer>();

            foreach(Customer customer in customers )
            {
                if (customer.Name == name)
                {
                    matchingCustomers.Add(customer);
                }
            }
            customerListPrinter.PrintCustomers(matchingCustomers);

            // Console.WriteLine("Introduceti ID-ul ");
            // int id = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Introduceti pretul ");
            // Decimal price = Decimal.Parse(Console.ReadLine());

            //if (price<=0)
            //{
            //    Console.WriteLine("Nu se accepta pret negativ");
            //    Console.ReadLine();
            //    return;
            //}


            // Console.WriteLine("Introduceti numele ");
            // string name = Console.ReadLine();

            // Console.WriteLine("Introduceti tipul produsului");
            // string type = Console.ReadLine();
            // ProductType p = (ProductType)Enum.Parse(typeof(ProductType), type, true);


            // Product product = new Product(id, price, name, p);
            // Console.WriteLine($"ID {product.ID}; Price {product.Price}; Name {product.Name}; ProductType {product.Type}");
            // Console.WriteLine("Hello World!"); 

            //int age = Convert.ToInt32(Console.ReadLine());
            

            //if (age < MaxAge)
            //{
            //    Console.WriteLine("Nu se accepta varsta mai mica de 18 ani");
            //    Console.ReadLine();
            //    return;
            //}
             
            //Console.WriteLine("Introduceti Id-ul ");
            //int idcustomer = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Introduceti numele ");
            //string namecustomer = Console.ReadLine();
            //Console.WriteLine("Introduceti varsta ");


            //Console.WriteLine("Introduceti adresa ");
            //string customeraddress = Console.ReadLine();

            Console.ReadLine();
        }
    }
}
