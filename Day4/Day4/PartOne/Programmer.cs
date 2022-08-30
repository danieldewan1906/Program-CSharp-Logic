using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Day4.PartOne
{
    internal class Programmer : Employee
    {
        private decimal transportasi;

        public Programmer(int empId, string firstName, string lastName,
            DateTime joinDate, decimal basicSalary, string city, 
            decimal transportasi) : base(empId, firstName, 
                lastName, joinDate, basicSalary, city)
        {
            this.transportasi = transportasi;
            this.Role = "Programmer";
            //TotalSalary = basicSalary + transportasi;
        }
        public decimal Transportasi { get => transportasi; set => transportasi = value; }

        public decimal GetTunjanganProgrammer()
        {
            return this.TotalSalary + this.transportasi;
        }

        public override string? ToString()
        {
            return $"{base.ToString()} | Tj Transport : {this.transportasi.ToString("C", new CultureInfo("id-ID"))} | Total Salary : {GetTunjanganProgrammer().ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
