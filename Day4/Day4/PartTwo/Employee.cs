using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.PartTwo
{
    internal class Employee
    {
        //instance variable
        private int empId;
        private string firstName;
        private string lastName;
        private DateTime joinDate;
        private Decimal basicSalary;
        private decimal totalSalary;
        private string city;
        private string role;

        //static variable (global variable)
        public static int totalEmployee = 0;
        public static Decimal totalBasicSalary = 0M;

        //empty constructor
        public Employee()
        {
            totalEmployee++;
            totalBasicSalary += this.BasicSalary;
            this.totalSalary = this.basicSalary;
        }

        //constructor parameter
        public Employee(int empId, string firstName, string lastName, 
            DateTime joinDate, Decimal basicSalary)
        {
            this.empId = empId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.joinDate = joinDate;
            this.basicSalary = basicSalary;
            totalEmployee++;
            totalBasicSalary += this.BasicSalary;
            this.totalSalary = this.basicSalary;
        }

        public Employee(int empId, string firstName, string lastName, 
            DateTime joinDate, Decimal basicSalary, string city) : 
            this(empId, firstName, lastName, joinDate, basicSalary)
        {
            this.city = city;
        }

        public Employee(int empId, string firstName, string lastName, 
            DateTime joinDate, Decimal basicSalary, string city, string role) 
            : this(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.role = role;
        }

        //get and set
        public int EmpId { get => empId; set => empId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }
        public Decimal BasicSalary { get => basicSalary;
            set { 
                basicSalary = value;
                //totalSalary = basicSalary;
                }
        }
        public string City { get => city; set => city = value; }
        public string Role { get => role; set => role = value; }
        public decimal TotalSalary { get => totalSalary; set => totalSalary = value; }

        //method return
        public override string? ToString()
        {
            return $"Employee : {this.empId} | {this.firstName} | {this.lastName} | " +
                $"{this.basicSalary.ToString("C", new CultureInfo("id-ID"))} | {this.role}";
        }
    }
}
