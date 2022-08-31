using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Customer : Person
    {
        private string accountNumber;

        public Customer(string firstName, string lastName, string email, DateTime birthDate, string accountNumber) : base(firstName, lastName, email, birthDate)
        {
            Random random = new Random();
            SocialNumber = random.Next(1000, 1100);
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDate = birthDate;
            this.accountNumber = accountNumber;
        }

        public string AccountNumber { get => accountNumber; set => accountNumber = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Account Number : {this.accountNumber}";
        }

        public override decimal TotalIncome(Dictionary<string, decimal> dict)
        {
            decimal total = 0;

            foreach (var item in dict)
            {
                total += item.Value;
            }

            return total;
        }
    }
}
