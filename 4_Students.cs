
Students[] s = new Students[3];

for(int i = 0; i<s.Length; i++)
{
    Console.Write("Enter roll number: ");
    int roll = int.Parse(Console.ReadLine());

    Console.Write("Enter name: ");
    string name = Console.ReadLine();

    s[i] = new Students(roll, name);
}
Console.WriteLine(s[0].name);
class Students
{
    public int roll;
    public string name;

    public Students(int r, string n)
    {
        roll = r;
        name = n;
    }
}