using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class Evidence
    {
        private DatabazeOsob databazeOsob;

        public Evidence()
        {
            databazeOsob = new DatabazeOsob();
        }

        public void PridejPojisteneho()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = Console.ReadLine();
            Console.WriteLine("Zadejte telefonní číslo:");
            int cislo = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte věk:");
            int vek = int.Parse(Console.ReadLine());
            databazeOsob.PridejPojisteneho(jmeno, prijmeni, vek, cislo);
        }

        public void VypisPojistene()
        {
            List<PojisteneOsoby> pojisteneOsoby = databazeOsob.VypisPojistene();
            foreach (PojisteneOsoby osoba in pojisteneOsoby)
                Console.WriteLine(osoba);
        }

        public void VyhledejPojisteneho()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = Console.ReadLine();
            Console.WriteLine();
            List<PojisteneOsoby> pojisteneOsoby = databazeOsob.VyhledejPojisteneho(jmeno, prijmeni);
            if (pojisteneOsoby.Count() > 0)
            {
                foreach (PojisteneOsoby osoba in pojisteneOsoby)
                    Console.WriteLine(osoba);
            }
            else
                Console.WriteLine("Tato osoba nebyla nalezena v evidenci.");
        }

        public void VypisObrazovky()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("-----------------------------");
        }
    }
}
