using ConsoleApp1;

Service service = new Service();

Person_parent r1 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Adam", "Małysz",
    EnumPracownikPoziomDostepu.Poziom_Czerwony);
Person_parent r2 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Robert", "Kubica",
    EnumPracownikPoziomDostepu.Poziom_Niebieski);
Person_parent r3 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Justyna", "Kowalczyk",
    EnumPracownikPoziomDostepu.Poziom_Zielony);
Person_parent r4 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Mariusz", "Pudzianowski",
    EnumPracownikPoziomDostepu.Poziom_Czerwony);
Person_parent r5 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Otylia", "Jędrzejczak",
    EnumPracownikPoziomDostepu.Poziom_Niebieski);
Person_parent r6 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Tomasz", "Adamek",
    EnumPracownikPoziomDostepu.Poziom_Zielony);
Person_parent r7 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Kamil", "Stoch",
    EnumPracownikPoziomDostepu.Poziom_Czerwony);
Person_parent r8 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Anita", "Włodarczyk",
    EnumPracownikPoziomDostepu.Poziom_Niebieski);
Person_parent r9 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Paweł", "Fajdek",
    EnumPracownikPoziomDostepu.Poziom_Zielony);
Person_parent r10 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Wojciech", "Nowicki",
    EnumPracownikPoziomDostepu.Poziom_Czerwony);
service.DodajUzytkownika(r1);
service.DodajUzytkownika(r2);
service.DodajUzytkownika(r3);
service.DodajUzytkownika(r4);
service.DodajUzytkownika(r5);
service.DodajUzytkownika(r6);
service.DodajUzytkownika(r7);
service.DodajUzytkownika(r8);
service.DodajUzytkownika(r9);
service.DodajUzytkownika(r10);

Person_parent s1 = new Student(GeneratorAjdikow.LastPersonId(), "Jan", "Kowalski", EnumTypWypozyczajacego.Student,
    "s" + GeneratorAjdikow.LastIndexNO());
Person_parent s2 = new Student(GeneratorAjdikow.LastPersonId(), "Anna", "Nowak", EnumTypWypozyczajacego.Student,
    "s" + GeneratorAjdikow.LastIndexNO());
Person_parent s3 = new Student(GeneratorAjdikow.LastPersonId(), "Piotr", "Wiśniewski", EnumTypWypozyczajacego.Student,
    "s" + GeneratorAjdikow.LastIndexNO());
Person_parent s4 = new Student(GeneratorAjdikow.LastPersonId(), "Maria", "Wójcik", EnumTypWypozyczajacego.Student,
    "s" + GeneratorAjdikow.LastIndexNO());
Person_parent s5 = new Student(GeneratorAjdikow.LastPersonId(), "Tomasz", "Kowalczyk", EnumTypWypozyczajacego.Student,
    "s" + GeneratorAjdikow.LastIndexNO());
Person_parent s6 = new Student(GeneratorAjdikow.LastPersonId(), "Katarzyna", "Kamińska", EnumTypWypozyczajacego.Student,
    "s" + GeneratorAjdikow.LastIndexNO());
Person_parent s7 = new Student(GeneratorAjdikow.LastPersonId(), "Michał", "Lewandowski", EnumTypWypozyczajacego.Student,
    "s" + GeneratorAjdikow.LastIndexNO());
Person_parent s8 = new Student(GeneratorAjdikow.LastPersonId(), "Agnieszka", "Zielińska",
    EnumTypWypozyczajacego.Student,
    "s" + GeneratorAjdikow.LastIndexNO());
Person_parent s9 = new Student(GeneratorAjdikow.LastPersonId(), "Krzysztof", "Szymański",
    EnumTypWypozyczajacego.Student,
    "s" + GeneratorAjdikow.LastIndexNO());
Person_parent s10 = new Student(GeneratorAjdikow.LastPersonId(), "Małgorzata", "Woźniak",
    EnumTypWypozyczajacego.Student,
    "s" + GeneratorAjdikow.LastIndexNO());
service.DodajUzytkownika(s1);
service.DodajUzytkownika(s2);
service.DodajUzytkownika(s3);
service.DodajUzytkownika(s4);
service.DodajUzytkownika(s5);
service.DodajUzytkownika(s6);
service.DodajUzytkownika(s7);
service.DodajUzytkownika(s8);
service.DodajUzytkownika(s9);
service.DodajUzytkownika(s10);

Device_parent l1 = new Laptop(GeneratorAjdikow.LastDeviceId(), "Dell XPS 15", true, 32, "Intel i7");
Device_parent l2 = new Laptop(GeneratorAjdikow.LastDeviceId(), "MacBook Pro 14", true, 16, "Apple M2");
Device_parent l3 = new Laptop(GeneratorAjdikow.LastDeviceId(), "Lenovo ThinkPad X1", true, 16, "Intel i5");
Device_parent l4 = new Laptop(GeneratorAjdikow.LastDeviceId(), "HP EliteBook", true, 32, "Intel i7");
Device_parent l5 = new Laptop(GeneratorAjdikow.LastDeviceId(), "Asus ROG Strix", true, 64, "AMD Ryzen 9");
Device_parent l6 = new Laptop(GeneratorAjdikow.LastDeviceId(), "Acer Swift 3", true, 8, "AMD Ryzen 5");
Device_parent l7 = new Laptop(GeneratorAjdikow.LastDeviceId(), "Microsoft Surface", true, 16, "Intel i5");
Device_parent l8 = new Laptop(GeneratorAjdikow.LastDeviceId(), "Razer Blade 15", true, 32, "Intel i9");
Device_parent l9 = new Laptop(GeneratorAjdikow.LastDeviceId(), "MSI Gaming", true, 64, "Intel i9");
Device_parent l10 = new Laptop(GeneratorAjdikow.LastDeviceId(), "LG Gram", true, 16, "Intel i7");
service.DodajSprzet(l1);
service.DodajSprzet(l2);
service.DodajSprzet(l3);
service.DodajSprzet(l4);
service.DodajSprzet(l5);
service.DodajSprzet(l6);
service.DodajSprzet(l7);
service.DodajSprzet(l8);
service.DodajSprzet(l9);
service.DodajSprzet(l10);

Device_parent p1 = new Projector(GeneratorAjdikow.LastDeviceId(), "Epson EB-695Wi", true, 3500, "1920x1080");
Device_parent p2 = new Projector(GeneratorAjdikow.LastDeviceId(), "BenQ TH585", true, 3200, "1920x1080");
Device_parent p3 = new Projector(GeneratorAjdikow.LastDeviceId(), "Sony VPL-FHZ55", true, 4000, "3840x2160");
Device_parent p4 = new Projector(GeneratorAjdikow.LastDeviceId(), "Optoma UHD50", true, 3000, "3840x2160");
Device_parent p5 = new Projector(GeneratorAjdikow.LastDeviceId(), "ViewSonic PX747", true, 3500, "3840x2160");
Device_parent p6 = new Projector(GeneratorAjdikow.LastDeviceId(), "Panasonic PT-VZ580", true, 4000, "1920x1200");
Device_parent p7 = new Projector(GeneratorAjdikow.LastDeviceId(), "NEC NP-P452H", true, 4500, "1920x1080");
Device_parent p8 = new Projector(GeneratorAjdikow.LastDeviceId(), "Acer H6815", true, 3200, "1920x1080");
Device_parent p9 = new Projector(GeneratorAjdikow.LastDeviceId(), "LG PF50KA", true, 600, "1920x1080");
Device_parent p10 = new Projector(GeneratorAjdikow.LastDeviceId(), "Samsung The Freestyle", true, 550, "1920x1080");
service.DodajSprzet(p1);
service.DodajSprzet(p2);
service.DodajSprzet(p3);
service.DodajSprzet(p4);
service.DodajSprzet(p5);
service.DodajSprzet(p6);
service.DodajSprzet(p7);
service.DodajSprzet(p8);
service.DodajSprzet(p9);
service.DodajSprzet(p10);

Device_parent m1 = new Mouse(GeneratorAjdikow.LastDeviceId(), "Logitech MX Master 3", true, true, 4000);
Device_parent m2 = new Mouse(GeneratorAjdikow.LastDeviceId(), "Razer DeathAdder V2", true, false, 16000);
Device_parent m3 = new Mouse(GeneratorAjdikow.LastDeviceId(), "SteelSeries Rival 600", true, false, 12000);
Device_parent m4 = new Mouse(GeneratorAjdikow.LastDeviceId(), "Corsair M65 RGB", true, false, 18000);
Device_parent m5 = new Mouse(GeneratorAjdikow.LastDeviceId(), "HyperX Pulsefire FPS", true, false, 6200);
Device_parent m6 = new Mouse(GeneratorAjdikow.LastDeviceId(), "Microsoft Classic", true, true, 1000);
Device_parent m7 = new Mouse(GeneratorAjdikow.LastDeviceId(), "Apple Magic Mouse", true, true, 1300);
Device_parent m8 = new Mouse(GeneratorAjdikow.LastDeviceId(), "Genius XScroll", true, true, 800);
Device_parent m9 = new Mouse(GeneratorAjdikow.LastDeviceId(), "Trust GXT 155", true, false, 2400);
Device_parent m10 = new Mouse(GeneratorAjdikow.LastDeviceId(), "ASUS ROG Gladius III", true, false, 19000);
service.DodajSprzet(m1);
service.DodajSprzet(m2);
service.DodajSprzet(m3);
service.DodajSprzet(m4);
service.DodajSprzet(m5);
service.DodajSprzet(m6);
service.DodajSprzet(m7);
service.DodajSprzet(m8);
service.DodajSprzet(m9);
service.DodajSprzet(m10);


Console.WriteLine("\n-- Pokaż wszyskich aktywne urządzenia");
service.ShowAllDevices();
Console.WriteLine("\n-- Pokaż tylko aktywne urządzenia - laptopy");
service.showLaptopsOnly();
Console.WriteLine("\n-- Pokaż tylko aktywne urządzenia - projektory");
service.showProjectorsOnly();
Console.WriteLine("\n-- Pokaż tylko aktywne urządzenia - myszki");
service.showMouseOnly();
Console.WriteLine("\n-- Pokaż sprzęt niezdatny do wypożyczenia -> pusta lista");
service.PokazSprzetZutylizowany();
Console.WriteLine("\n-- Usuwanie sprzętu p5");
service.UsunTrwaleSprzet(p5);
Console.WriteLine("\n-- Pokaż ponownie sprzęt niezdatny do wypożyczenia -> usuniety sprzęt to pojektor");
service.PokazSprzetZutylizowany();
Console.WriteLine("\n-- Próba ponowniego usunięcia tego samego sprzętu z listy aktywnych sprzętów -> błąd");
service.UsunTrwaleSprzet(p5);
Console.WriteLine("\n-- Pokaż wszyskich aktywnych użytkowników");
service.PokazAktywnychUsers();
Console.WriteLine("\n-- Usuń usera pracownika r3");
service.UsunUsera(r3);
Console.WriteLine("\n-- Próba ponownego usuniecia usera(pracownika) r3 -> niepowodzenie");
service.UsunUsera(r3);
Console.WriteLine("\n-- Usuń usera studenta s5");
service.UsunUsera(s5);
Console.WriteLine("\n-- Próba ponownego usuniecia usera(studenta) s5 -> niepowodzenie");
service.UsunUsera(s5);
Console.WriteLine("\n-- Pokaż wszyskich aktywnych użytkowników - tym razem bez usera r3 i s5");
service.PokazAktywnychUsers();


Console.WriteLine("\n============ SYMULACJA FUNKCJONALNOŚCI ============");
Console.WriteLine("\n-- Próba wypożyczenia laptopa l1 przez STUDENTA s1. Limit wypożyczeń 2->1");
service.Wypozycz(l1, s1);
Console.WriteLine("\n-- Próba wypożyczenia projektora p1 przez tego samego STUDENTA s1. Limit wypożyczeń 1->0.");
service.Wypozycz(p1, s1);
Console.WriteLine("\n-- Próba wypożyczenia myszki m1 przez tego samego " +
                  "STUDENTA s1 -> limit wypożyczeń został osiągnięty.");
service.Wypozycz(m1, s1);
Console.WriteLine("\n-- Próba wypożyczenia laptopa l2 przez PRACOWNIKA r1 " +
                  "- pokażanie iż wypożyczenie działa również dla PRACOWNIKA");
service.Wypozycz(l2, r1);
Console.WriteLine("\n-- Zwrot laptopa l1 w terminie 7 dni od daty wypożyczenia");
service.Zwroc(l1, 2);
Console.WriteLine("\n-- Zwrot laptopa l2 wypożyczonego przez PRACOWNIKA " +
                  "w terminie 20 dni od wypożyczenia");
service.Zwroc(l2, 20);
Console.WriteLine("\n-- Próba zwrotu sprzętu, który nie został wypożyczony -> błąd.");
service.Zwroc(m1, 2);
Console.WriteLine("\n-- Pokazanie listy sprzętu dostępnego do wypożyczenia -> brakuje " +
                  "projektora ID = 11, projektor Epson EB-695Wi");
service.PokazDostepnySprzet();
Console.WriteLine("\n-- Zwrot sprzętu projektor ID1, Epson EB-695Wi");
service.Zwroc(p1, 2);
Console.WriteLine("\n-- Pokazanie, iż zwrot przebieg pomyślnie a urządzenie wróciło " +
                  "na listę urządzeń gotowych do wypożycznia.");
service.PokazDostepnySprzet();
Console.WriteLine("\n-- Próba wypożyczenia sprzętu osobie STUDENT S5, który został prześniej " +
                  "usuniety z systemu -> błąd wypożyczenia.");
service.Wypozycz(l3, s5);
Console.WriteLine("\n-- Wypożyczenie sprzętu l3 przez STUDENTA S7 -> powodzenie");
service.Wypozycz(l3, s7);
Console.WriteLine(
    "\n-- Wypożyczenie sprzętu l3 przez STUDENTA S8 -> błąd, sprzęt l3 nie jest dostępny do wypożyczenia.");
service.Wypozycz(l3, s8);
Console.WriteLine(
    "\n-- Próba przesunięcia wypożyczonego sprzętu na listę urządzeń przeznaczonych do utylizacji -> błąd.");
service.UsunTrwaleSprzet(l3);
Console.WriteLine("\n-- Usuwanie sprzętu p7 na listę do utylizacji/zarchiwizowania, aby w następny kroku pokazać " +
                  "brak możliwości wypożyczenia usuniętego sprzętu - powodzenie.");
service.UsunTrwaleSprzet(p7);
service.Wypozycz(p7, r10);
Console.WriteLine("\n-- Próba dwukrotnego wypożyczenia tego samego sprzętu - niepowodzenie.");
service.Wypozycz(p4, r10);
service.Wypozycz(p4, s7);

//brakuje raportu, lista aktywnych wypożyczeń + jakaś dokumentacyjka