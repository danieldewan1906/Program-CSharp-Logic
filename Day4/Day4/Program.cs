using static System.Console;
using Day4.PartTwo;

//gunakan encapsulation untuk manipulasi attribute object
/*emp1.empId = 123;
emp1.firstName = "Daniel";
emp1.lastName = "Dewanto";*/

//create object instance, gunakan operator new
/*Employee emp1 = new Employee();
emp1.EmpId = 122;
emp1.FirstName = "Rey";
emp1.LastName = "Mysterio";
emp1.JoinDate = DateTime.Now;
emp1.BasicSalary = 3_000_000;
emp1.City = "Cirebon";
emp1.Role = "Programmer";
*/
//create object with parameter constructor
/*Employee emp2 = new Employee(123, "Bagas", "Sumanto", new DateTime(), 5_000_000);
emp2.Role = "Sales";
Employee emp3 = new Employee(124, "Erick", "Thohir", new DateTime(), 1_000_000, "Bogor");
emp3.Role = "QA";
*///emp3.BasicSalary = 3_000_000;
//Employee emp4 = new Employee(125, "Bambang", "Pamungkas", new DateTime(), 6_000_000, "Jakarta", "Sales");

/*Console.WriteLine(emp1.ToString());
Console.WriteLine(emp2.ToString());
Console.WriteLine(emp3.ToString());
Console.WriteLine(emp4.ToString());

Console.WriteLine("====================================");
*/

// create child class programmer
/*Programmer prog1 = new Programmer(126, "Daniel", "Dewanto", 
    new DateTime(2015, 3, 3), 6_000_000, "Jogja", 5_00_000);

Programmer prog2 = new Programmer(127, "Jack", "Smith", 
    new DateTime(2016, 8, 15), 6_000_000, "Madiun", 5_00_000);

Programmer prog3 = new Programmer(128, "Pratama", "Dewa", 
    new DateTime(2017, 5, 9), 6_000_000, "Cikarang", 5_00_000);
*/
// create child class sales
/*Sales sa1 = new Sales(129, "Budi", "Sudarsono", 
    new DateTime(2020, 6, 10), 3_000_000, "Garut", 250_000, 150_000);

Sales sa2 = new Sales(130, "Bambang", "Pamungkas", 
    new DateTime(2019, 6, 10), 3_000_000, "Bekasi", 250_000, 150_000);
*/
// create child class QA
/*QA qa1 = new QA(131, "Dadang", "Suherman", 
    new DateTime(2021, 10, 10), 4_500_000, "Bandung", 50_000);

QA qa2 = new QA(132, "Segio", "Uhuy", 
    new DateTime(2015, 10, 10), 4_500_000, "Lampung", 50_000);
*/

// store to list
/*List<Employee> list = new List<Employee>() {prog1, prog2, prog3, sa1, sa2, qa1, qa2};
foreach (var item in list)
{
    Console.WriteLine(item.ToString());
}
*//*Console.WriteLine($"Total Employee : {Employee.totalEmployee}");
Console.WriteLine($"Total Salary : {Employee.totalBasicSalary}");
*/

Console.WriteLine("====================IMPLEMENTASI INTERFACE====================");
// call interface & implementasi
Console.WriteLine();
Console.WriteLine("==========LIST EMPLOYEE==========");
IEmployee empIntf = new EmployeeImpl();
var list = empIntf.InitDataEmployee();
empIntf.ShowList(ref list);
Console.WriteLine();
Console.WriteLine("==========FIND EMPLOYEE==========");
var find = empIntf.FindEmployee(list, 126);
Console.WriteLine(find);
Console.WriteLine();
Console.WriteLine("==========TOTAL SALARY==========");
var total = empIntf.GetTotalSalary(ref list);
Console.WriteLine($"Total Salary All Employee : {total}");
Console.WriteLine();
Console.WriteLine("==========FIND RANGE SALARY==========");
var rangeSalary = empIntf.FindRangeSalary(list, 3_000_000, 5_000_000);
empIntf.ShowList(ref rangeSalary);
Console.WriteLine();
Console.WriteLine("==========TOTAL EMPLOYEE BY ROLE==========");
var empRole = empIntf.GetTotalEmployeeByRole(list);
empIntf.ShowEmployeeByRole(empRole);

ReadLine();