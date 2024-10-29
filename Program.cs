using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object
            Employee employee = new Employee
            {
                FirstName = "Sample",  // Set the first name
                LastName = "Student"   // Set the last name
            };

            // Call the SayName method, which is inherited from the Person class
            employee.SayName();

            // Pause to allow the user to see the output
            Console.ReadKey();
        }
    }
}
