
using EFCORE1.Data;
using (var context = new BookStoreContext())
{
    context.Database.EnsureCreated();

    if (context.Database.CanConnect())
    {
        Console.WriteLine("database created Successfully");
        Console.WriteLine("books table created");
        Console.WriteLine("authors table created");
        Console.WriteLine("categories table created");
    }
}
