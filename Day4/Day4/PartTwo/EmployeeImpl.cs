using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.PartTwo
{
    internal class EmployeeImpl : IEmployee
    {
        public List<Employee> InitDataEmployee()
        {
            // create business logic
            /*Employee emp1 = new Employee(123, "Bagas", "Sumanto", new DateTime(), 5_000_000);
            Employee emp2 = new Employee(124, "Erick", "Thohir", new DateTime(), 1_000_000, "Bogor");
            Employee emp3 = new Employee(125, "Bambang", "Pamungkas", new DateTime(), 6_000_000, "Jakarta", "Sales");*/

            Programmer prog1 = new Programmer(126, "Daniel", "Dewanto",
                new DateTime(2015, 3, 3), 6_000_000, "Jogja", 5_00_000);

            Programmer prog2 = new Programmer(127, "Jack", "Smith",
                new DateTime(2016, 8, 15), 6_000_000, "Madiun", 5_00_000);

            Programmer prog3 = new Programmer(128, "Pratama", "Dewa",
                new DateTime(2017, 5, 9), 6_000_000, "Cikarang", 5_00_000);

            Sales sa1 = new Sales(129, "Budi", "Sudarsono",
                new DateTime(2020, 6, 10), 3_000_000, "Garut", 250_000, 150_000);

            Sales sa2 = new Sales(130, "Bambang", "Pamungkas",
                new DateTime(2019, 6, 10), 3_000_000, "Bekasi", 250_000, 150_000);

            QA qa1 = new QA(131, "Dadang", "Suherman",
                new DateTime(2021, 10, 10), 4_500_000, "Bandung", 50_000);

            QA qa2 = new QA(132, "Segio", "Uhuy",
                new DateTime(2015, 10, 10), 4_500_000, "Lampung", 50_000);

            return new List<Employee>() {prog1, prog2, prog3, sa1, sa2, qa1, qa2};
        }

        public void ShowList<T>(ref List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item} ");
            }
        }

        public Employee FindEmployee(List<Employee> list1, int id)
        {
            var listEmp = list1;
            Employee emp = new Employee();
            foreach (var item in listEmp)
            {
                if (item.EmpId == id)
                {
                    emp = item;
                }
            }
            return emp;
        }

        public decimal GetTotalSalary<T>(ref List<T> list)
        {
            var totalSalary = 0M;
            foreach (var item in list.OfType<Employee>())
            {
                totalSalary += item.TotalSalary;
            }
            return totalSalary;
        }

        public List<Employee> FindRangeSalary(List<Employee> list, decimal start, decimal end)
        {
            var listEmp = new List<Employee>();
            var startSalary = start;
            var endSalary = end;
            foreach (var item in list)
            {
                if (item.TotalSalary >= startSalary && item.TotalSalary <= endSalary)
                {
                    listEmp.Add(item);
                }
            }
            return listEmp;
        }

        public Dictionary<string, int> GetTotalEmployeeByRole(List<Employee> list)
        {
            var dict = new Dictionary<string, int>();
            int countProg = 0;
            int countSales = 0;
            int countQA = 0;

            foreach (var item in list)
            {
                if (item.Role == "Programmer")
                {
                    countProg++;
                }
                else if (item.Role == "Sales")
                {
                    countSales++;
                }
                else if (item.Role == "QA")
                {
                    countQA++;
                }
            }
            dict.Add("Programmer", countProg);
            dict.Add("Sales", countSales);
            dict.Add("QA", countQA);

            return dict;
        }

        public void ShowEmployeeByRole(Dictionary<string, int> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"Role : {item.Key} \n Total Employe : {item.Value}");
            }
        }
    }
}
