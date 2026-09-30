A obj = new B();

obj.Display();

class A
{
    public virtual void Display()
    {
        Console.WriteLine("A");
    }
}

class B : A
{
    public override void Display()
    {
        Console.WriteLine("B");
    }
}

