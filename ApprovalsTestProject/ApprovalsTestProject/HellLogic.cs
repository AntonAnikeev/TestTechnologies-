using System;
using System.Collections.Generic;

namespace ApprovalsTestProject
{
    public class HellLogic
    {
        public int BasicSalary = 20;
        public int BasicNumberOfHolidays = 24;

        public List<Employee> ExecuteHellLogic()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Company = "test1",
                     DateOfBirth = new DateTime(1995,10,25),
                    Email = @"1@gmail.com",
                    FirstName = "Victor",
                    ID = Guid.NewGuid(),
                    NumberOfHolidays = BasicNumberOfHolidays,
                    Salary = (int)(1000 *Math.Exp((double)BasicSalary)),
                    SecondName = "Boo"                },
                new Employee
                {
                    Company = "test1",
                    DateOfBirth = new DateTime(1995,10,25),
                    Email = @"1@gmail.com",
                    FirstName = "Victor",
                    ID = Guid.NewGuid(),
                    NumberOfHolidays = BasicNumberOfHolidays,
                    Salary = BasicSalary * 1000,
                    SecondName = "Boo"
                }
            };
            
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string  Company { get; set; }

        public Guid ID { get; set; }

        public int Salary { get; set; }

        public int NumberOfHolidays { get; set; }
        
    }
}
