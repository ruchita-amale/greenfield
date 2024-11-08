﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM;
using POCO;
using OrderProcessing;
using Specification;
using Services;
namespace ECommerceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ruchi";
            customer1.LastName = "Amale";
            customer1.Contact = "420";
            customer1.Email = "Test";
            ICustomerService customerService = new CustomerService();
            customerService.Insert(customer1);
            Customer customer2 = new Customer();
            customer2.Id = 2;     
            customer2.FirstName = "Rutuja";
            customer2.LastName = "Yadav";
            customer2.Email = "Test";
            customer2.Contact = "1234";
            customerService.Insert(customer2);

            List<Customer> allCustomers = customerService.GetAll();
            foreach (Customer customer in allCustomers)
            {
                Console.WriteLine(customer.Id); 
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);       
                Console.WriteLine(customer.Contact);
                Console.WriteLine(customer.Email);

            }
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "ABC";
            product1.Description = "abc";
            product1.UnitPrice =1500;
            product1.Quantity = 2;
            product1.Image = "rgdfhgfjg";

            IProductService productService = new ProductService();
            productService.Insert(product1);
            List<Product> allProducts = productService.GetAll("products.dat");
            foreach (Product product in allProducts)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.UnitPrice);
                Console.WriteLine(product.Quantity);
                Console.WriteLine(product.Image);

            }

            Order Order1 = new Order();
            Order1.OrderId = 22;
            Order1.Status = "Delivered";
            Order1.Amount = 1000;
            Order1.Date = DateTime.Now;

            Order Order2 = new Order();
            Order2.OrderId = 23;
            Order2.Status = "Reject";
            Order2.Amount = 4522;
            Order2.Date = DateTime.Now;

            IOrderService OrderService = new OrderService();
            OrderService.Insert(Order1);
            OrderService.Insert(Order2);

            List<Order> allOrders = OrderService.GetAll();

            foreach (Order Order in allOrders)
            {
                Console.WriteLine(Order.OrderId);
                Console.WriteLine(Order.Date);
                Console.WriteLine(Order.Amount);
                Console.WriteLine(Order.Status);
            }
            Console.ReadLine();
        }
    }
}
