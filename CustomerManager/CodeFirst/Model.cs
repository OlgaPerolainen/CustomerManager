﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("MyShop")
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        
    }
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public byte[] Photo { get; set; }

        public override string ToString()
        {
            string s = Name + ", электронный адрес: " +Email;
            return s;
        }

        public virtual List<Order> Orders { get; set; }
        public Customer()
        {
            Orders = new List<Order>();
        }
    }
    public class Order
    {
        public int OrderID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }

        public Customer Customer { get; set; }

        public override string ToString()
        {
            string s = ProductName + " " + Quantity + "шт., дата: " + PurchaseDate;
            return s;
        }
    }
}
