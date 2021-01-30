using System;

public class Dog
{
    public string Name { get; set; }

    public Dog(string name)
    {
        Name = name;
    }
}

public class Cat
{
    public string Name { get; set; }

    public Cat(string name)
    {
        Name = name;
    }
}

public class Human
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Human(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

public class Creatures
{
   public static void Main()
    {
        Object thing = new Dog("Scout");
        ShowCreature(thing);

        thing = new Cat("Mittens");
        ShowCreature(thing);

        thing = new Human("Bob", "Smith");
        ShowCreature(thing);
    }

    public static void ShowCreature(object thing)
    {
        if (thing is Dog)
        {
            Dog a = (Dog) thing;
            Console.WriteLine($"Dog: {a.Name}");
        }
        else if (thing is Cat)
        {
            Cat b = (Cat) thing;
            Console.WriteLine($"Cat: {b.Name}");
        }
        else if (thing is Human)
        {
            Human c = (Human) thing;
            Console.WriteLine($"Human: {c.FirstName} {c.LastName}");
        }
    }
}