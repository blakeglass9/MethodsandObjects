using System;

namespace EmployeeApp
{
    // Person class with two properties and a method to display the full name
    public class Person
    {
        // Property for the first name
        public string FirstName { get; set; }

        // Property for the last name
        public string LastName { get; set; }

        // Method to display the person's full name
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
