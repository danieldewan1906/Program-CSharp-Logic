using static System.Console;
using Day5;

Person yuli = new Customer("Yuli", "Ayu", "yuli@gmail.com", new DateTime(1998, 4, 24), "131-008");
Customer widi = new Customer("Widi", "Amalia", "widi@gmail.com", new DateTime(1999, 9, 30), "131-010");
Customer rini = new Customer("Rini", "Marlina", "rini@gmail.com", new DateTime(1999, 8, 4), "131-012");
Owner daniel = new Owner("Daniel", "Dewanto", "daniel@gmail.com", new DateTime(2000, 6, 19), 2);
Owner iwan = new Owner("Iwan", "Kartiwan", "iwan@gmail.com", new DateTime(1945, 8, 17), 5);

var listOfCustomer = new List<Person>() { yuli, widi, rini, daniel, iwan };

var incomeYuli = new Dictionary<string, decimal> {
    {"Kontrakan", 10_000_000 },
    {"Toko", 100_000_000 },
};

var incomeWidi = new Dictionary<string, decimal> {
    {"Kos", 20_000_000 },
    {"Jual Online", 600_000 },
};

var incomeRini = new Dictionary<string, decimal> {
    {"Supermarket", 50_000_000 },
    {"Rental Mobil", 40_000_000 },
};

var incomeDaniel = new Dictionary<string, decimal>
{
    {"Perusahaan 1", 300_000_000},
    {"Perusahaan 2", 200_000_000}
};

var incomeIwan = new Dictionary<string, decimal>
{
    {"Perusahaan 1", 500_000_000},
    {"Perusahaan 2", 750_000_000},
    {"Perusahaan 3", 50_000_000}
};

var cust1 = yuli.TotalIncome(incomeYuli);
yuli.TotalRevenue = cust1;

var cust2 = widi.TotalIncome(incomeWidi);
widi.TotalRevenue = cust2;

var cust3 = rini.TotalIncome(incomeRini);
rini.TotalRevenue = cust3;

// Show Customer
foreach (var item in listOfCustomer)
{
    Console.WriteLine($"{item}");
}

Console.WriteLine();
Console.WriteLine("=============== HIGHEST REVENUE ===============");
var listHigh = listOfCustomer.Where(x => x.TotalRevenue > 50_000_000).ToList();
foreach (var item in listHigh)
{
    Console.WriteLine($"Nama Lengkap : {item.FirstName} {item.LastName}, dengan total revenue : {item.TotalRevenue}");
}
Console.WriteLine();
Console.WriteLine("=============== MIN & MAX REVENUE ===============");
var listMin = listOfCustomer.Min(x => x.TotalRevenue);
Console.WriteLine($"Min : {listMin}");

var listMax = listOfCustomer.Max(x => x.TotalRevenue);
Console.WriteLine($"Max : {listMax}");
Console.WriteLine();

Console.WriteLine("=============== REVENUE LESS THEN MAX ================");
var listLessThenMax = listOfCustomer.Where(x => x.TotalRevenue < listMax);
foreach (var item in listLessThenMax)
{
    Console.WriteLine(item);
}
Console.WriteLine();

Console.WriteLine("============== SELECT ===============");
var query = listOfCustomer.Select(cust =>
    new
    {
        Fullname = cust.FirstName + " " + cust.LastName,
        Email = cust.Email,
        TotalRevenue = cust.TotalRevenue
    }

);

foreach (var item in query)
{
    Console.WriteLine(item);
}

LinQ.IntroLinQ();

ReadLine();
