using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomain;
using System;
using System.Linq;

using (PubContext context = new PubContext())
{
    context.Database.EnsureCreated();
}

//GetAuthors();
//AddAuthors();
//Console.WriteLine("________________________");
//GetAuthors();

//AddAuthorWithBook();
GetAuthorsWithBooks();

void GetAuthors()
{
    using var context = new PubContext();
    var authors = context.Authors.ToList();
    foreach (var author in authors)
    {
        Console.WriteLine(author.FirstName + " " + author.LastName);
    }
}

void AddAuthors()
{
    var author = new Author { FirstName = "Anna", LastName = "Ivarsson" };
    using var context = new PubContext();
    context.Authors.Add(author);
    context.SaveChanges();
}

void AddAuthorWithBook()
{
    var author = new Author { FirstName = "Nevena", LastName = "Kicanovic" };
    author.Books.Add(new Book
    {
        Title = "Programming 1",
        PublishDate = new DateOnly(2012,1,1)
    });

    author.Books.Add(new Book
    {
        Title = "Programming 2",
        PublishDate = new DateOnly(2015, 2, 2)
    });

    using var context = new PubContext();
    context.Authors.Add(author);
    context.SaveChanges();
}

void GetAuthorsWithBooks()
{
    using var context = new PubContext();
    var authors = context.Authors.Include(a => a.Books).ToList();
    foreach (var author in authors)
    {
        Console.WriteLine(author.FirstName + " " + author.LastName);
        foreach (var book in author.Books)
        {
            Console.WriteLine(book.Title);
        }
    }
}