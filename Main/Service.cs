namespace ConsoleApp1;

public class Service
{
    public static List<Device> Devices = new();
    public static List<Person> Users = new();
    public static List<Device> ZutylizowanySprzet = new();
    public static List<Wypozyczenie> Rentals = new();

    //DODAJ SPRZET DO LISTY - READY----------------------------------------------------------------
    public static void DodajSprzet(Device device)
    {
        Devices.Add(device);
    }

    //USUŃ SPRZĘT I PRZENIEŚ DO ARCHIWUM. READY----------------------------------------------------------------
    public static void UsunTrwaleSprzet(Device device)
    {
        try
        {
            if (!Devices.Contains(device))
            {
                throw new InvalidOperationException(
                    $"Sprzęt {device}, ID: {device.Id}, {device.Nazwa} nie istnieje na liście.");
            }

            ZutylizowanySprzet.Add(device);
            Devices.Remove(device);
            Console.WriteLine($"Sprzęt: ID:{device.Id}, NAZWA: {device.Nazwa} został pomyślnie zarchiwizowany.");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

// POKAZ SPRZĘT ZARCHIWIZOWANY - READY----------------------------------------------------------------
    public static void PokazSprzetZutylizowany()
    {
        if (ZutylizowanySprzet.Count == 0)
        {
            Console.WriteLine("Lista sprzętu zarchiwizowanego jest pusta");
            return;
        }

        foreach (Device zutylizowany in ZutylizowanySprzet)
        {
            if (zutylizowany is Laptop laptop)
                Console.WriteLine($"Zutylizowany laptop: ID: {laptop.Id}, NAZWA: {laptop.Nazwa}, RAM: {laptop.RamGB}");
            else if (zutylizowany is Mouse mouse)
                Console.WriteLine($"Zutylizowana mysz: ID:{mouse.Id}, NAZWA: {mouse.Nazwa}, DPI: {mouse.DPI}");
            else if (zutylizowany is Projector projector)
                Console.WriteLine(
                    $"Zutylizowany projektor: ID:{projector.Id}, NAZWA: {projector.Nazwa}, JASNOŚĆ: {projector.Jasnosc} lumenów");
        }
    }

    //DODAJ_USERA - READY------------------------------------------------------------------------
    public static void DodajUzytkownika(Person person)
    {
        Users.Add(person);
    }
    //USUŃ USERA - READY------------------------------------------------------------------------

    public static void UsunUsera(Person person)
    {
        try
        {
            if (!Users.Contains(person))
            {
                throw new InvalidOperationException(
                    $"Użytkownik {person}, ID: {person.idPerson}, IMIE: {person.imie}, NAZWISKO: {person.nazwisko}, " +
                    $"TYP_USERA: {person.EnumTyp} -> nie istnieje na liście.");
            }
            Users.Remove(person);
            Console.WriteLine($"Użytkownik {person}, ID: {person.idPerson}, IMIE: {person.imie}, NAZWISKO: {person.nazwisko}, " +
                              $"TYP_USERA: {person.EnumTyp} -> został poprawnie usunięty.");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    
    //ILE AKTYWNYCH WYPOŻYCZEŃ - READY--------------------------------------------------
    private static int PoliczAktywneWypozyczenia(Person osoba)
    {
        int licznik = 0;
        foreach (Wypozyczenie wyp in Rentals)
        {
            if (wyp.Osoba == osoba && wyp.FaktycznaDataZwrotu == null)
            {
                licznik++;
            }
        }
        return licznik;
    }
    private static bool CzySprzetWypozyczony(Device device)
    {
        foreach (Wypozyczenie wyp in Rentals)
        {
            if (wyp.Sprzet == device && wyp.FaktycznaDataZwrotu == null)
            {
                return true;
            }
        }
        return false;
    }
    // WYPOŻYCZ SPRZĘT - READY________________________________________________________________________
public static void Wypozycz(Device device, Person person)
{
    try
    {
        if (!Devices.Contains(device))
        {
            throw new InvalidOperationException($"Sprzęt {device.Nazwa} nie istnieje w systemie.");
        }
        if (!device.Dostepnosc)
        {
            throw new InvalidOperationException($"Sprzęt {device.Nazwa} jest niedostępny.");
        }
        if (CzySprzetWypozyczony(device))
        {
            throw new InvalidOperationException($"Sprzęt {device.Nazwa} jest już wypożyczony.");
        }

        //LIMITY DLA USEROW
        int limit = 0;
        if (person is Student)
        {
            limit = 2;
        }
        else if (person is Pracownik)
        {
            limit = 5;
        }
        int aktywneWypozyczenia = PoliczAktywneWypozyczenia(person);
        if (aktywneWypozyczenia >= limit)
        {
            throw new InvalidOperationException(
                $"Użytkownik {person.imie} {person.nazwisko} przekroczył limit wypożyczeń ({limit}). " +
                $"Aktualnie ma {aktywneWypozyczenia} aktywnych wypożyczeń.");
        }
        DateTime terminZwrotu = DateTime.Now.AddDays(14);
        Wypozyczenie wypozyczenie = new Wypozyczenie(person, device, DateTime.Now, terminZwrotu);
        Rentals.Add(wypozyczenie);
        device.Dostepnosc = false;
        
        Console.WriteLine($"Wypożyczono sprzęt: {device.Nazwa}");
        Console.WriteLine($"Użytkownik: {person.imie} {person.nazwisko} ({person.EnumTyp})");
        Console.WriteLine($"Termin zwrotu: {terminZwrotu:dd.MM.yyyy}");
        Console.WriteLine($"ID wypożyczenia: {wypozyczenie.Id}");
        Console.WriteLine($"Pozostało mu miejsc: {limit - (aktywneWypozyczenia + 1)}");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($" Błąd wypożyczenia: {ex.Message}");
    }
}

    public void Zwroc(Device device)
    {
    }
    
    
    //POKAŻ WASZYSKIE SPRZĘTY -READY ---------------------------------------------------------------------------
    public static void ShowAllDevices()
    {
        foreach (Device x in Devices)
        {
            if (x is Laptop laptop)
                Console.WriteLine($"Laptop: ID: {laptop.Id}, NAZWA: {laptop.Nazwa}, RAM: {laptop.RamGB}");
            else if (x is Mouse mouse)
                Console.WriteLine($"Mysz: ID:{mouse.Id}, NAZWA: {mouse.Nazwa}, DPI: {mouse.DPI}");
            else if (x is Projector projector)
                Console.WriteLine(
                    $"Projektor: ID: {projector.Id}, NAZWA: {projector.Nazwa}, {projector.Jasnosc} lumenów");
        }
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

    public static void PokazAktywnychUsers()
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