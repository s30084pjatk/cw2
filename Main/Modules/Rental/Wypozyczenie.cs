namespace ConsoleApp1;

public class Wypozyczenie
{
    public static int RentalDurationDefaultTime = 14;
    public static int KaraDefaultValue = 10;
    public int Id { get; set; }
    public Person_parent Osoba { get; set; }
    public Device_parent Sprzet { get; set; }
    public DateTime DataWypozyczenia { get; set; }
    public DateTime? TerminZwrotu { get; set; }
    public int Kara { get; set; }
    public DateTime? FaktycznaDataZwrotu { get; set; }

    public Wypozyczenie(Person_parent osoba, Device_parent sprzet, DateTime dataWypozyczenia, DateTime terminZwrotu)
    {
        Id = GeneratorAjdikow.LastRentalId();
        Osoba = osoba;
        Sprzet = sprzet;
        DataWypozyczenia = dataWypozyczenia;
        TerminZwrotu = terminZwrotu;
        Kara = 0;
        FaktycznaDataZwrotu = null;
    }

    public bool Czy_Aktywne()
    {
        return FaktycznaDataZwrotu == null;
    }

    public bool CzyOpoznione()
    {
        return Czy_Aktywne() && DateTime.Now > TerminZwrotu;
    }
}