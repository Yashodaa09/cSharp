using System;

// 1. Create an array 's' filled with dummy employee data
Employee[] s = new Employee[]
{
    new Employee { name = "Amit",  salary = 75000 },
    new Employee { name = "Pooja", salary = 95000 }, // This is the highest salary
    new Employee { name = "Rahul", salary = 50000 }
};

// 2. Your loop to find the maximum salary
int max = 0;

for (int i = 0; i < s.Length; i++)
{
    if (s[i].salary > max)
    {
        max = s[i].salary;
    }
}

// 3. Print the highest salary (95000)
Console.WriteLine(max);

// 4. Define the Employee class structure at the bottom
class Employee
{
    public string name;
    public int salary;
}
