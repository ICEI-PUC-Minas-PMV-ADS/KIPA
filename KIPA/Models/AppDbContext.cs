﻿using Microsoft.EntityFrameworkCore;

namespace KIPA.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cadastro> Cadastros { get; set;}
    }

    }
