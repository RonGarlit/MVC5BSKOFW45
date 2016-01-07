using System.Collections.Generic;
using System.Data.Entity;
using MVC5BSKOFW45.Models;

namespace MVC5BSKOFW45.EFDAL
{
    class DataInitialization : DropCreateDatabaseIfModelChanges<EFDataContext>
    {
        protected override void Seed(EFDataContext context)
        {
            var categories = new List<Category>
            {
                new Category {
                    Name = "Programming"
                },
                new Category {
                    Name = "Science Fiction"
                },
                new Category {
                    Name = "Database"
                },
                new Category {
                    Name = "Web "
                }
            };

            categories.ForEach(c => context.Categories.Add(c));

            var author = new Author
            {
                Biography = "...",
                FirstName = "Jamie",
                LastName = "Munro"
            };

            var author2 = new Author
            {
                Biography = "...",
                FirstName = "Ronald",
                LastName = "Garlit"
            };

            var author3 = new Author
            {
                Biography = "...",
                FirstName = "Tim",
                LastName = "McKane"
            };

            var books = new List<Book>
            {
                new Book {
                    Author = author,
                    Category = categories[0],
                    Description = "...",
                    Featured = true,
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51T%2BWt430bL._AA160_.jpg",
                    Isbn = "1491914319",
                    ListPrice = 19.99m,
                    SalePrice = 17.99m,
                    Synopsis = "...",
                    Title = "Knockout.js: Building Dynamic Client-Side Web Applications"
                },
                new Book {
                    Author = author,
                    Category = categories[0],
                    Description = "...",
                    Featured = false,
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51AkFkNeUxL._AA160_.jpg",
                    Isbn = "1449319548",
                    ListPrice = 14.99m,
                    SalePrice = 13.99m,
                    Synopsis = "...",
                    Title = "20 Recipes for Programming PhoneGap: Cross-Platform Mobile Development for Android and iPhone"
                },
                new Book {
                    Author = author2,
                    Category = categories[0],
                    Description = "...",
                    Featured = false,
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51LpqnDq8-L._AA160_.jpg",
                    Isbn = "1449309860",
                    ListPrice = 19.99m,
                    SalePrice = 16.99m,
                    Synopsis = "...",
                    Title = "20 Recipes for Programming MVC 3: Faster, Smarter Web Development"
                },
                new Book {
                    Author = author,
                    Category = categories[0],
                    Description = "...",
                    Featured = false,
                    ImageUrl = "http://ecx.images-amazon.com/images/I/41JC54HEroL._AA160_.jpg",
                    Isbn = "1460954394",
                    ListPrice = 14.99m,
                    SalePrice = 13.49m,
                    Synopsis = "...",
                    Title = "Rapid Application Development With CakePHP"
                },
                new Book {
                    Author = author2,
                    Category = categories[3],
                    Description = "...",
                    Featured = true,
                    ImageUrl = "http://www.coverbrowser.com/image/oreilly-books/530-1.jpg",
                    Isbn = "1460954394",
                    ListPrice = 14.99m,
                    SalePrice = 13.49m,
                    Synopsis = "...",
                    Title = "HTTP The definitive Guide"
                },
                new Book {
                    Author = author3,
                    Category = categories[2],
                    Description = "...",
                    Featured = true,
                    ImageUrl = "http://www.coverbrowser.com/image/oreilly-books/574-1.jpg",
                    Isbn = "1420954394",
                    ListPrice = 14.99m,
                    SalePrice = 13.49m,
                    Synopsis = "...",
                    Title = "Mastering Oracle SQL"
                },
                new Book {
                    Author = author3,
                    Category = categories[2],
                    Description = "...",
                    Featured = false,
                    ImageUrl = "http://www.coverbrowser.com/image/bestsellers-2006/2383-1.jpg",
                    Isbn = "1460954284",
                    ListPrice = 14.99m,
                    SalePrice = 13.49m,
                    Synopsis = "...",
                    Title = "PHP and MySQL 5"
                },
                new Book {
                    Author = author2,
                    Category = categories[1],
                    Description = "...",
                    Featured = true,
                    ImageUrl = "http://www.coverbrowser.com/image/bestselling-sci-fi-fantasy-2006/3897-1.jpg",
                    Isbn = "1460124284",
                    ListPrice = 14.99m,
                    SalePrice = 13.49m,
                    Synopsis = "...",
                    Title = "Hitchhikers Guide to the Galaxy"
                },
                new Book {
                    Author = author2,
                    Category = categories[1],
                    Description = "...",
                    Featured = false,
                    ImageUrl = "http://www.coverbrowser.com/image/bestselling-sci-fi-fantasy-2006/3956-1.jpg",
                    Isbn = "1460921284",
                    ListPrice = 14.99m,
                    SalePrice = 13.49m,
                    Synopsis = "...",
                    Title = "Babylon 5"
                },
                new Book {
                    Author = author3,
                    Category = categories[3],
                    Description = "...",
                    Featured = false,
                    ImageUrl = "http://cache.coverbrowser.com/image/oreilly-books/154-1.jpg",
                    Isbn = "1420954394",
                    ListPrice = 14.99m,
                    SalePrice = 13.49m,
                    Synopsis = "...",
                    Title = "HTML & CSS:  The Good Parts"
                }

            };

            books.ForEach(b => context.Books.Add(b));

            context.SaveChanges();
        }
    }
}
