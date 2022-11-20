using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class DatabazeOsob
    {
        private List<PojisteneOsoby> pojisteneOsoby;

        public DatabazeOsob()
        {
            pojisteneOsoby = new List<PojisteneOsoby>();
        }

        public void PridejPojisteneho(string jmeno, string prijmeni, int vek, int cislo)
        {
            pojisteneOsoby.Add(new PojisteneOsoby(jmeno, prijmeni, vek, cislo));
        }

        public List<PojisteneOsoby> VypisPojistene()
        {
            return pojisteneOsoby;
        }

        public List<PojisteneOsoby> VyhledejPojisteneho(string jmeno, string prijmeni)
        {
            List<PojisteneOsoby> vyhledane = new List<PojisteneOsoby>();
            foreach (PojisteneOsoby osoba in pojisteneOsoby)
            {
                if (jmeno == osoba.Jmeno && prijmeni == osoba.Prijmeni)
                    vyhledane.Add(osoba);
            }
            return vyhledane;
        }
    }
}
