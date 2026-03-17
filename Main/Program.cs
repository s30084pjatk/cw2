using ConsoleApp1;
        
        

        Person r1 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Adam", "Małysz", EnumPracownikPoziomDostepu.Poziom_Czerwony);
        Person r2 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Robert", "Kubica", EnumPracownikPoziomDostepu.Poziom_Niebieski);
        Person r3 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Justyna", "Kowalczyk", EnumPracownikPoziomDostepu.Poziom_Zielony);
        Person r4 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Mariusz", "Pudzianowski", EnumPracownikPoziomDostepu.Poziom_Czerwony);
        Person r5 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Otylia", "Jędrzejczak", EnumPracownikPoziomDostepu.Poziom_Niebieski);
        Person r6 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Tomasz", "Adamek", EnumPracownikPoziomDostepu.Poziom_Zielony);
        Person r7 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Kamil", "Stoch", EnumPracownikPoziomDostepu.Poziom_Czerwony);
        Person r8 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Anita", "Włodarczyk", EnumPracownikPoziomDostepu.Poziom_Niebieski);
        Person r9 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Paweł", "Fajdek", EnumPracownikPoziomDostepu.Poziom_Zielony);
        Person r10 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Wojciech", "Nowicki", EnumPracownikPoziomDostepu.Poziom_Czerwony);
        Service.DodajUzytkownika(r1);
        Service.DodajUzytkownika(r2);
        Service.DodajUzytkownika(r3);
        Service.DodajUzytkownika(r4);
        Service.DodajUzytkownika(r5);
        Service.DodajUzytkownika(r6);
        Service.DodajUzytkownika(r7);
        Service.DodajUzytkownika(r8);
        Service.DodajUzytkownika(r9);
        Service.DodajUzytkownika(r10);
        
        Person s1 = new Student(GeneratorAjdikow.LastPersonId(), "Jan", "Kowalski", EnumTypWypozyczajacego.Student, "s"+GeneratorAjdikow.LastIndexNO());
        Person s2 = new Student(GeneratorAjdikow.LastPersonId(), "Anna", "Nowak", EnumTypWypozyczajacego.Student, "s"+GeneratorAjdikow.LastIndexNO());
        Person s3 = new Student(GeneratorAjdikow.LastPersonId(), "Piotr", "Wiśniewski", EnumTypWypozyczajacego.Student, "s"+GeneratorAjdikow.LastIndexNO());
        Person s4 = new Student(GeneratorAjdikow.LastPersonId(), "Maria", "Wójcik", EnumTypWypozyczajacego.Student, "s"+GeneratorAjdikow.LastIndexNO());
        Person s5 = new Student(GeneratorAjdikow.LastPersonId(), "Tomasz", "Kowalczyk", EnumTypWypozyczajacego.Student, "s"+GeneratorAjdikow.LastIndexNO());
        Person s6 = new Student(GeneratorAjdikow.LastPersonId(), "Katarzyna", "Kamińska", EnumTypWypozyczajacego.Student, "s"+GeneratorAjdikow.LastIndexNO());
        Person s7 = new Student(GeneratorAjdikow.LastPersonId(), "Michał", "Lewandowski", EnumTypWypozyczajacego.Student, "s"+GeneratorAjdikow.LastIndexNO());
        Person s8 = new Student(GeneratorAjdikow.LastPersonId(), "Agnieszka", "Zielińska", EnumTypWypozyczajacego.Student, "s"+GeneratorAjdikow.LastIndexNO());
        Person s9 = new Student(GeneratorAjdikow.LastPersonId(), "Krzysztof", "Szymański", EnumTypWypozyczajacego.Student, "s"+GeneratorAjdikow.LastIndexNO());
        Person s10 = new Student(GeneratorAjdikow.LastPersonId(), "Małgorzata", "Woźniak", EnumTypWypozyczajacego.Student, "s"+GeneratorAjdikow.LastIndexNO());
        Service.DodajUzytkownika(s1);
        Service.DodajUzytkownika(s2);
        Service.DodajUzytkownika(s3);
        Service.DodajUzytkownika(s4);
        Service.DodajUzytkownika(s5);
        Service.DodajUzytkownika(s6);
        Service.DodajUzytkownika(s7);
        Service.DodajUzytkownika(s8);
        Service.DodajUzytkownika(s9);
        Service.DodajUzytkownika(s10);
        
        Device l1 = new Laptop(GeneratorAjdikow.LastDeviceId(), "Dell XPS 15", true, 32, "Intel i7");
        Device l2 = new Laptop(GeneratorAjdikow.LastDeviceId(), "MacBook Pro 14", true, 16, "Apple M2");
        Device l3 = new Laptop(GeneratorAjdikow.LastDeviceId(), "Lenovo ThinkPad X1", true, 16, "Intel i5");
        Device l4 = new Laptop(GeneratorAjdikow.LastDeviceId(), "HP EliteBook", false, 32, "Intel i7");
        Device l5 = new Laptop(GeneratorAjdikow.LastDeviceId(), "Asus ROG Strix", true, 64, "AMD Ryzen 9");
        Device l6 = new Laptop(GeneratorAjdikow.LastDeviceId(), "Acer Swift 3", true, 8, "AMD Ryzen 5");
        Device l7 = new Laptop(GeneratorAjdikow.LastDeviceId(), "Microsoft Surface", false, 16, "Intel i5");
        Device l8 = new Laptop(GeneratorAjdikow.LastDeviceId(), "Razer Blade 15", true, 32, "Intel i9");
        Device l9 = new Laptop(GeneratorAjdikow.LastDeviceId(), "MSI Gaming", true, 64, "Intel i9");
        Device l10 = new Laptop(GeneratorAjdikow.LastDeviceId(), "LG Gram", true, 16, "Intel i7");
        Service.DodajSprzet(l1);
        Service.DodajSprzet(l2);
        Service.DodajSprzet(l3);
        Service.DodajSprzet(l4);
        Service.DodajSprzet(l5);
        Service.DodajSprzet(l6);
        Service.DodajSprzet(l7);
        Service.DodajSprzet(l8);
        Service.DodajSprzet(l9);
        Service.DodajSprzet(l10);

        Device p1 = new Projector(GeneratorAjdikow.LastDeviceId(), "Epson EB-695Wi", true, 3500, "1920x1080");
        Device p2 = new Projector(GeneratorAjdikow.LastDeviceId(), "BenQ TH585", true, 3200, "1920x1080");
        Device p3 = new Projector(GeneratorAjdikow.LastDeviceId(), "Sony VPL-FHZ55", false, 4000, "3840x2160");
        Device p4 = new Projector(GeneratorAjdikow.LastDeviceId(), "Optoma UHD50", true, 3000, "3840x2160");
        Device p5 = new Projector(GeneratorAjdikow.LastDeviceId(), "ViewSonic PX747", true, 3500, "3840x2160");
        Device p6 = new Projector(GeneratorAjdikow.LastDeviceId(), "Panasonic PT-VZ580", false, 4000, "1920x1200");
        Device p7 = new Projector(GeneratorAjdikow.LastDeviceId(), "NEC NP-P452H", true, 4500, "1920x1080");
        Device p8 = new Projector(GeneratorAjdikow.LastDeviceId(), "Acer H6815", true, 3200, "1920x1080");
        Device p9 = new Projector(GeneratorAjdikow.LastDeviceId(), "LG PF50KA", true, 600, "1920x1080");
        Device p10 = new Projector(GeneratorAjdikow.LastDeviceId(), "Samsung The Freestyle", true, 550, "1920x1080");
        Service.DodajSprzet(p1);
        Service.DodajSprzet(p2);
        Service.DodajSprzet(p3);
        Service.DodajSprzet(p4);
        Service.DodajSprzet(p5);
        Service.DodajSprzet(p6);
        Service.DodajSprzet(p7);
        Service.DodajSprzet(p8);
        Service.DodajSprzet(p9);
        Service.DodajSprzet(p10);
        
        Device m1 = new Mouse(GeneratorAjdikow.LastDeviceId(), "Logitech MX Master 3", true, true, 4000);
        Device m2 = new Mouse(GeneratorAjdikow.LastDeviceId(), "Razer DeathAdder V2", true, false, 16000);
        Device m3 = new Mouse(GeneratorAjdikow.LastDeviceId(), "SteelSeries Rival 600", true, false, 12000);
        Device m4 = new Mouse(GeneratorAjdikow.LastDeviceId(), "Corsair M65 RGB", false, false, 18000);
        Device m5 = new Mouse(GeneratorAjdikow.LastDeviceId(), "HyperX Pulsefire FPS", true, false, 6200);
        Device m6 = new Mouse(GeneratorAjdikow.LastDeviceId(), "Microsoft Classic", true, true, 1000);
        Device m7 = new Mouse(GeneratorAjdikow.LastDeviceId(), "Apple Magic Mouse", true, true, 1300);
        Device m8 = new Mouse(GeneratorAjdikow.LastDeviceId(), "Genius XScroll", false, true, 800);
        Device m9 = new Mouse(GeneratorAjdikow.LastDeviceId(), "Trust GXT 155", true, false, 2400);
        Device m10 = new Mouse(GeneratorAjdikow.LastDeviceId(), "ASUS ROG Gladius III", true, false, 19000);
        Service.DodajSprzet(m1);
        Service.DodajSprzet(m2);
        Service.DodajSprzet(m3);
        Service.DodajSprzet(m4);
        Service.DodajSprzet(m5);
        Service.DodajSprzet(m6);
        Service.DodajSprzet(m7);
        Service.DodajSprzet(m8);
        Service.DodajSprzet(m9);
        Service.DodajSprzet(m10);

        //Service.ShowAllDevices();
        //Service.PokazWszystkichUsers();
        Service.UsunTrwaleSprzet(p5);
        //Service.ShowAllDevices();
        Service.PokazSprzetZutylizowany();
        Service.UsunTrwaleSprzet(p5);
        //Service.PokazSprzetZutylizowany();
        

        
      