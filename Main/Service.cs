namespace ConsoleApp1;

public class Service
{
    public static List<Device> Devices = new();
    public static List<Person> Users = new();
    public static List<Device> ZutylizowanySprzet = new();
    public static List<Wypozyczenie> Rentals = new();

    public static void DodajSprzet(Device device)
    {
        Devices.Add(device);
    }

    public static void UsunTrwaleSprzet(Device device)
    {
        Devices.Remove(device);
        ZutylizowanySprzet.Add(device);
    }

    public static void PokazSprzetZutylizowany()
    {
        foreach (Device zutylizowany in ZutylizowanySprzet)

        {
            if (zutylizowany is Laptop laptop)
                Console.WriteLine($"Zutylizowany laptop: ID: {laptop.Id}, NAZWA: {laptop.Nazwa}, RAM: {laptop.RamGB}");
            else if (zutylizowany is Mouse mouse)
                Console.WriteLine($"Zutylizowana mysz: ID:{mouse.Id}, NAZWA: {mouse.Nazwa}, DPI: {mouse.DPI}");
            else if (zutylizowany is Projector projector)
                Console.WriteLine($"Zutylizowany projektor: ID:{projector.Id} NAZWA: {projector.Nazwa}, JASNOŚĆ: {projector.Jasnosc} lumenów");
        }
    }


    public static void DodajUzytkownika(Person person)
    {
        Users.Add(person);
    }

    public void Wypozycz(Device device, Person person)
    {
    }

    public void Zwroc(Device device)
    {
    }

    public static void ShowAllDevices()
    {
        foreach (Device x in Devices)
        {
            if (x is Laptop laptop)
                Console.WriteLine($"Laptop: {laptop.Nazwa}, RAM: {laptop.RamGB}");
            else if (x is Mouse mouse)
                Console.WriteLine($"Mysz: {mouse.Nazwa}, DPI: {mouse.DPI}");
            else if (x is Projector projector)
                Console.WriteLine($"Projektor: {projector.Nazwa}, {projector.Jasnosc} lumenów");
        }
    }

    public void PokazDostepnySprzet()
    {
    }

    public void PokazSprzetWypozyczony()
    {
    }

    public void PokazAktywneWypozyczenia()
    {
    }

    public void PokazPrzeterminowaneWypozyczenia()
    {
    }

    public void GenerujRaport()
    {
    }

    public static void PokazWszystkichUsers()
    {
        foreach (Person y in Users)
            if (y is Student strudent)
                Console.WriteLine(
                    $"Student: ID_USER: {strudent.idPerson}, NR_INDEXU: {strudent.NrStudenta}, IMIE: {strudent.imie}, NAZWISKO: {strudent.nazwisko}");
            else if (y is Pracownik pracownik)
                Console.WriteLine($"Pracownik: ID_USER: {pracownik.idPerson}, IMIE: {pracownik.imie}, " +
                                  $"NAZWISKO: {pracownik.nazwisko} " +
                                  $"POZIOM_DOSTĘPU: {pracownik.PoziomDostepu}");
    }
}