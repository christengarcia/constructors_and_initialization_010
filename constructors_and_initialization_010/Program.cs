using System;

namespace constructors_and_initialization_010
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Dave = new Employee();
            {
                Age = 35;
                Name = "David Smith";
                Salary = 50000.00;
                StartingDate = new DateTime(2012, 7, 10);
                PhoneNumber = "617-555-1234";
            }
            Console.WriteLine("Dave's age is {0} he started on {1} and makes {2}",
                              Dave.Age, Dave.startingDate, Dave.Salary);

            Employee Mary = new Employee(25, "Mary Jones", 60000, new DateTime(2010, 2, 28));
            Console.WriteLine("\n\nMary's age is {0} she started on {1} and makes {2}",
                              Mary.Age, Mary.StartingDate, Mary.Salary);
        }
    }
}
