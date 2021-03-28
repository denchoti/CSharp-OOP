using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary { get; private set; }

        public void IncreaseSalary(decimal percentage)
        {
            //if (Age < 30)
            //{
            //    percentage /= 2;
            //}
           // Salary = Salary + Salary * percentage / 100;
            
             //if (Age < 30)
            //{
            //    Salary += Salary * percentage / 200;
            //}
            //else
            //{
            //    Salary += Salary * percentage / 100;
            //}

            
            var delimiter = 100;
            if (this.Age < 30)
            {
                delimiter = 200;
            }
            this.Salary += this.Salary * percentage / delimiter;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }
    }
}
