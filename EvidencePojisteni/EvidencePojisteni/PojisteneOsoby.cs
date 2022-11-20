using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class PojisteneOsoby
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Vek { get; set; }
        public int Cislo { get; set; }

        public PojisteneOsoby(string jmeno, string prijmeni, int vek, int cislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Cislo = cislo;
        }

        public override string ToString()
        {
            return String.Format("{0, -9} {1, -15} {2, 3} {3, 13}", Jmeno, Prijmeni, Vek, Cislo);
        }
    }
}
