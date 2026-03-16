using ConsoleApp1;

        Person p1 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Adam", "Małysz", EnumPracownikPoziomDostepu.Poziom_Czerwony);
        Person p2 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Robert", "Kubica", EnumPracownikPoziomDostepu.Poziom_Niebieski);
        Person p3 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Justyna", "Kowalczyk", EnumPracownikPoziomDostepu.Poziom_Zielony);
        Person p4 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Mariusz", "Pudzianowski", EnumPracownikPoziomDostepu.Poziom_Czerwony);
        Person p5 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Otylia", "Jędrzejczak", EnumPracownikPoziomDostepu.Poziom_Niebieski);
        Person p6 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Tomasz", "Adamek", EnumPracownikPoziomDostepu.Poziom_Zielony);
        Person p7 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Kamil", "Stoch", EnumPracownikPoziomDostepu.Poziom_Czerwony);
        Person p8 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Anita", "Włodarczyk", EnumPracownikPoziomDostepu.Poziom_Niebieski);
        Person p9 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Paweł", "Fajdek", EnumPracownikPoziomDostepu.Poziom_Zielony);
        Person p10 = new Pracownik(GeneratorAjdikow.LastPersonId(), "Wojciech", "Nowicki", EnumPracownikPoziomDostepu.Poziom_Czerwony);
 
        Person s1 = new Student(GeneratorAjdikow.LastPersonId(), "Jan", "Kowalski", EnumTypWypozyczajacego.Student, "s12345");
        Person s2 = new Student(GeneratorAjdikow.LastPersonId(), "Anna", "Nowak", EnumTypWypozyczajacego.Student, "s12346");
        Person s3 = new Student(GeneratorAjdikow.LastPersonId(), "Piotr", "Wiśniewski", EnumTypWypozyczajacego.Student, "s12347");
        Person s4 = new Student(GeneratorAjdikow.LastPersonId(), "Maria", "Wójcik", EnumTypWypozyczajacego.Student, "s12348");
        Person s5 = new Student(GeneratorAjdikow.LastPersonId(), "Tomasz", "Kowalczyk", EnumTypWypozyczajacego.Student, "s12349");
        Person s6 = new Student(GeneratorAjdikow.LastPersonId(), "Katarzyna", "Kamińska", EnumTypWypozyczajacego.Student, "s12350");
        Person s7 = new Student(GeneratorAjdikow.LastPersonId(), "Michał", "Lewandowski", EnumTypWypozyczajacego.Student, "s12351");
        Person s8 = new Student(GeneratorAjdikow.LastPersonId(), "Agnieszka", "Zielińska", EnumTypWypozyczajacego.Student, "s12352");
        Person s9 = new Student(GeneratorAjdikow.LastPersonId(), "Krzysztof", "Szymański", EnumTypWypozyczajacego.Student, "s12353");
        Person s10 = new Student(GeneratorAjdikow.LastPersonId(), "Małgorzata", "Woźniak", EnumTypWypozyczajacego.Student, "s12354");
        
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
        

        Device r1 = new Projector(GeneratorAjdikow.LastDeviceId(), "Epson EB-695Wi", true, 3500, "1920x1080");
        Device r2 = new Projector(GeneratorAjdikow.LastDeviceId(), "BenQ TH585", true, 3200, "1920x1080");
        Device r3 = new Projector(GeneratorAjdikow.LastDeviceId(), "Sony VPL-FHZ55", false, 4000, "3840x2160");
        Device r4 = new Projector(GeneratorAjdikow.LastDeviceId(), "Optoma UHD50", true, 3000, "3840x2160");
        Device r5 = new Projector(GeneratorAjdikow.LastDeviceId(), "ViewSonic PX747", true, 3500, "3840x2160");
        Device r6 = new Projector(GeneratorAjdikow.LastDeviceId(), "Panasonic PT-VZ580", false, 4000, "1920x1200");
        Device r7 = new Projector(GeneratorAjdikow.LastDeviceId(), "NEC NP-P452H", true, 4500, "1920x1080");
        Device r8 = new Projector(GeneratorAjdikow.LastDeviceId(), "Acer H6815", true, 3200, "1920x1080");
        Device r9 = new Projector(GeneratorAjdikow.LastDeviceId(), "LG PF50KA", true, 600, "1920x1080");
        Device r10 = new Projector(GeneratorAjdikow.LastDeviceId(), "Samsung The Freestyle", true, 550, "1920x1080");
 
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

      