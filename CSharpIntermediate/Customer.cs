﻿using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders = new List<Order>();

        public Customer(int id)
            
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}