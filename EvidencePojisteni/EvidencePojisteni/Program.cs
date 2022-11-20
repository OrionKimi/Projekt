using EvidencePojisteni;

Evidence evidence = new Evidence();
char volba = '0';
while (volba != '4')
{
    evidence.VypisObrazovky();
    Console.WriteLine();
    Console.WriteLine("Vyberte si akci:");
    Console.WriteLine("1 - Přidat nového pojištěného");
    Console.WriteLine("2 - Vypsat všechny pojištěné");
    Console.WriteLine("3 - Vyhledat pojištěného");
    Console.WriteLine("4 - Konec");
    volba = Console.ReadKey().KeyChar;
    Console.WriteLine();
    switch (volba)
    {
        case '1':
            Console.WriteLine();
            evidence.PridejPojisteneho();
            Console.WriteLine();
            Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...");
            break;
        case '2':
            Console.WriteLine();
            evidence.VypisPojistene();
            Console.WriteLine();
            Console.WriteLine("Pokračujte libovolnou klávesou...");
            break;
        case '3':
            Console.WriteLine();
            evidence.VyhledejPojisteneho();
            Console.WriteLine();
            Console.WriteLine("Pokračujte libovolnou klávesou...");
            break;
        case '4':
            Console.WriteLine();
            Console.WriteLine("Libovolnou klávesou ukončíte program...");
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
            break;
    }
    Console.ReadKey();
}
