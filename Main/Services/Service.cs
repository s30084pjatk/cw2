namespace ConsoleApp1;

public class Service
{
    public static List<Device_parent> Devices = new();
    public static List<Person_parent> Users = new();
    public static List<Device_parent> ZutylizowanySprzet = new();
    public static List<Wypozyczenie> Rentals = new();

    //DODAJ SPRZET DO LISTY - READY----------------------------------------------------------------
    public void DodajSprzet(Device_parent deviceParent)
    {
        Devices.Add(deviceParent);
    }

    //USUŃ SPRZĘT I PRZENIEŚ DO ARCHIWUM. READY----------------------------------------------------------------
    public void UsunTrwaleSprzet(Device_parent deviceParent)
    {
        try
        {
            if (!Devices.Contains(deviceParent))
            {
                throw new InvalidOperationException(
                    $"Sprzęt {deviceParent}, ID: {deviceParent.Id}, {deviceParent.Nazwa} nie istnieje na liście.");
            }

            ZutylizowanySprzet.Add(deviceParent);
            Devices.Remove(deviceParent);
            Console.WriteLine(
                $"Sprzęt: ID:{deviceParent.Id}, NAZWA: {deviceParent.Nazwa} został pomyślnie zarchiwizowany.");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    //POKAŻ TYLKO LAPTOPS - READY----------------------------------------------------------------------
    public void showLaptopsOnly()
    {
        foreach (Device_parent laptops in Devices)
        {
            if (laptops is Laptop laptop)
            {
                Console.WriteLine(
                    $"Laptop: ID: {laptop.Id}, NAZWA: {laptop.Nazwa}, RAM: {laptop.RamGB}GB, CPU: {laptop.CPU}");
            }
        }
    }

    //POKAŻ TYLKO PROJEKTORY - READY----------------------------------------------------------------------
    public void showProjectorsOnly()
    {
        foreach (Device_parent projectiors in Devices)
        {
            if (projectiors is Projector projector)
            {
                Console.WriteLine($"Projektor: ID: {projector.Id}, NAZWA: {projector.Nazwa}, " +
                                  $"JASNOSC: {projector.Jasnosc}, ROZDZIELCZOSC: {projector.Rozdzielczosc}");
            }
        }
    }

    public void showMouseOnly()
    {
        foreach (Device_parent mouses in Devices)
        {
            if (mouses is Mouse mouse)
            {
                Console.WriteLine($"Mysz: ID: {mouse.Id}, NAZWA: {mouse.Nazwa}, " +
                                  $"BEZPRZEWODOWA: {mouse.Bezprzewodowa}, DPI: {mouse.DPI}");
            }
        }
    }


// POKAZ SPRZĘT ZARCHIWIZOWANY - READY----------------------------------------------------------------
    public void PokazSprzetZutylizowany()
    {
        if (ZutylizowanySprzet.Count == 0)
        {
            Console.WriteLine("Lista sprzętu zarchiwizowanego jest pusta");
            return;
        }

        foreach (Device_parent zutylizowany in ZutylizowanySprzet)
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
    public void DodajUzytkownika(Person_parent personParent)
    {
        Users.Add(personParent);
    }
    //USUŃ USERA - READY------------------------------------------------------------------------

    public void UsunUsera(Person_parent personParent)
    {
        try
        {
            if (!Users.Contains(personParent))
            {
                throw new InvalidOperationException(
                    $"Użytkownik {personParent}, ID: {personParent.idPerson}, IMIE: {personParent.imie}, NAZWISKO: {personParent.nazwisko}, " +
                    $"TYP_USERA: {personParent.EnumTyp} -> nie istnieje na liście.");
            }

            Users.Remove(personParent);
            Console.WriteLine(
                $"Użytkownik {personParent}, ID: {personParent.idPerson}, IMIE: {personParent.imie}, NAZWISKO: {personParent.nazwisko}, " +
                $"TYP_USERA: {personParent.EnumTyp} -> został poprawnie usunięty.");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    //ILE AKTYWNYCH WYPOŻYCZEŃ - READY--------------------------------------------------
    private static int PoliczAktywneWypozyczenia(Person_parent osoba)
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

    private static bool CzySprzetWypozyczony(Device_parent deviceParent)
    {
        foreach (Wypozyczenie wyp in Rentals)
        {
            if (wyp.Sprzet == deviceParent && wyp.FaktycznaDataZwrotu == null)
            {
                return true;
            }
        }

        return false;
    }

    // WYPOŻYCZ SPRZĘT - READY________________________________________________________________________
    public static void Wypozycz(Device_parent deviceParent, Person_parent personParent)
    {
        try
        {
            if (!Devices.Contains(deviceParent))
            {
                throw new InvalidOperationException($"Sprzęt {deviceParent.Nazwa} nie istnieje w systemie.");
            }

            if (!deviceParent.Dostepnosc)
            {
                throw new InvalidOperationException($"Sprzęt {deviceParent.Nazwa} jest niedostępny.");
            }

            if (CzySprzetWypozyczony(deviceParent))
            {
                throw new InvalidOperationException($"Sprzęt {deviceParent.Nazwa} jest już wypożyczony.");
            }

            //LIMITY DLA USEROW
            int limit = 0;
            if (personParent is Student)
            {
                limit = 2;
            }
            else if (personParent is Pracownik)
            {
                limit = 5;
            }

            int aktywneWypozyczenia = PoliczAktywneWypozyczenia(personParent);
            if (aktywneWypozyczenia >= limit)
            {
                throw new InvalidOperationException(
                    $"Użytkownik {personParent.imie} {personParent.nazwisko} przekroczył limit wypożyczeń ({limit}). " +
                    $"Aktualnie ma {aktywneWypozyczenia} aktywnych wypożyczeń.");
            }

            DateTime terminZwrotu = DateTime.Now.AddDays(14);
            Wypozyczenie wypozyczenie = new Wypozyczenie(personParent, deviceParent, DateTime.Now, terminZwrotu);
            Rentals.Add(wypozyczenie);
            deviceParent.Dostepnosc = false;

            Console.WriteLine($"Wypożyczono sprzęt: {deviceParent.Nazwa}");
            Console.WriteLine($"Użytkownik: {personParent.imie} {personParent.nazwisko} ({personParent.EnumTyp})");
            Console.WriteLine($"Termin zwrotu: {terminZwrotu:dd.MM.yyyy}");
            Console.WriteLine($"ID wypożyczenia: {wypozyczenie.Id}");
            Console.WriteLine($"Pozostało mu miejsc: {limit - (aktywneWypozyczenia + 1)}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($" Błąd wypożyczenia: {ex.Message}");
        }
    }

    // ZWROT SPRZĘTU - READY_____________________________________________________________
    public static void Zwroc(Device_parent deviceParent)
    {
        try
        {
            if (!Devices.Contains(deviceParent))
            {
                throw new InvalidOperationException($"Sprzęt {deviceParent.Nazwa} nie istnieje w systemie.");
            }

            Wypozyczenie aktywneWypozyczenie = null;
            foreach (Wypozyczenie w in Rentals)
            {
                if (w.Sprzet == deviceParent && w.FaktycznaDataZwrotu == null)
                {
                    aktywneWypozyczenie = w;
                    break;
                }
            }

            if (aktywneWypozyczenie == null)
            {
                throw new InvalidOperationException($"Brak aktywnego wypożyczenia dla sprzętu {deviceParent.Nazwa}");
            }

            //USTAWIANIE TERMINU ZWROTU
            aktywneWypozyczenie.FaktycznaDataZwrotu = DateTime.Now;

            if (DateTime.Now > aktywneWypozyczenie.TerminZwrotu)
            {
                int dniOpoznienia = (DateTime.Now - aktywneWypozyczenie.TerminZwrotu.Value).Days;
                aktywneWypozyczenie.Kara = dniOpoznienia * 10;
                Console.WriteLine($"UWAGA: Zwrot opóźniony o {dniOpoznienia} dni!");
                Console.WriteLine($"Naliczono karę: {aktywneWypozyczenie.Kara} + zł");
            }

            //RETURN DOSTEPNOŚCI
            deviceParent.Dostepnosc = true;

            //RE5PECTA
            Console.WriteLine($"Zwrócono sprzęt: {deviceParent.Nazwa}");
            Console.WriteLine($"Użytkownik: {aktywneWypozyczenie.Osoba.imie} {aktywneWypozyczenie.Osoba.nazwisko}");
            Console.WriteLine($"Data wypożyczenia: {aktywneWypozyczenie.DataWypozyczenia:dd.MM.yyyy}");
            Console.WriteLine($"Termin zwrotu: {aktywneWypozyczenie.TerminZwrotu:dd.MM.yyyy}");
            Console.WriteLine($"Data zwrotu: {aktywneWypozyczenie.FaktycznaDataZwrotu:dd.MM.yyyy}");
            if (aktywneWypozyczenie.Kara > 0)
                Console.WriteLine($"Kara: {aktywneWypozyczenie.Kara} zł");
            else
                Console.WriteLine($"Zwrot w terminie - brak kary");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Błąd zwrotu: {ex.Message}");
        }
    }

    private static Wypozyczenie ZnajdzAktywneWypozyczenie(Device_parent deviceParent)
    {
        foreach (Wypozyczenie wyp in Rentals)
        {
            if (wyp.Sprzet == deviceParent && wyp.FaktycznaDataZwrotu == null)
            {
                return wyp;
            }
        }

        return null;
    }


    //POKAŻ WASZYSKIE SPRZĘTY -READY ---------------------------------------------------------------------------
    public void ShowAllDevices()
    {
        foreach (Device_parent dev in Devices)
        {
            if (dev is Laptop laptop)
                Console.WriteLine($"Laptop: ID: {laptop.Id}, NAZWA: {laptop.Nazwa}, RAM: {laptop.RamGB}");
            else if (dev is Mouse mouse)
                Console.WriteLine($"Mysz: ID:{mouse.Id}, NAZWA: {mouse.Nazwa}, DPI: {mouse.DPI}");
            else if (dev is Projector projector)
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

    public void PokazAktywnychUsers()
    {
        foreach (Person_parent person in Users)
            if (person is Student strudent)
                Console.WriteLine(
                    $"Student: ID_USER: {strudent.idPerson}, NR_INDEXU: {strudent.NrStudenta}, IMIE: {strudent.imie}, NAZWISKO: {strudent.nazwisko}");
            else if (person is Pracownik pracownik)
                Console.WriteLine($"Pracownik: ID_USER: {pracownik.idPerson}, IMIE: {pracownik.imie}, " +
                                  $"NAZWISKO: {pracownik.nazwisko} " +
                                  $"POZIOM_DOSTĘPU: {pracownik.PoziomDostepu}");
    }
}