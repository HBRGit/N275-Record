using System;

namespace N278
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new(1, "Alice", 30);
            Person p2 = new(1, "Alice", 30);


            Console.WriteLine($"p1 == p2: {p1 == p2}"); // True, because records have value-based equality by default
            Console.WriteLine(p1); // Person { Id = 1, Name = Alice, Age = 30, NameToUpper1 = ALICE } Note. Property usage is included in ToString output

            // Create a new person1 using the 'with' keyword where only the name is changed
            Person person1 = p1 with { Name = "Bob" };
            Console.WriteLine(person1); // Person { Id = 1, Name = Bob, Age = 30, NameToUpper1 = BOB } Note. Property usage is included in ToString output
            Console.WriteLine("Property usage: "+person1.NameToUpper1); // Property usage
            Console.WriteLine("Method usage: "+person1.NameToUpper2()); // Method usage

            Console.WriteLine("Press any key to continue...");
            Console.Read(); // Waits for any key press
        }
    }
    record Person(int Id, string Name, int Age)
    {
        // Property
        public string NameToUpper1
        {
            get
            {
                return Name.ToUpper();
            }
        }
        // Method
        public string NameToUpper2()
        {
            return Name.ToUpper();
        }
    };
}


