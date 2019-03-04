using System;
using Email.Entities;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Email
{
    class Program
    {
        static void Main(string[] args)
        {
            //READ THE FILE PATH 
            string FullPath = @"/users/lucasmancini/in.txt";
            Console.WriteLine("File path: " + FullPath);

            //CREATED A LIST OF EMPLOYEE
            List<Employee> list = new List<Employee>();

            try
            {
                //THIS LINE WILL READ THE FILE 
                using (StreamReader sr = File.OpenText(FullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(",");
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2]);
                        list.Add(new Employee(name, email, salary));


                    }


                }

                //ENTER THE SALARY 
                Console.Write("Enter the salary: ");
                double s1 = double.Parse(Console.ReadLine());

                //VERIFY WHICH EMPLOYEE HAS THE SALARY BIGGER THAN THE SALARY ENTERED BY THE USER
                Console.WriteLine("Email of people whose salary is more than: " + s1);
                var superior = list.Where(e => e.Salary > s1).OrderBy(e => e.Email).Select(e => e.Email);
                foreach(string email in superior)
                {
                    Console.WriteLine(email);
                }

                //SUM THE SALARY THAT NAME BEGIN WITH 'M'
                var sum = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);

                Console.WriteLine("Sum of salary of people whose name starts with 'M': " +sum);



            }

            catch(Exception ex)
            {
                Console.WriteLine("OCCURRED AN ERROR IN THE APPLICATION");
                Console.WriteLine(ex.Message);

            }

        }
    }
}
