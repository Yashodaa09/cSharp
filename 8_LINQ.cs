
var data = new List<Product>
{
    new Product { Name = "Laptop", Price = 75000 },
    new Product { Name = "Phone", Price = 45000 },
    new Product { Name = "TV", Price = 60000 }
};

var result = data
    .Where(x => x.Price > 50000)
    .Select(x => new
    {
        x.Name,
        x.Price
    });

foreach (var item in result)
{
    Console.WriteLine($"Name: {item.Name}, Price: {item.Price}");
}

class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
}