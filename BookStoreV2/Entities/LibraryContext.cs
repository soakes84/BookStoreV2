using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreV2.Entities
{
    public class LibraryContext:DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options):base(options)
        {
            Database.Migrate();
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author
            {
                AuthorId = Guid.NewGuid(),
                FirstName = "Daniel",
                LastName = "Silva",
                Genre = "Action"
            }, new Author
            {
                AuthorId = Guid.NewGuid(),
                FirstName = "Andrew",
                LastName = "Weil",
                Genre = "Medicine"
            }, new Author
            {
                AuthorId = Guid.NewGuid(),
                FirstName = "Tom",
                LastName = "Clancy",
                Genre = "Thriller"
            }, new Author
            {
                AuthorId = Guid.NewGuid(),
                FirstName = "Lee",
                LastName = "Child",
                Genre = "Action"
            }, new Author
            {
                AuthorId = Guid.NewGuid(),
                FirstName = "Anthony",
                LastName = "Doeer",
                Genre = "Fiction"
            }, new Author
            {
                AuthorId = Guid.NewGuid(),
                FirstName = "Clinton",
                LastName = "Romesha",
                Genre = "Military"
            }, new Author
            {
                AuthorId = Guid.NewGuid(),
                FirstName = "Marcus",
                LastName = "Luttrell",
                Genre = "Military"
            }, new Author
            {
                AuthorId = Guid.NewGuid(),
                FirstName = "Robert",
                LastName = "Ludlum",
                Genre = "Thriller"
            });
        }
    }
}
