using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.PartTwo
{
    internal class QA : Employee
    {
        private decimal makan;

        public QA(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city, decimal makan) : base(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.makan = makan;
            this.Role = "QA";
            TotalSalary = basicSalary + makan;
        }

        public decimal Makan { get => makan; set => makan = value; }

        private decimal GetTunjanganQA()
        {
            return this.BasicSalary + this.Makan;
        }

        public override string? ToString()
        {
            return $"{base.ToString()} | Bonus Makan : {this.Makan.ToString("C", new CultureInfo("id-ID"))} | Total Salary : {TotalSalary.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
