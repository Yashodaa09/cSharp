
// 1. Create the dummy 'data' list
var data = new List<Transaction>
{
    new Transaction { Name = "Laptop Purchase", Date = "15-08-2026" }, // After July 1st -> Will show
    new Transaction { Name = "Book Purchase",   Date = "10-05-2026" }, // Before July 1st -> Hidden
    new Transaction { Name = "Phone Purchase",  Date = "25-09-2026" }  // After July 1st -> Will show
};

// 2. Your LINQ query
var result = data
    .Where(x => DateTime.Parse(x.Date) > DateTime.Parse("01-07-2026"))
    .Select(x => x.Name);

// 3. Print the results to the console
foreach (var name in result)
{
    Console.WriteLine(name);
}

// 4. Define the Transaction class at the bottom
class Transaction
{
    public string Name { get; set; }
    public string Date { get; set; }
}
