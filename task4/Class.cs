using System;
 // The error "too many entry points defined" occurs because you have more than one Main method across multiple classes, and the compiler doesn’t know which one to use as the entry point for the program.
//my answer main is only defined in one place?
public class FirstClass
{
    public static void Main(string[] args)
    {
        int total = 3;
        Person[] persons = new Person[total];
 
        for (int i = 0; i < total; i++)
        {
            persons[i] = new Person() {
                Name = Console.ReadLine()
            };
        }
 
        for (int i = 0; i < total; i++)
        {
            Console.WriteLine(persons[i].ToString());
        }
 
        Console.ReadLine();
    }
 
    public class Person
    {
        public string Name { get; set; }
 
        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
    }
}