using System;

// 1. Create an array 's' filled with 3 employees
Employee[] s = new Employee[]
{
    new Employee { name = "Amit",  salary = 75000, age = 28 }, // > 60000 -> Will print
    new Employee { name = "Pooja", salary = 45000, age = 24 }, // < 60000 -> Hidden
    new Employee { name = "Rahul", salary = 90000, age = 32 }  // > 60000 -> Will print
};

// 2. Your loop to filter and print
for (int i = 0; i < s.Length; i++)
{
    if (s[i].salary > 60000)
    {
        Console.WriteLine(s[i].name);
        Console.WriteLine(s[i].age);
    }
}

// 3. Define the Employee class structure at the bottom
class Employee
{
    public string name;
    public int salary;
    public int age;
}
