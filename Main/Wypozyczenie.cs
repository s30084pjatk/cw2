namespace ConsoleApp1;

public class Wypozyczenie
{
    public Person Osoba { get; set; }
    public Device Sprzet { get; set; }
    public DateTime DataWypozyczenia { get; set; }
    public DateTime? TerminZwrotu { get; set; }
    public int Kara { get; set; }
}