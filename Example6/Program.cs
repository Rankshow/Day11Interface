using Example6;
using System.Collections.Generic;

List<Customer> customer = new List<Customer>();

// ! creating each cutomers
Customer cust1 = new Customer();
cust1.Name = "Mawthew";
cust1.Email = "uwqomaobinne@gmail.com";
cust1.Country = "Canada";

Customer cust2 = new Customer();
cust2.Name = "Ohilimone";
cust2.Email = "Ohiolem@gmail.com";
cust2.Country = "Japan";

// ! Adding our customer to our list 
customer.Add(cust1);
customer.Add(cust2);

foreach(Customer cust in customer)
{
    Console.WriteLine($"========++++++++========++++++=======");
    Console.WriteLine($"Cutomer id : {cust.CustomerId}");
    Console.WriteLine($"Cutomer Name : {cust.Name}");
    Console.WriteLine($"Cutomer Email : {cust.Email}");
    Console.WriteLine($"Cutomer Country : {cust.Country}");
}