﻿using Microsoft.EntityFrameworkCore;
using Shop.Models;
using System.Collections.Generic;

namespace Shop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Pood> Pood { get; set; }
        public DbSet<Graafik> Graafik { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

    }
}