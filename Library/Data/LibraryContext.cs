using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data
{
    public class LibraryContext: DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Authors_Book> Authors_Books { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Readers_Card> Readers_Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().ToTable("Author");
            modelBuilder.Entity<Authors_Book>().ToTable("Author's Book");
            modelBuilder.Entity<Books>().ToTable("Book");
            modelBuilder.Entity<Chapter>().ToTable("Chapter");
            modelBuilder.Entity<Reader>().ToTable("Reader");
            modelBuilder.Entity<Readers_Card>().ToTable("Reader's Card");
        }
    }
}
