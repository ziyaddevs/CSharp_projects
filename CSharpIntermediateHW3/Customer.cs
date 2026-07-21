using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        
        
        public Customer()
        {
            Orders = new List<Order>();   
        }

        public Customer(int Id)
        : this()
        {
            this.Id = Id;
        }       

        public Customer(int Id, string Name)
        : this(Id)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}