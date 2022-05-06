using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;

namespace DataLayer
    {
    public class GloNetDbContext : DbContext
        {
        public string connectionString = @"Server=DESKTOP-ADCBR92\SQLEXPRESS;Database=GloNetDb;Trusted_Connection=True;";
        public GloNetDbContext()
            {

            }

        public GloNetDbContext(DbContextOptions options): base(options)
            {

            }

        public GloNetDbContext(string connectionString)
            {
            this.connectionString = connectionString;
            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            modelBuilder.Entity<User>().HasIndex(u => u.Username).IsUnique();
            modelBuilder.Entity<Post>().HasOne(p => p.User).WithMany(e => e.Posts).OnDelete(DeleteBehavior.NoAction); // it is used to remove the error when updating database 
            }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-ADCBR92\SQLEXPRESS;Database=GloNetDb;Trusted_Connection=True;");
            }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Reaction> Reactions { get; set; }

        public DbSet<ReactionType> ReactionTypes { get; set; }

        public DbSet<User> Users { get;set; }
        }
    }
