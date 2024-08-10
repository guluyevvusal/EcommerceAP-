﻿using EcommerceApi.Domen.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomerceApi.Persistence.Context
{
    public class EcommerceDbContext : DbContext
    {
       
       
        public EcommerceDbContext(DbContextOptions options) : base(options) { }
       


        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        
    }
}
