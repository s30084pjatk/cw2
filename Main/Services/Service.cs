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

            if (CzySprzetWypozyczony(deviceParent))
            {
                throw new InvalidOperationException(
                    $"Nie można usunąć sprzętu {deviceParent.Nazwa}, ponieważ jest aktualnie wypożyczony!");
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

    public void showMouseOnly() //- READY----------------------------------------------------------------------
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
            if (wyp.Osoba == osoba)
            {
                licznik++;
            }
        }

        return licznik;
    }

    private static bool
        CzySprzetWypozyczony(
            Device_parent deviceParent) //- READY----------------------------------------------------------------------
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

    public void PokazDostepnySprzet() //- READY----------------------------------------------------------------------
    {
        foreach (Device_parent dev in Devices)
        {
            if (dev.Dostepnosc && !CzySprzetWypozyczony(dev))
            {
                if (dev is Laptop laptop)
                    Console.WriteLine($"Laptop: ID: {laptop.Id}, NAZWA: {laptop.Nazwa}");
                else if (dev is Projector projector)
                    Console.WriteLine($"Projektor: ID: {projector.Id}, NAZWA: {projector.Nazwa}");
                else if (dev is Mouse mouse)
                    Console.WriteLine($"Mysz: ID: {mouse.Id}, NAZWA: {mouse.Nazwa}");
            }
        }
    }

    // WYPOŻYCZ SPRZĘT - READY________________________________________________________________________
    public void Wypozycz(Device_parent deviceParent, Person_parent personParent)
    {
        try
        {
            if (!Users.Contains(personParent))
            {
                throw new InvalidOperationException(
                    $"Użytkownik {personParent.imie} {personParent.nazwisko} nie istnieje w systemie.");
            }

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
                    $"Użytkownik {personParent.EnumTyp} {personParent.imie} {personParent.nazwisko} przekroczył limit wypożyczeń ({limit}). " +
                    $"Aktualnie ma {aktywneWypozyczenia} aktywnych wypożyczeń.");
            }

            DateTime terminZwrotu = DateTime.Now.AddDays(14);
            Wypozyczenie wypozyczenie = new Wypozyczenie(personParent, deviceParent, DateTime.Now, terminZwrotu);
            Rentals.Add(wypozyczenie);
            deviceParent.Dostepnosc = false;
            if (deviceParent is Laptop laptop)
            {
                Console.WriteLine($"Wypożyczono sprzęt: laptop {laptop.Nazwa}");
            }
            else if (deviceParent is Projector projector)
            {
                Console.WriteLine($"Wypożyczono sprzęt: projektor {projector.Nazwa}");
            }
            else if (deviceParent is Mouse mouse)
            {
                Console.WriteLine($"Wypożyczono sprzęt: mysz {mouse.Nazwa}");
            }

            Console.WriteLine($"Użytkownik: {personParent.imie} {personParent.nazwisko} ({personParent.EnumTyp})");
            Console.WriteLine($"Termin zwrotu: {terminZwrotu:dd.MM.yyyy}");
            Console.WriteLine($"ID wypożyczenia: {wypozyczenie.Id}");
            if (limit - (aktywneWypozyczenia + 1) > 0)
            {
                Console.WriteLine($"{personParent.EnumTyp} może wypożyczyć jeszcze " +
                                  $"{limit - (aktywneWypozyczenia + 1)} sprzęt/sprzęty.");
            }
            else if (limit - (aktywneWypozyczenia + 1) == 0)
            {
                Console.WriteLine($"Limit wypożyczeń ({limit}) przez {personParent.EnumTyp} został wykorzystany. " +
                                  $"Brak możliwości realizacji kolejnego wypożyczenia.");
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Błąd wypożyczenia: {ex.Message}");
        }
    }


    // ZWROT SPRZĘTU - READY_____________________________________________________________
    public void Zwroc(Device_parent deviceParent, int RentalDaysDuration)
    {
        try
        {
            if (!Devices.Contains(deviceParent))
            {
                throw new InvalidOperationException(
                    $"Sprzęt ID: {deviceParent.Id}, NAZWA {deviceParent.Nazwa} nie istnieje w systemie.");
            }

            Wypozyczenie aktywneWypozyczenie = ZnajdzAktywneWypozyczenieSprzetu(deviceParent);
            if (aktywneWypozyczenie == null)
            {
                throw new InvalidOperationException(
                    $"Brak aktywnego wypożyczenia dla sprzętu ID: {deviceParent.Id}, NAZWA {deviceParent.Nazwa}");
            }

            aktywneWypozyczenie.FaktycznaDataZwrotu = DateTime.Now;
            deviceParent.Dostepnosc = true;
            DateTime dataWypozyczenia = aktywneWypozyczenie.DataWypozyczenia;
            DateTime terminZwrotu = aktywneWypozyczenie.TerminZwrotu.Value;
            DateTime symulowanaDataZwrotu = dataWypozyczenia.AddDays(RentalDaysDuration);

            int kara = 0;
            int dniOpoznienia = 0;
            if (symulowanaDataZwrotu > terminZwrotu)
            {
                dniOpoznienia = (symulowanaDataZwrotu - terminZwrotu).Days;
                kara = dniOpoznienia * 10; // 10 zł za dzień opóźnienia
                aktywneWypozyczenie.Kara = kara;
            }
            else
            {
                aktywneWypozyczenie.Kara = 0;
            }

            if (deviceParent is Laptop laptop)
            {
                Console.WriteLine($"Zwrócono sprzęt: laptop {laptop.Nazwa}");
            }
            else if (deviceParent is Projector projector)
            {
                Console.WriteLine($"Zwrócono sprzęt: projektor {projector.Nazwa}");
            }
            else if (deviceParent is Mouse mouse)
            {
                Console.WriteLine($"Zwrócono sprzęt: mysz {mouse.Nazwa}");
            }

            Console.WriteLine($"Użytkownik: {aktywneWypozyczenie.Osoba.imie} {aktywneWypozyczenie.Osoba.nazwisko}");
            Console.WriteLine($"Data wypożyczenia: {dataWypozyczenia:dd.MM.yyyy}");
            Console.WriteLine($"Wstępny termin zwrotu: {terminZwrotu:dd.MM.yyyy}");
            Console.WriteLine(
                $"Symulowana data zwrotu: {symulowanaDataZwrotu:dd.MM.yyyy} (po {RentalDaysDuration} dniach)");
            if (kara > 0)
                Console.WriteLine($"Kara: {kara} zł (opóźnienie {dniOpoznienia} dni)");
            else
                Console.WriteLine($"Zwrot w terminie - brak kary");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Błąd zwrotu: {ex.Message}");
        }
    }

    private Wypozyczenie
        ZnajdzAktywneWypozyczenieSprzetu(
            Device_parent deviceParent) //- READY----------------------------------------------------------------------
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