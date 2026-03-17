namespace ConsoleApp1;

public class Wypozyczenie
{
    public int Id { get; set; }
    public Person Osoba { get; set; }
    public Device Sprzet { get; set; }
    public DateTime DataWypozyczenia { get; set; }
    public DateTime? TerminZwrotu { get; set; }
    public int Kara { get; set; }
    public DateTime? FaktycznaDataZwrotu {get; set; }

    public Wypozyczenie(Person osoba, Device sprzet, DateTime dataWypozyczenia, DateTime terminZwrotu)
    {
        Id = GeneratorAjdikow.LastRentalId();
        Osoba = osoba;
        Sprzet = sprzet;
        DataWypozyczenia = dataWypozyczenia;
        TerminZwrotu = terminZwrotu;
        Kara = 0;
        FaktycznaDataZwrotu =  null;
    }
}