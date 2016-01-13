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
                    Category = categories[2],
                    Description = "...",
                    Featured = false,
                    ImageUrl = "http://it-ebooks.info/images/ebooks/6/database_systems.jpg",
                    Isbn = "978-1-484208-78-6",
                    ListPrice = 14.99m,
                    SalePrice = 13.49m,
                    Synopsis = "...",
                    Title = "Database Systems"
                },
                new Book {
                    Author = author3,
                    Category = categories[2],
                    Description = "...",
                    Featured = false,
                    ImageUrl = "http://it-ebooks.info/images/ebooks/6/expert_oracle_database_architecture_2nd_edition.jpg",
                    Isbn = "978-1-4302-2946-9",
                    ListPrice = 14.99m,
                    SalePrice = 13.49m,
                    Synopsis = "...",
                    Title = "Expert Oracle Database Architecture, 2nd Edition"
                },
                new Book {
                    Author = author3,
                    Category = categories[2],
                    Description = "...",
                    Featured = false,
                    ImageUrl = "http://it-ebooks.info/images/ebooks/3/understanding_mysql_internals.jpg",
                    Isbn = "978-0-596-00957-1",
                    ListPrice = 14.99m,
                    SalePrice = 13.49m,
                    Synopsis = "...",
                    Title = "Understanding MySQL Internals"
                },
                new Book {
                    Author = author3,
                    Category = categories[2],
                    Description = "...",
                    Featured = true,
                    ImageUrl = "http://it-ebooks.info/images/ebooks/6/pro_sql_server_2012_relational_database_design_and_implementation.jpg",
                    Isbn = "978-1-4302-3695-5",
                    ListPrice = 14.99m,
                    SalePrice = 13.49m,
                    Synopsis = "...",
                    Title = "Pro SQL Server 2012 Relational Database Design and Implementation"
                },
                new Book {
                    Author = author2,
                    Category = categories[0],
                    Description = "...",
                    Featured = false,
                    ImageUrl = "http://it-ebooks.info/images/ebooks/14/node.js_by_example.jpg",
                    Isbn = "978-1-78439-571-1",
                    ListPrice = 14.99m,
                    SalePrice = 13.49m,
                    Synopsis = "...",
                    Title = "Node.js By Example"
                },
                new Book {
                    Author = author2,
                    Category = categories[0],
                    Description = "...",
                    Featured = false,
                    ImageUrl = "http://it-ebooks.info/images/ebooks/14/node_cookbook.jpg",
                    Isbn = "978-1-84951-718-8",
                    ListPrice = 14.99m,
                    SalePrice = 13.49m,
                    Synopsis = "...",
                    Title = "Node Cookbook"
                },
                new Book {
                    Author = author2,
                    Category = categories[0],
                    Description = "...",
                    Featured = false,
                    ImageUrl = "http://it-ebooks.info/images/ebooks/14/node.js_design_patterns.jpg",
                    Isbn = "978-1-78328-731-4",
                    ListPrice = 14.99m,
                    SalePrice = 13.49m,
                    Synopsis = "...",
                    Title = "Node.js Design Patterns"
                },
                new Book {
                    Author = author2,
                    Category = categories[3],
                    Description = "...",
                    Featured = false,
                    ImageUrl = "http://it-ebooks.info/images/ebooks/3/asp.net_mvc_5_with_bootstrap_and_knockout.js.jpg",
                    Isbn = "978-1-49191-439-7",
                    ListPrice = 14.99m,
                    SalePrice = 13.49m,
                    Synopsis = "...",
                    Title = "ASP.NET MVC 5 with Bootstrap and Knockout.js"
                }

            };

            books.ForEach(b => context.Books.Add(b));

            context.SaveChanges();
        }
    }
}
