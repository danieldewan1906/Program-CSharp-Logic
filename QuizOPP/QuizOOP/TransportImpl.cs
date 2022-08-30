using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOOP
{
    internal class TransportImpl : ITransport
    {
        public List<Transport> InitDataTransport()
        {
            SUV suv1 = new SUV("D 1001 UM", 2015, 500_000, 100_000);
            SUV suv2 = new SUV("D 1002 UM", 2019, 500_000, 100_000);

            Taxi taxi1 = new Taxi("D 8899 UK", 2018, 5, 4500, 40, 10_000);
            Taxi taxi2 = new Taxi("D 8788 UK", 2018, 10, 4500, 100, 10_000);

            Angkot ang1 = new Angkot("D 5544 UJ", 2016, 4500, 35);
            Angkot ang2 = new Angkot("D 5533 UJ", 2015, 4500, 40);
            return new List<Transport>() {suv1, suv2, taxi1, taxi2, ang1, ang2};
        }

        public void ShowDataTransport(ref List<Transport> dataTransports)
        {
            foreach (var item in dataTransports)
            {
                Console.WriteLine($"{item} ");
            }
        }

        public Dictionary<string, int> GetTransportByType(List<Transport> list)
        {
            var result = new Dictionary<string, int>();
            int countSuv = 0;
            int countTaxi = 0;
            int countAngkot = 0;

            foreach (var item in list)
            {
                if (item.Type == "SUV")
                {
                    countSuv++;
                }
                else if (item.Type == "Taxi")
                {
                    countTaxi++;
                }
                else if (item.Type == "Angkot")
                {
                    countAngkot++;
                }
            }
            result.Add("SUV", countSuv);
            result.Add("Taxi", countTaxi);
            result.Add("Angkot", countAngkot);

            return result;
        }

        public void ShowTransportByRole(Dictionary<string, int> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"Type : {item.Key} \n Jumlah : {item.Value}");
            }
        }

        public Dictionary<string, decimal> GetRevenueTransportByType(List<Transport> list)
        {
            var dict = new Dictionary<string, decimal>();
            decimal sumSuv = 0;
            decimal sumTaxi = 0;
            decimal sumAngkot = 0;

            foreach (var item in list)
            {
                if (item.Type == "SUV")
                {
                    sumSuv += item.TotalRevenue;
                }
                else if (item.Type == "Taxi")
                {
                    sumTaxi += item.TotalRevenue;
                }
                else if (item.Type == "Angkot")
                {
                    sumAngkot += item.TotalRevenue;
                }
            }
            dict.Add("SUV", sumSuv);
            dict.Add("Taxi", sumTaxi);
            dict.Add("Angkot", sumAngkot);

            return dict;
        }

        public void ShowRevenueTransportByRole(Dictionary<string, decimal> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"Type : {item.Key} \n Jumlah : {item.Value}");
            }
        }

        public List<Transport> FindRevenueByRange(List<Transport> list, decimal start, decimal end)
        {
            var trans = new List<Transport>();
            foreach (var item in list)
            {
                if (item.TotalRevenue > start && item.TotalRevenue < end)
                {
                    trans.Add(item);
                }
            }
            return trans;
        }
    }
}
