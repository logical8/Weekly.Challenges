var persons = new List<Person>
{
    new("Van", "Diesel"),
    new("Obivan", "Keenoby"),
    new("Jan Clodt", "Vandamm")
};

foreach (var person in persons)
{
    Console.WriteLine($"{person.Name} {person.LastName}");
}

class Person
{
    public Person(string name, string lastName)
    {
        Name = name;
        LastName = lastName;
    }

    public string Name { get; }
    public string LastName { get; }
}