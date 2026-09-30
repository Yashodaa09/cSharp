
Student s = new Student(1, "Yashoda");
Console.WriteLine(s.roll);
Console.WriteLine(s.name);

class Student
{
    public int roll;
    public string name;
    public Student(int r, string n)
    {
        roll = r;
        name = n;
    }
}
