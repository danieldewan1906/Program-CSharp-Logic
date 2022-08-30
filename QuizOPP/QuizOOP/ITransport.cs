using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOOP
{
    internal interface ITransport
    {
        public List<Transport> InitDataTransport();
        public void ShowDataTransport(ref List<Transport> dataTransports);
        public Dictionary<string, int> GetTransportByType(List<Transport> list);
        public void ShowTransportByRole(Dictionary<string, int> dict);
        public Dictionary<string, decimal> GetRevenueTransportByType(List<Transport> list);
        public void ShowRevenueTransportByRole(Dictionary<string, decimal> dict);
        public List<Transport> FindRevenueByRange(List<Transport> list, decimal start, decimal end);
    }
}
