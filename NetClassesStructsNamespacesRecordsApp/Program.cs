using NetClassesStructsNamespacesRecordsApp;

User user = new() { name = "Bob", 
                    age = 12, 
                    address = new(){ city = "Moscow" } };
//user.Print();

//user.name = "Joe";
//user.age = 34;

//user.Print();

//(string n, int a) = user;
user.Print();
User user2 = new()
                    {
                        name = "Bob",
                        age = 12,
                        address = new() { city = "Moscow" }
                    };
Console.WriteLine(user.Equals(user2));

Employe e1 = new Employe() { name = "Leo", age = 23 };
Employe e2 = e1 with { name = "Sam" }; //new Employe() { name = "Sam", age = 23 };

Console.WriteLine(e1.Equals(e2));

RUser r1 = new() { name = "Tom", age=23 };
RUser r2 = new() { name = "Tom", age = 23 };
//r1.Print();
//r2.name = "Ben";
//r1.Print();
Console.WriteLine(r1.Equals(r2));

Example ex = new();

class Address
{
    public string city;
}
class User
{
    public string name = "Anonim";
    public int age = -1;
    public Address address;

    public User() : this("Anonim", -1)
    {
        //name = "Anonim";
        //age = -1;
    }
    //public User(string name) : this(name, -1) {}
    //public User(int age) : this("Anonim", age) {}
    public User(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Deconstruct(out string name, out int age)
    {
        name = this.name;
        age = this.age;
    }
    public void Print()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
struct Employe
{
    public string name = "Noname";
    public int age = 12;

    public Employe() { }
    public void Print()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
record RUser
{
    public string name = "Noname";
    public int age = 12;
    public void Print()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}