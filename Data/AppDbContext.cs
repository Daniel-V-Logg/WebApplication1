﻿using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {

        
    
            public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options) { }

            public DbSet<User> Users { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<Transaction> Transactions { get; set; }
        }
    }
