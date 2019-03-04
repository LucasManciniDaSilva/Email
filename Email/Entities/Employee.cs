using System;
namespace Email.Entities
{
    public class Employee
    {

        //DEFINED THE VARIABLES
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }


        //CREATED A CONSTRUCTOR WITH ARGUMENTS
        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
