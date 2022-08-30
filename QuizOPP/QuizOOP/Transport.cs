using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOOP
{
    internal class Transport
    {
        private string noPolisi;
        private int tahun;
        private string type;
        private decimal totalRevenue;

        public Transport(string noPolisi, int tahun)
        {
            this.noPolisi = noPolisi;
            this.tahun = tahun;
            totalRevenue = 0;
        }

        public Transport(string noPolisi, int tahun, string type) : this(noPolisi, tahun)
        {
            this.type = type;
            totalRevenue = 0;
        }

        public string NoPolisi { get => noPolisi; set => noPolisi = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public string Type { get => type; set => type = value; }
        public decimal TotalRevenue { get => totalRevenue; set => totalRevenue = value; }

        public override string? ToString()
        {
            return $"{this.noPolisi} | {this.tahun} | {this.type} | ";
        }
    }
}
