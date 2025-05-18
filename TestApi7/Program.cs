using TestApi7;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnections")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var books = new List<Book>
{
    new Book{ Id = 1, Title = "The Hobbit", Author = "J.R.R. Tolkien", Year = 1937 },
    new Book{ Id = 2, Title = "1984", Author = "George Orwell", Year = 1949 },
    new Book{ Id = 3, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 },
    new Book{ Id = 4, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925 },
};

app.MapGet("/", () => "Hello World!");

app.MapGet("/Book", () => { return books; });

app.MapGet("/Book/{id}", (int id) =>
{
    var selectedBook = books.Find(b => b.Id == id);
    if (selectedBook == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(selectedBook);
});

app.MapPost("/Book", (Book book) =>
{
    books.Add(book);
    return Results.Created($"/Book/{book.Id}", book);
});

app.MapPut("/Book/{id}", (int id, Book book) =>
{
    var index = books.FindIndex(b => b.Id == id);
    if (index == -1)
    {
        return Results.NotFound();
    }
    books[index] = book;
    return Results.NoContent();
});

app.MapPut("/Book/ChangeTitle/{id}", (int id, string bookTitle) =>
{
    var index = books.FindIndex(b => b.Id == id);
    if (index == -1)
    {
        return Results.NotFound();
    }
    books[index].Title = bookTitle;
    return Results.NoContent();
});

app.MapDelete("/Book/{id}", (int id) =>
{
    var index = books.FindIndex(b => b.Id == id);
    if (index == -1)
    {
        return Results.NotFound();
    }
    books.RemoveAt(index);
    return Results.NoContent();
});

app.Run();

public class Book
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Author { get; set; }
    public int Year { get; set; }
};
