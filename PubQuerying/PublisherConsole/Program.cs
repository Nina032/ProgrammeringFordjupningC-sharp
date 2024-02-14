using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomain;
using System.Threading.Channels;

using PubContext _context = new();

//GetAuthors();
//QueryFilters();

//FindIt();

//AddSomeMoreAuthors();

//SkipAndTakeAuthors();

//SortAuthors();

//QueryAggregate();

//InsertAuthor();

//RetrieveAndUpdateAuthor();

//RetrieveAndUpdateMultipleAuthor();
//VariousOperations();

//DeleteAnAuthor();

InsertMultipleAuthors();

void InsertMultipleAuthors()
{
    var newAuthors = new Author[]
    {
        new Author { FirstName = "Rita", LastName = "Olsson" },
        new Author { FirstName = "Sofia", LastName = "Smith" },
        new Author { FirstName = "Ursula", LastName = "Levin" },
        new Author { FirstName = "Harry", LastName = "Howey" },
        new Author { FirstName = "Isabelle", LastName = "Allie" }
    };

    _context.Authors.AddRange(newAuthors);
    _context.SaveChanges();

    //_context.Authors.UpdateRange();
    //_context.Authors.RemoveRange();
}

//samma metod som ovan men med en lista
void InsertMultipleAuthorsPassedIn(List<Author> listOfAuthors)
{
    _context.Authors.AddRange(listOfAuthors);
    _context.SaveChanges();
}

void DeleteAnAuthor()
{
    var extraNK = _context.Authors.Find(1);
    if (extraNK != null)
    {
        _context.Authors.Remove(extraNK);
        _context.SaveChanges();
    }

}

void VariousOperations()
{
    var author = _context.Authors.Find(2);
    
    author.LastName = "NewIvarsson";
   
    var newauthor = new Author
    {
        LastName = "Alvsson",
        FirstName = "Dan"
    };
    
    _context.Authors.Add(newauthor);
    _context.SaveChanges();
}

void RetrieveAndUpdateMultipleAuthor()
{
    var kicanovicAuthors = _context.Authors
        .Where(a=>a.LastName == "Radmilovic").ToList();

    foreach (var ki in kicanovicAuthors)
        ki.LastName = "Kicanovic";

    Console.WriteLine($"Before:\r\n{_context.ChangeTracker.DebugView.ShortView}");
    _context.ChangeTracker.DetectChanges();

    Console.WriteLine($"After:\r\n{_context.ChangeTracker.DebugView.ShortView}");

    _context.SaveChanges();
}

void RetrieveAndUpdateAuthor()
{
    var author = _context.Authors.FirstOrDefault(
        a => a.FirstName == "Nevena" && a.LastName == "Kicanovic");
    if (author!= null)
    {
        author.FirstName = "Nina";
        _context.SaveChanges();
    }
}

void InsertAuthor()
{
    var author = new Author { FirstName = "Frank", LastName = "Hofman" };
    _context.Authors.Add(author);
    _context.SaveChanges();
}

void QueryAggregate()
{
    var author = _context.Authors.OrderByDescending(a => a.FirstName)
        .FirstOrDefault(a => a.LastName == "Kicanovic");
}

void SortAuthors()
{
    //var authorsByLastName = _context.Authors
    //    .OrderBy(a => a.LastName)
    //    .ThenBy(a => a.FirstName).ToList();

    //authorsByLastName.ForEach(a => Console.WriteLine(a.LastName + 
    //    " " + a.FirstName));

    var authorsDescending = _context.Authors
        .OrderByDescending(a => a.LastName)
        .ThenByDescending(a => a.FirstName).ToList();

    Console.WriteLine("**DEscending Last and First**");
    authorsDescending.ForEach(a => Console.WriteLine(a.LastName + 
        " " + a.FirstName));

}

void SkipAndTakeAuthors()
{
    var groupSize = 2;
    for (int i = 0; i < 5; i++)
    {
        var authors = _context.Authors
            .Skip(i*groupSize).Take(groupSize).ToList();
        Console.WriteLine($"Group {i}:");
        foreach (var author in authors)
            Console.WriteLine($"{author.FirstName} {author.LastName}");
    }
}

void AddSomeMoreAuthors()
{
    _context.Authors.Add(new Author
    {
        FirstName = "Rastko",
        LastName = "Kicanovic"
    });
    _context.Authors.Add(new Author
    {
        FirstName = "Dusan",
        LastName = "Jovic"
    });
    _context.Authors.Add(new Author
    {
        FirstName = "Jovan",
        LastName = "Cvijic"
    });
    _context.Authors.Add(new Author
    {
        FirstName = "Stefan",
        LastName = "Hvar"
    });
    _context.SaveChanges();

}

void FindIt()
{
    var authorIdTwo = _context.Authors.Find(2);
}

void QueryFilters()
{
    //var firstname = "Nevena";
    //var authors = _context.Authors.Where(a => a.FirstName == firstname).ToList();

    var filter = "L%";
    var authors = _context.Authors
        .Where(a => EF.Functions.Like(a.LastName, filter)).ToList();
}

void GetAuthors()
{
    using var context = new PubContext();
    var authors = context.Authors.ToList();
    foreach (var author in authors)
    {
        Console.WriteLine(author.FirstName + " " + author.LastName);
    }
}
