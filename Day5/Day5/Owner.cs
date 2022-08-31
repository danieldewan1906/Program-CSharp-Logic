using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Owner : Person
    {
        private int hasCompany;

        public Owner(string firstName, string lastName, string email, DateTime birthDate, int hasCompany) : base(firstName, lastName, email, birthDate)
        {
            Random random = new Random();
            SocialNumber = random.Next(1100, 1200);
            this.hasCompany = hasCompany;
        }

        public int HasCompany { get => hasCompany; set => hasCompany = value; }

        public override decimal TotalIncome(Dictionary<string, decimal> dict)
        {
            decimal total = 0;

            foreach (var item in dict)
            {
                total += item.Value;
            }

            return total;
        }

        public override string? ToString()
        {
            return $"{base.ToString()} | Company : {this.hasCompany}";
        }
    }
}
