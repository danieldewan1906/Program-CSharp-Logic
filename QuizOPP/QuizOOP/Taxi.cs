using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOOP
{
    internal class Taxi : Transport
    {
        private int order;
        private decimal orderPerKM;
        private int totalKM;
        private decimal bonus;

        public Taxi(string noPolisi, int tahun, int order, decimal orderPerKM, int totalKM, decimal bonus) : base(noPolisi, tahun)
        {
            this.order = order;
            this.orderPerKM = orderPerKM;
            this.totalKM = totalKM;
            this.bonus = bonus;
            this.Type = "Taxi";
            TotalRevenue = (order * bonus) + (orderPerKM * totalKM);
        }

        public int Order { get => order; set => order = value; }
        public decimal OrderPerKM { get => orderPerKM; set => orderPerKM = value; }
        public int TotalKM { get => totalKM; set => totalKM = value; }
        public decimal Bonus { get => bonus; set => bonus = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} Order : {this.order} | OrderPerKM : {this.orderPerKM} | TotalKM : {this.totalKM} | Bonus : {this.bonus} | Total Revenue : {TotalRevenue.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
