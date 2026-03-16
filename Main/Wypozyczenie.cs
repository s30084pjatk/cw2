namespace ConsoleApp1;

public class Wypozyczenie
{
    public Person Osoba { get; set; }
    public Device Sprzet { get; set; }
    public DateTime DataWypozyczenia { get; set; }
    public DateTime? TerminZwrotu { get; set; }
    public int Kara { get; set; }

    public Wypozyczenie(Person osoba, Device sprzet, DateTime dataWypozyczenia, DateTime? terminZwrotu, int kara)
    {
        Osoba = osoba;
        Sprzet = sprzet;
        DataWypozyczenia = dataWypozyczenia;
        TerminZwrotu = terminZwrotu;
        Kara = kara;
    }
}