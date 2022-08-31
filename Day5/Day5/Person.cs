using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal abstract class Person
    {
        private int socialNumber;
        private string firstName;
        private string lastName;
        private string email;
        private DateTime birthDate;
        private decimal totalRevenue;

        protected Person(string firstName, string lastName, string email, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.birthDate = birthDate;
        }
        
        public int SocialNumber { get => socialNumber; set => socialNumber = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public decimal TotalRevenue { get => totalRevenue; set => totalRevenue = value; }
        
        // method abstract class
        public abstract decimal TotalIncome(Dictionary<string, decimal> dict);

        public override string? ToString()
        {
            return $"Social Number : {this.socialNumber} | Full Name : {this.firstName} {this.lastName} | Email : {this.email} | BirthDate : {this.birthDate} | Revenue : {this.totalRevenue.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
