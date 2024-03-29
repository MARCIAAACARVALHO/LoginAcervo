﻿using Microsoft.EntityFrameworkCore;

namespace LoginAcervo.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
