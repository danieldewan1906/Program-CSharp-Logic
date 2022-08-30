using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.PartTwo
{
    internal interface IEmployee
    {
        public List<Employee> InitDataEmployee();

        public void ShowList<T>(ref List<T> list);

        public Employee FindEmployee(List<Employee> list, int id);

        public decimal GetTotalSalary<T>(ref List<T> list);

        public List<Employee> FindRangeSalary(List<Employee> list, decimal start, decimal end);
        // aggregate summary total employee per role
        public Dictionary<string, int> GetTotalEmployeeByRole(List<Employee> list);
        public void ShowEmployeeByRole(Dictionary<string, int> dict);
    }
}
